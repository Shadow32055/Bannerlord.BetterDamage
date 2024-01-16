using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace BetterDamage.Settings {

    public class MCMSettings : AttributeGlobalSettings<MCMSettings> {


        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Undefined", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float UndefinedAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Dagger", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float DaggerAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}One Handed Sword", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float OneHandedSwordAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Two Handed Sword", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float TwoHandedSwordAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}One Handed Axe", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float OneHandedAxeAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Two Handed Axe", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float TwoHandedAxeAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Mace", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float MaceAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Pick", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float PickAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Two Handed Mace", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float TwoHandedMaceAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}One Handed Polearm", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float OneHandedPolearmAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Two Handed Polearm", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float TwoHandedPolearmAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Low Grip Polearm", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float LowGripPolearmAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Arrow", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float ArrowAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Bolt", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float BoltAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Cartridge", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float CartridgeAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Bow", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float BowAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Crossbow", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float CrossbowAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Stone", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float StoneAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Boulder", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float BoulderAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Throwing Axe", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float ThrowingAxeAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Throwing Knife", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float ThrowingKnifeAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Javelin", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float JavelinAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Pistol", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float PistolAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Musket", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float MusketAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Small Shield", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float SmallShieldAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Large Shield", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float LargeShieldAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Banner", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float BannerAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Damage Adjustments")]
        [SettingPropertyFloatingInteger("{=BC_5th0a2}Num Classes", 0f, 5f, "0.0 %", Order = 0, RequireRestart = false, HintText = "{=BC_C7twl6}Adjust weapon damage")]
        public float NumClassesAdjustment { get; set; } = 1f;

        [SettingPropertyGroup("Misc")]
        [SettingPropertyBool("Weapon class helper", Order = 1, RequireRestart = false, HintText = "Enable this to display the weapon class the player is currently using on attack, mainly for debug purposes.")]
        public bool WepClassHelper { get; set; } = false;

        public override string Id { get { return base.GetType().Assembly.GetName().Name; } }
        public override string DisplayName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FolderName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FormatType { get; } = "xml";
        public bool LoadMCMConfigFile { get; set; } = true;
    }
}
