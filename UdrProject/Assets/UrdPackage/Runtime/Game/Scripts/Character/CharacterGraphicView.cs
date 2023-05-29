using MyBox;
using UnityEngine;
using Urd.Character.Skill;
using Urd.Services.Physics;

namespace Urd.Character
{
    public class CharacterGraphicView : MonoBehaviour
    {
        // movement related
        private const string ANIMATION_KEY_MOVEMENT_X = "MOVEMENT_X";
        private const string ANIMATION_KEY_MOVEMENT_Y = "MOVEMENT_Y";
        private const string ANIMATION_KEY_AIM_X = "AIM_X";
        private const string ANIMATION_KEY_AIM_Y = "AIM_Y";
        private const string ANIMATION_KEY_IS_MOVING = "IS_MOVING";
        private const string ANIMATION_KEY_IS_SKILL = "IS_SKILL";
        
        // hit related
        private const string ANIMATION_KEY_IS_HIT = "IS_HIT";
        
        [SerializeField]
        private SpriteRenderer _mainImage;
        
        [SerializeField]
        private Animator _animator;
        
        [Header("AIM")]
        [SerializeField]
        private SpriteRenderer _aimImage;
        [SerializeField]
        private float _aimOffset;

        private CharacterModel _characterModel;
        private string _lastAnimation;
        
        public void SetModel(CharacterModel characterModel)
        {
            _characterModel = characterModel;

            Init();
        }

        private void Init()
        {
            // movement related
            _characterModel.CharacterMovement.OnRawNormalizedMovementChanged += OnRawNormalizedPositionChanged;
            _characterModel.CharacterMovement.OnIsMovingChanged += OnMovingChanged;
            _characterModel.CharacterMovement.OnAimDirectionChanged += OnAimDirectionChanged;
            _characterModel.SkillSetModel.OnIsSkill += OnIsSkill;
            _characterModel.SkillSetModel.OnSkillAction += OnSkillAction;
            
            // hitted related
            _characterModel.HitPoints.OnIsHit += OnIsHit;
            //_characterModel.HitPoints.OnHitted += OnHitted;
        }

        private void OnIsHit(bool isHit)
        {
            _animator.SetBool(ANIMATION_KEY_IS_HIT, isHit);
        }

        private void OnSkillAction(ISkillModel skillModel)
        {
            _animator.Play(skillModel.SkillAnimationModel.AnimationName.ToString());
        }

        private void OnIsSkill(bool onIsSkill)
        {
            _animator.SetBool(ANIMATION_KEY_IS_SKILL, onIsSkill);
            if (!onIsSkill && !string.IsNullOrEmpty(_lastAnimation))
            {
                _animator.SetBool(_lastAnimation, false);
                _lastAnimation = null;
            }
        }

        private void OnMovingChanged(bool isMoving)
        {
            _animator.SetBool(ANIMATION_KEY_IS_MOVING, isMoving);
        }
        
        private void OnAimDirectionChanged(Vector2 aimDirection)
        {
            _aimImage.transform.SetXY(
                transform.position.x + aimDirection.x * _aimOffset,
                transform.position.y + aimDirection.y * _aimOffset);
            
            _animator.SetFloat(ANIMATION_KEY_AIM_X, aimDirection.x);
            _animator.SetFloat(ANIMATION_KEY_AIM_Y, aimDirection.y);
        }

        private void OnRawNormalizedPositionChanged(Vector2 newRawNormalizedPosition)
        {
            _animator.SetFloat(ANIMATION_KEY_MOVEMENT_X, newRawNormalizedPosition.x);
            _animator.SetFloat(ANIMATION_KEY_MOVEMENT_Y, newRawNormalizedPosition.y);
        }
    }
}
