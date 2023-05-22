using System;
using System.Collections.Generic;
using UnityEngine;
using Urd.Game.SkillTrees;
using Urd.Services;
using Urd.Utils;

namespace Urd.Character.Skill
{
    [Serializable] 
    public class MeleeAttackController : SkillController<MeleeAttackModel>
    {
        private List<HitAreaModel> _hitAreas;

        private ServiceHelper<IPhysicsService> _physicsService;
        
        public override void Init(CharacterModel characterModel, ICharacterInput characterInput)
        {
            base.Init(characterModel, characterInput);

            SetModel(_characterModel.SkillSetModel.MeleeAttackModel);
            
            _characterInput.OnAttackingChanged += OnSkillStatusChanged;
        }
        
        public override void Dispose()
        {
            _characterInput.OnAttackingChanged -= OnSkillStatusChanged;
            base.Dispose();
        }

        protected override void BeginSkill(Vector2 direction)
        {
            base.BeginSkill(direction);
            _characterModel.SkillSetModel.SetIsMeleeAttack(true);

            var skillDirection = direction.ConvertToDirection();
            _hitAreas = _skillModel.DamageOverTime.Find( hitArea => hitArea.Direction == skillDirection)?.HitArea;
        }

        protected override void SkillUpdate(float deltaTime)
        {
            base.SkillUpdate(deltaTime);

            CheckDamage();
        }

        private void CheckDamage()
        {
            var hitAreasActives = GetAreasToCheck();
            for (int i = 0; i < hitAreasActives.Count; i++)
            {
                _physicsService.Service.TryHit(hitAreasActives[i].AreaShapeModel);
            }
        }

        private List<HitAreaModel> GetAreasToCheck()
        {
            return _hitAreas.FindAll(
                damageOverTime => damageOverTime.BeginTime < _skillTime
                                  && _skillTime < damageOverTime.EndTime);
            
        }

        protected override void OnFinishSkill()
        {
            base.OnFinishSkill();
            
            _characterModel.SkillSetModel.SetIsMeleeAttack(false);
        }
    }
}