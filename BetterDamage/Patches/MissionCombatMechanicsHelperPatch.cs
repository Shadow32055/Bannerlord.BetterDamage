using BetterCore.Utils;
using HarmonyLib;
using System;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BetterDamage.Patches {
    [HarmonyPatch(typeof(MissionCombatMechanicsHelper))]
    class MissionCombatMechanicsHelperPatch {

        [HarmonyPostfix]
        [HarmonyPatch(typeof(MissionCombatMechanicsHelper), "ComputeBlowDamage")]
        public static void ComputeBlowDamage(ref AttackInformation attackInformation, ref AttackCollisionData attackCollisionData, WeaponComponentData attackerWeapon, DamageTypes damageType, float magnitude, int speedBonus, bool cancelDamage, ref int inflictedDamage, ref int absorbedByArmor) {
            try {
                if (attackInformation.AttackerAgentCharacter == null)
                    return;

                if (attackerWeapon == null)
                    return;

                if (BetterDamage.Settings.WepClassHelper) {
                    if (attackInformation.AttackerAgent.IsPlayerControlled) {
                        NotifyHelper.WriteMessage("Weapon class is " + attackerWeapon.WeaponClass, MsgType.Notify);
                    }
                }

                switch (attackerWeapon.WeaponClass) {
                    case WeaponClass.Undefined:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.UndefinedAdjustment);
                        break;
                    case WeaponClass.Dagger:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.DaggerAdjustment);
                        break;
                    case WeaponClass.OneHandedSword:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.OneHandedSwordAdjustment);
                        break;
                    case WeaponClass.TwoHandedSword:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.TwoHandedSwordAdjustment);
                        break;
                    case WeaponClass.OneHandedAxe:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.OneHandedAxeAdjustment);
                        break;
                    case WeaponClass.TwoHandedAxe:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.TwoHandedAxeAdjustment);
                        break;
                    case WeaponClass.Mace:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.MaceAdjustment);
                        break;
                    case WeaponClass.Pick:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.PickAdjustment);
                        break;
                    case WeaponClass.TwoHandedMace:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.TwoHandedMaceAdjustment);
                        break;
                    case WeaponClass.OneHandedPolearm:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.OneHandedPolearmAdjustment);
                        break;
                    case WeaponClass.TwoHandedPolearm:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.TwoHandedPolearmAdjustment);
                        break;
                    case WeaponClass.LowGripPolearm:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.LowGripPolearmAdjustment);
                        break;
                    case WeaponClass.Arrow:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.ArrowAdjustment);
                        break;
                    case WeaponClass.Bolt:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.BoltAdjustment);
                        break;
                    case WeaponClass.Cartridge:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.CartridgeAdjustment);
                        break;
                    case WeaponClass.Bow:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.BowAdjustment);
                        break;
                    case WeaponClass.Crossbow:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.CrossbowAdjustment);
                        break;
                    case WeaponClass.Stone:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.StoneAdjustment);
                        break;
                    case WeaponClass.Boulder:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.BoulderAdjustment);
                        break;
                    case WeaponClass.ThrowingAxe:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.ThrowingAxeAdjustment);
                        break;
                    case WeaponClass.ThrowingKnife:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.ThrowingKnifeAdjustment);
                        break;
                    case WeaponClass.Javelin:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.JavelinAdjustment);
                        break;
                    case WeaponClass.Pistol:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.PistolAdjustment);
                        break;
                    case WeaponClass.Musket:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.MusketAdjustment);
                        break;
                    case WeaponClass.SmallShield:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.SmallShieldAdjustment);
                        break;
                    case WeaponClass.LargeShield:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.LargeShieldAdjustment);
                        break;
                    case WeaponClass.Banner:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.BannerAdjustment);
                        break;
                    case WeaponClass.NumClasses:
                        inflictedDamage = (int)(inflictedDamage * BetterDamage.Settings.NumClassesAdjustment);
                        break;
                }
            } catch (Exception e) {
                NotifyHelper.WriteError(BetterDamage.ModName, "MissionCombatMechanicsHelper.ComputeBlowDamage threw exception: " + e);
            }
        }
    }
}
