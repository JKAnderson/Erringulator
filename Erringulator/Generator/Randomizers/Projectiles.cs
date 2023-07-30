using SoulsFormats;
using System.Collections.Generic;

namespace Erringulator.Randomizer
{
    internal partial class Randomizer
    {
        private void ProcessBullet(PARAM param)
        {
            PARAM.Row[] rows = FilterRows(param.Rows, RandomizerData.Static.BlacklistBullet);
            Dictionary<string, object[]> options = GetAllOptions(rows, param.AppliedParamdef);
            Dictionary<string, List<object>> values = GetAllValues(rows, param.AppliedParamdef);
            foreach (List<object> list in values.Values)
                list.Shuffle(Rand);

            foreach (PARAM.Row row in rows)
            {
                void v(string field) => row[field].Value = values[field].Pop();
                void o(string field) => row[field].Value = options[field].Random(Rand);
                o("atkId_Bullet");
                o("sfxId_Bullet");
                o("sfxId_Hit");
                o("sfxId_Flick");
                o("life");
                o("dist");
                o("shootInterval");
                o("gravityInRange");
                o("gravityOutRange");
                o("hormingStopRange");
                o("initVellocity");
                o("accelInRange");
                o("accelOutRange");
                o("maxVellocity");
                o("minVellocity");
                o("accelTime");
                o("homingBeginDist");
                o("hitRadius");
                o("hitRadiusMax");
                o("spreadTime");
                o("expDelay");
                o("hormingOffsetRange");
                o("dmgHitRecordLifeTime");
                o("externalForce");
                o("spEffectIDForShooter");
                o("autoSearchNPCThinkID");
                o("HitBulletID");
                o("spEffectId0");
                o("spEffectId1");
                o("spEffectId2");
                o("spEffectId3");
                o("spEffectId4");
                o("numShoot");
                o("homingAngle");
                o("shootAngle");
                o("shootAngleInterval");
                o("shootAngleXInterval");
                o("damageDamp");
                o("spelDamageDamp");
                o("fireDamageDamp");
                o("thunderDamageDamp");
                o("staminaDamp");
                o("knockbackDamp");
                o("shootAngleXZ");
                o("lockShootLimitAng");
                o("prevVelocityDirRate");
                o("atkAttribute");
                o("spAttribute");
                o("Material_AttackType");
                o("Material_AttackMaterial");
                o("isPenetrateChr");
                o("isPenetrateObj");
                o("launchConditionType");
                o("FollowType");
                o("EmittePosType");
                o("isAttackSFX");
                o("isEndlessHit");
                o("isPenetrateMap");
                o("isHitBothTeam");
                o("isUseSharedHitList");
                o("isUseMultiDmyPolyIfPlace");
                o("isHitOtherBulletForceEraseA");
                o("isHitOtherBulletForceEraseB");
                o("isHitForceMagic");
                o("isIgnoreSfxIfHitWater");
                o("isIgnoreMoveStateIfHitWater");
                o("isHitDarkForceMagic");
                o("dmgCalcSide");
                o("isEnableAutoHoming");
                o("isSyncBulletCulcDumypolyPos");
                o("isOwnerOverrideInitAngle");
                o("isInheritSfxToChild");
                o("darkDamageDamp");
                o("bulletSfxDeleteType_byHit");
                o("bulletSfxDeleteType_byLifeDead");
                o("targetYOffsetRange");
                o("shootAngleYMaxRandom");
                o("shootAngleXMaxRandom");
                o("intervalCreateBulletId");
                o("intervalCreateTimeMin");
                o("intervalCreateTimeMax");
                o("predictionShootObserveTime");
                o("intervalCreateWaitTime");
                o("sfxPostureType");
                //o("createLimitGroupId");
                o("isInheritSpeedToChild");
                o("isDisableHitSfx_byChrAndObj");
                o("isCheckWall_byCenterRay");
                o("isHitFlare");
                o("isUseBulletWallFilter");
                o("isNonDependenceMagicForFunnleNum");
                o("isAiInterruptShootNoDamageBullet");
                o("randomCreateRadius");
                o("followOffset_BaseHeight");
                //v("assetNo_Hit");
                o("lifeRandomRange");
                o("homingAngleX");
                o("ballisticCalcType");
                o("attachEffectType");
                o("seId_Bullet1");
                o("seId_Bullet2");
                o("seId_Hit");
                o("seId_Flick");
                o("howitzerShootAngleXMin");
                o("howitzerShootAngleXMax");
                o("howitzerInitMinVelocity");
                o("howitzerInitMaxVelocity");
                o("sfxId_ForceErase");
                o("bulletSfxDeleteType_byForceErase");
                o("followDmypoly_forSfxPose");
                o("followOffset_Radius");
                o("spBulletDistUpRate");
                o("nolockTargetDist");

                if (Settings.ProjectileQuantity == ProjectileQuantity.Minimum || Settings.ProjectileQuantity == ProjectileQuantity.Medium)
                {
                    row["createLimitGroupId"].Value = 1;
                }
            }
        }

        private void ProcessBulletCreateLimit(PARAM param)
        {
            PARAM.Row row = param[1];
            if (Settings.ProjectileQuantity == ProjectileQuantity.Minimum)
            {
                row["limitNum_byGroup"].Value = 1;
                row["isLimitEachOwner"].Value = 0;
            }
            else if (Settings.ProjectileQuantity == ProjectileQuantity.Medium)
            {
                row["limitNum_byGroup"].Value = 3;
                row["isLimitEachOwner"].Value = 1;
            }
        }
    }
}
