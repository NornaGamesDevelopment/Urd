using System;
using Urd.Game.SkillTrees;

namespace Urd.Character.Skill
{
    [Serializable]
    public class SkillModel<TSkill> where TSkill : SkillConfig
    {
        protected TSkill _skillConfig;

        public string Name => _skillConfig.Name;
        public int LevelToUnlock => _skillConfig.LevelToUnlock;
        public SkillType Type => _skillConfig.Type;
        public ISkillController Controller => _skillConfig.Controller;
        public float Duration => _skillConfig.Duration;
        public CharacterAnimParameters AnimParameter => _skillConfig.AnimParameter;
        
        public SkillModel(TSkill skillConfig)
        {
            _skillConfig = skillConfig;
        }
    }
}