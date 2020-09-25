using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace IW_WEAPON_HELPER.Model
{

    [Serializable]
    public class Weapon
    {
        public string headerData;

        #region WEAPON_VARIABLES
        public bool? disableFiring = null;
        public bool? disableSwitchToWhenEmpty = null;
        public bool? missileConeSoundCrossfadeEnabled = null;
        public bool? missileConeSoundEnabled = null;
        public bool? missileConeSoundPitchshiftEnabled = null;
        public bool? turretBarrelSpinEnabled = null;
        public float? accuracy = null;
        public float? adsAimPitch = null;
        public float? adsBobFactor = null;
        public float? adsCrosshairInFrac = null;
        public float? adsCrosshairOutFrac = null;
        public float? adsDofEnd = null;
        public float? adsDofStart = null;
        public float? adsFire = null;
        public float? adsGunKickAccel = null;
        public float? adsGunKickPitchMax = null;
        public float? adsGunKickPitchMin = null;
        public float? adsGunKickReducedKickBullets = null;
        public float? adsGunKickReducedKickPercent = null;
        public float? adsGunKickSpeedDecay = null;
        public float? adsGunKickSpeedMax = null;
        public float? adsGunKickStaticDecay = null;
        public float? adsGunKickYawMax = null;
        public float? adsGunKickYawMin = null;
        public float? adsIdleAmount = null;
        public float? adsIdleSpeed = null;
        public float? adsMoveSpeedScale = null;
        public float? adsOverlayHeight = null;
        public float? adsOverlayHeightSplitscreen = null;
        public float? adsOverlayWidth = null;
        public float? adsOverlayWidthSplitscreen = null;
        public float? adsReloadTransTime = null;
        public float? adsSpread = null;
        public float? adsSwayHorizScale = null;
        public float? adsSwayLerpSpeed = null;
        public float? adsSwayMaxAngle = null;
        public float? adsSwayPitchScale = null;
        public float? adsSwayVertScale = null;
        public float? adsSwayYawScale = null;
        public float? adsTransInTime = null;
        public float? adsTransOutTime = null;
        public float? adsViewBobMult = null;
        public float? adsViewErrorMax = null;
        public float? adsViewErrorMin = null;
        public float? adsViewKickCenterSpeed = null;
        public float? adsViewKickPitchMax = null;
        public float? adsViewKickPitchMin = null;
        public float? adsViewKickYawMax = null;
        public float? adsViewKickYawMin = null;
        public float? adsZoomFov = null;
        public float? adsZoomInFrac = null;
        public float? adsZoomOutFrac = null;
        public float? aiSpread = null;
        public float? aifuseTime = null;
        public float? aimAssistRange = null;
        public float? aimAssistRangeAds = null;
        public float? aimDownSight = null;
        public float? aimPadding = null;
        public float? altDropTime = null;
        public float? altModeSameWeapon = null;
        public float? altRaiseTime = null;
        public float? ammoDropClipPercentMax = null;
        public float? ammoDropClipPercentMin = null;
        public float? animHorRotateInc = null;
        public float? armorPiercing = null;
        public float? autoAimRange = null;
        public float? avoidDropCleanup = null;
        public float? bBulletExplosiveDamage = null;
        public float? bigExplosion = null;
        public float? blocksProne = null;
        public float? boltAction = null;
        public float? bottomArc = null;
        public float? breachRaiseTime = null;
        public float? bulletExplDmgMult = null;
        public float? bulletExplRadiusMult = null;
        public float? cancelAutoHolsterWhenEmpty = null;
        public float? clipOnly = null;
        public float? clipSize = null;
        public float? cookOffHold = null;
        public float? crosshairColorChange = null;
        public float? damage = null;
        public float? damageConeAngle = null;
        public float? destabilizationCurvatureMax = null;
        public float? destabilizationRateTime = null;
        public float? destabilizeDistance = null;
        public float? detonateDelay = null;
        public float? detonateTime = null;
        public float? dpadIconShowsAmmo = null;
        public float? dropAmmoMax = null;
        public float? dropAmmoMin = null;
        public float? dropTime = null;
        public float? dualWieldViewModelOffset = null;
        public float? duckedMoveF = null;
        public float? duckedMoveMinSpeed = null;
        public float? duckedMoveR = null;
        public float? duckedMoveU = null;
        public float? duckedOfsF = null;
        public float? duckedOfsR = null;
        public float? duckedOfsU = null;
        public float? duckedRotMinSpeed = null;
        public float? duckedRotP = null;
        public float? duckedRotR = null;
        public float? duckedRotY = null;
        public float? emptyDropTime = null;
        public float? emptyRaiseTime = null;
        public float? enemyCrosshairRange = null;
        public float? enhanced = null;
        public float? explosionInnerDamage = null;
        public float? explosionOuterDamage = null;
        public float? explosionRadius = null;
        public float? explosionRadiusMin = null;
        public float? fightDist = null;
        public float? fireDelay = null;
        public float? fireTime = null;
        public float? firstRaiseTime = null;
        public float? flipKillIcon = null;
        public float? freezeMovementWhenFiring = null;
        public float? fuseTime = null;
        public float? gunMaxPitch = null;
        public float? gunMaxYaw = null;
        public float? hasDetonator = null;
        public float? hipGunKickAccel = null;
        public float? hipGunKickPitchMax = null;
        public float? hipGunKickPitchMin = null;
        public float? hipGunKickReducedKickBullets = null;
        public float? hipGunKickReducedKickPercent = null;
        public float? hipGunKickSpeedDecay = null;
        public float? hipGunKickSpeedMax = null;
        public float? hipGunKickStaticDecay = null;
        public float? hipGunKickYawMax = null;
        public float? hipGunKickYawMin = null;
        public float? hipIdleAmount = null;
        public float? hipIdleSpeed = null;
        public float? hipReticleSidePos = null;
        public float? hipSpreadDecayRate = null;
        public float? hipSpreadDuckedDecay = null;
        public float? hipSpreadDuckedMax = null;
        public float? hipSpreadDuckedMin = null;
        public float? hipSpreadFireAdd = null;
        public float? hipSpreadMax = null;
        public float? hipSpreadMoveAdd = null;
        public float? hipSpreadProneDecay = null;
        public float? hipSpreadProneMax = null;
        public float? hipSpreadProneMin = null;
        public float? hipSpreadStandMin = null;
        public float? hipSpreadTurnAdd = null;
        public float? hipViewKickCenterSpeed = null;
        public float? hipViewKickPitchMax = null;
        public float? hipViewKickPitchMin = null;
        public float? hipViewKickYawMax = null;
        public float? hipViewKickYawMin = null;
        public float? holdButtonToThrow = null;
        public float? holdFireTime = null;
        public float? horizViewJitter = null;
        public float? idleCrouchFactor = null;
        public float? idleProneFactor = null;
        public float? inheritsPerks = null;
        public float? isRollingGrenade = null;
        public float? laserSightDuringNightvision = null;
        public float? leftArc = null;
        public float? locGun = null;
        public float? locHead = null;
        public float? locHelmet = null;
        public float? locLeftArmLower = null;
        public float? locLeftArmUpper = null;
        public float? locLeftFoot = null;
        public float? locLeftHand = null;
        public float? locLeftLegLower = null;
        public float? locLeftLegUpper = null;
        public float? locNeck = null;
        public float? locNone = null;
        public float? locRightArmLower = null;
        public float? locRightArmUpper = null;
        public float? locRightFoot = null;
        public float? locRightHand = null;
        public float? locRightLegLower = null;
        public float? locRightLegUpper = null;
        public float? locTorsoLower = null;
        public float? locTorsoUpper = null;
        public float? lockonSupported = null;
        public float? lowAmmoWarningThreshold = null;
        public float? markableViewmodel = null;
        public float? maxAmmo = null;
        public float? maxDamageRange = null;
        public float? maxDist = null;
        public float? maxHorTurnSpeed = null;
        public float? maxRange = null;
        public float? maxSteeringAccel = null;
        public float? maxVertTurnSpeed = null;
        public float? meleeChargeDelay = null;
        public float? meleeChargeTime = null;
        public float? meleeDamage = null;
        public float? meleeDelay = null;
        public float? meleeTime = null;
        public float? minDamage = null;
        public float? minDamageRange = null;
        public float? minHorTurnSpeed = null;
        public float? minPlayerDamage = null;
        public float? minVertTurnSpeed = null;
        public float? missileConeSoundCrossfadeBottomSize = null;
        public float? missileConeSoundCrossfadeTopSize = null;
        public float? missileConeSoundHeight = null;
        public float? missileConeSoundOriginOffset = null;
        public float? missileConeSoundPitchAtBottom = null;
        public float? missileConeSoundPitchAtTop = null;
        public float? missileConeSoundPitchBottomSize = null;
        public float? missileConeSoundPitchTopSize = null;
        public float? missileConeSoundRadiusAtBase = null;
        public float? missileConeSoundRadiusAtTop = null;
        public float? missileConeSoundVolumescaleAtCore = null;
        public float? missileConeSoundVolumescaleAtEdge = null;
        public float? missileConeSoundVolumescaleCoreSize = null;
        public float? motionTracker = null;
        public float? moveSpeedScale = null;
        public float? nightVisionRemoveTime = null;
        public float? nightVisionRemoveTimeFadeInStart = null;
        public float? nightVisionRemoveTimePowerDown = null;
        public float? nightVisionWearTime = null;
        public float? nightVisionWearTimeFadeOutEnd = null;
        public float? nightVisionWearTimePowerUp = null;
        public float? noAdsWhenMagEmpty = null;
        public float? noAmmoPickup = null;
        public float? noDualWield = null;
        public float? noPartialReload = null;
        public float? offhandHoldIsCancelable = null;
        public float? parallelAsphaltBounce = null;
        public float? parallelBarkBounce = null;
        public float? parallelBrickBounce = null;
        public float? parallelCarpetBounce = null;
        public float? parallelCeramicBounce = null;
        public float? parallelClothBounce = null;
        public float? parallelConcreteBounce = null;
        public float? parallelCushionBounce = null;
        public float? parallelDefaultBounce = null;
        public float? parallelDirtBounce = null;
        public float? parallelFleshBounce = null;
        public float? parallelFoliageBounce = null;
        public float? parallelFruitBounce = null;
        public float? parallelGlassBounce = null;
        public float? parallelGrassBounce = null;
        public float? parallelGravelBounce = null;
        public float? parallelIceBounce = null;
        public float? parallelMetalBounce = null;
        public float? parallelMudBounce = null;
        public float? parallelPaintedMetalBounce = null;
        public float? parallelPaperBounce = null;
        public float? parallelPlasterBounce = null;
        public float? parallelPlasticBounce = null;
        public float? parallelRiotShieldBounce = null;
        public float? parallelRockBounce = null;
        public float? parallelRubberBounce = null;
        public float? parallelSandBounce = null;
        public float? parallelSlushBounce = null;
        public float? parallelSnowBounce = null;
        public float? parallelWaterBounce = null;
        public float? parallelWoodBounce = null;
        public float? penetrateMultiplier = null;
        public float? perpendicularAsphaltBounce = null;
        public float? perpendicularBarkBounce = null;
        public float? perpendicularBrickBounce = null;
        public float? perpendicularCarpetBounce = null;
        public float? perpendicularCeramicBounce = null;
        public float? perpendicularClothBounce = null;
        public float? perpendicularConcreteBounce = null;
        public float? perpendicularCushionBounce = null;
        public float? perpendicularDefaultBounce = null;
        public float? perpendicularDirtBounce = null;
        public float? perpendicularFleshBounce = null;
        public float? perpendicularFoliageBounce = null;
        public float? perpendicularFruitBounce = null;
        public float? perpendicularGlassBounce = null;
        public float? perpendicularGrassBounce = null;
        public float? perpendicularGravelBounce = null;
        public float? perpendicularIceBounce = null;
        public float? perpendicularMetalBounce = null;
        public float? perpendicularMudBounce = null;
        public float? perpendicularPaintedMetalBounce = null;
        public float? perpendicularPaperBounce = null;
        public float? perpendicularPlasterBounce = null;
        public float? perpendicularPlasticBounce = null;
        public float? perpendicularRiotShieldBounce = null;
        public float? perpendicularRockBounce = null;
        public float? perpendicularRubberBounce = null;
        public float? perpendicularSandBounce = null;
        public float? perpendicularSlushBounce = null;
        public float? perpendicularSnowBounce = null;
        public float? perpendicularWaterBounce = null;
        public float? perpendicularWoodBounce = null;
        public float? pitchConvergenceTime = null;
        public float? playerDamage = null;
        public float? playerPositionDist = null;
        public float? playerSpread = null;
        public float? posMoveRate = null;
        public float? posProneMoveRate = null;
        public float? posProneRotRate = null;
        public float? posRotRate = null;
        public float? projExplosionEffectForceNormalUp = null;
        public float? projIgnitionDelay = null;
        public float? projImpactExplode = null;
        public float? projectileActivateDist = null;
        public float? projectileBlue = null;
        public float? projectileCurvature = null;
        public float? projectileGreen = null;
        public float? projectileLifetime = null;
        public float? projectileRed = null;
        public float? projectileSpeed = null;
        public float? projectileSpeedForward = null;
        public float? projectileSpeedUp = null;
        public float? proneMoveF = null;
        public float? proneMoveMinSpeed = null;
        public float? proneMoveR = null;
        public float? proneMoveU = null;
        public float? proneOfsF = null;
        public float? proneOfsR = null;
        public float? proneOfsU = null;
        public float? proneRotMinSpeed = null;
        public float? proneRotP = null;
        public float? proneRotR = null;
        public float? proneRotY = null;
        public float? quickDropTime = null;
        public float? quickRaiseTime = null;
        public float? raiseTime = null;
        public float? rechamberBoltTime = null;
        public float? rechamberTime = null;
        public float? rechamberTimeOneHanded = null;
        public float? rechamberWhileAds = null;
        public float? reloadAddTime = null;
        public float? reloadAmmoAdd = null;
        public float? reloadEmptyTime = null;
        public float? reloadEndTime = null;
        public float? reloadShowRocketTime = null;
        public float? reloadStartAdd = null;
        public float? reloadStartAddTime = null;
        public float? reloadStartTime = null;
        public float? reloadTime = null;
        public float? requireLockonToFire = null;
        public float? reticleCenterSize = null;
        public float? reticleMinOfs = null;
        public float? reticleSideSize = null;
        public float? ricochetChance = null;
        public float? rifleBullet = null;
        public float? rightArc = null;
        public float? rotate = null;
        public float? scanAccel = null;
        public float? scanPauseTime = null;
        public float? scanSpeed = null;
        public float? segmentedReload = null;
        public float? shareAmmo = null;
        public float? sharedAmmoCap = null;
        public float? shotCount = null;
        public float? silenced = null;
        public float? sprintDurationScale = null;
        public float? sprintInTime = null;
        public float? sprintLoopTime = null;
        public float? sprintOutTime = null;
        public float? standMoveF = null;
        public float? standMoveMinSpeed = null;
        public float? standMoveR = null;
        public float? standMoveU = null;
        public float? standRotMinSpeed = null;
        public float? standRotP = null;
        public float? standRotR = null;
        public float? standRotY = null;
        public float? startAmmo = null;
        public float? stickToPlayers = null;
        public float? strafeMoveF = null;
        public float? strafeMoveR = null;
        public float? strafeMoveU = null;
        public float? strafeRotP = null;
        public float? strafeRotR = null;
        public float? strafeRotY = null;
        public float? stunnedTimeBegin = null;
        public float? stunnedTimeEnd = null;
        public float? stunnedTimeLoop = null;
        public float? suppressAmmoReserveDisplay = null;
        public float? suppressionTime = null;
        public float? swayHorizScale = null;
        public float? swayLerpSpeed = null;
        public float? swayMaxAngle = null;
        public float? swayPitchScale = null;
        public float? swayShellShockScale = null;
        public float? swayVertScale = null;
        public float? swayYawScale = null;
        public float? thermalScope = null;
        public float? timeToAccelerate = null;
        public float? timedDetonation = null;
        public float? topArc = null;
        public float? turretBarrelSpinDownTime = null;
        public float? turretBarrelSpinSpeed = null;
        public float? turretBarrelSpinUpTime = null;
        public float? turretOverheatDownRate = null;
        public float? turretOverheatPenalty = null;
        public float? turretOverheatUpRate = null;
        public float? turretScopeZoomMax = null;
        public float? turretScopeZoomMin = null;
        public float? turretScopeZoomRate = null;
        public float? vertViewJitter = null;
        public float? yawConvergenceTime = null;
        public string activeReticleType = null;
        public string adsDownAnim = null;
        public string adsDownAnimL = null;
        public string adsDownAnimR = null;
        public string adsFireAnim = null;
        public string adsFireAnimL = null;
        public string adsFireAnimR = null;
        public string adsLastShotAnim = null;
        public string adsLastShotAnimL = null;
        public string adsLastShotAnimR = null;
        public string adsOverlayInterface = null;
        public string adsOverlayReticle = null;
        public string adsOverlayShader = null;
        public string adsOverlayShaderEMP = null;
        public string adsOverlayShaderEMPLowRes = null;
        public string adsOverlayShaderLowRes = null;
        public string adsRechamberAnim = null;
        public string adsUpAnim = null;
        public string adsUpAnimL = null;
        public string adsUpAnimR = null;
        public string aiVsAiAccuracyGraph = null;
        public string aiVsPlayerAccuracyGraph = null;
        public string altDropAnim = null;
        public string altRaiseAnim = null;
        public string altSwitchSound = null;
        public string altSwitchSoundPlayer = null;
        public string altWeapon = null;
        public string ammoCounterClip = null;
        public string ammoCounterIcon = null;
        public string ammoCounterIconRatio = null;
        public string ammoPickupSound = null;
        public string ammoPickupSoundPlayer = null;
        public string bounceSound = null;
        public string breachRaiseAnim = null;
        public string breachRaiseAnimL = null;
        public string breachRaiseAnimR = null;
        public string detonateSound = null;
        public string detonateSoundPlayer = null;
        public string dpadIcon = null;
        public string dpadIconRatio = null;
        public string dropAnim = null;
        public string dropAnimL = null;
        public string dropAnimR = null;
        public string emptyDropAnim = null;
        public string emptyDropAnimL = null;
        public string emptyDropAnimR = null;
        public string emptyFireSound = null;
        public string emptyFireSoundPlayer = null;
        public string emptyIdleAnim = null;
        public string emptyIdleAnimL = null;
        public string emptyIdleAnimR = null;
        public string emptyRaiseAnim = null;
        public string emptyRaiseAnimL = null;
        public string emptyRaiseAnimR = null;
        public string fireAnim = null;
        public string fireAnimL = null;
        public string fireAnimR = null;
        public string fireRumble = null;
        public string fireSound = null;
        public string fireSoundPlayer = null;
        public string fireSoundPlayerAkimbo = null;
        public string fireType = null;
        public string firstRaiseAnim = null;
        public string firstRaiseAnimL = null;
        public string firstRaiseAnimR = null;
        public string firstRaiseSound = null;
        public string firstRaiseSoundPlayer = null;
        public string guidedMissileType = null;
        public string holdFireAnim = null;
        public string hudIcon = null;
        public string hudIconRatio = null;
        public string idleAnim = null;
        public string idleAnimL = null;
        public string idleAnimR = null;
        public string impactType = null;
        public string inventoryType = null;
        public string killIcon = null;
        public string killIconRatio = null;
        public string knifeModel = null;
        public string lastShotAnim = null;
        public string lastShotAnimL = null;
        public string lastShotAnimR = null;
        public string lastShotSound = null;
        public string lastShotSoundPlayer = null;
        public string loopFireSound = null;
        public string loopFireSoundPlayer = null;
        public string meleeAnim = null;
        public string meleeAnimL = null;
        public string meleeAnimR = null;
        public string meleeChargeAnim = null;
        public string meleeChargeAnimL = null;
        public string meleeChargeAnimR = null;
        public string meleeHitSound = null;
        public string meleeImpactRumble = null;
        public string meleeMissSound = null;
        public string meleeSwipeSound = null;
        public string meleeSwipeSoundPlayer = null;
        public string missileConeSoundAlias = null;
        public string missileConeSoundAliasAtBase = null;
        public string nightVisionRemoveAnim = null;
        public string nightVisionRemoveAnimL = null;
        public string nightVisionRemoveAnimR = null;
        public string nightVisionRemoveSound = null;
        public string nightVisionRemoveSoundPlayer = null;
        public string nightVisionWearAnim = null;
        public string nightVisionWearAnimL = null;
        public string nightVisionWearAnimR = null;
        public string nightVisionWearSound = null;
        public string nightVisionWearSoundPlayer = null;
        public string offhandClass = null;
        public string penetrateType = null;
        public string physCollmap = null;
        public string pickupIcon = null;
        public string pickupIconRatio = null;
        public string pickupSound = null;
        public string pickupSoundPlayer = null;
        public string projBeaconEffect = null;
        public string projDudEffect = null;
        public string projDudSound = null;
        public string projExplosionEffect = null;
        public string projExplosionSound = null;
        public string projExplosionType = null;
        public string projIgnitionEffect = null;
        public string projIgnitionSound = null;
        public string projTrailEffect = null;
        public string projectileModel = null;
        public string projectileSound = null;
        public string pullbackSound = null;
        public string pullbackSoundPlayer = null;
        public string putawaySound = null;
        public string putawaySoundPlayer = null;
        public string quickDropAnim = null;
        public string quickDropAnimL = null;
        public string quickDropAnimR = null;
        public string quickRaiseAnim = null;
        public string quickRaiseAnimL = null;
        public string quickRaiseAnimR = null;
        public string raiseAnim = null;
        public string raiseAnimL = null;
        public string raiseAnimR = null;
        public string raiseSound = null;
        public string raiseSoundPlayer = null;
        public string rechamberAnim = null;
        public string rechamberAnimL = null;
        public string rechamberAnimR = null;
        public string rechamberSound = null;
        public string rechamberSoundPlayer = null;
        public string reloadAnim = null;
        public string reloadAnimL = null;
        public string reloadAnimR = null;
        public string reloadEmptyAnim = null;
        public string reloadEmptyAnimL = null;
        public string reloadEmptyAnimR = null;
        public string reloadEmptySound = null;
        public string reloadEmptySoundPlayer = null;
        public string reloadEndAnim = null;
        public string reloadEndAnimL = null;
        public string reloadEndAnimR = null;
        public string reloadEndSound = null;
        public string reloadEndSoundPlayer = null;
        public string reloadSound = null;
        public string reloadSoundPlayer = null;
        public string reloadStartAnim = null;
        public string reloadStartAnimL = null;
        public string reloadStartAnimR = null;
        public string reloadStartSound = null;
        public string reloadStartSoundPlayer = null;
        public string reticleCenter = null;
        public string reticleSide = null;
        public string rocketModel = null;
        public string scanSound = null;
        public string sharedAmmoCapName = null;
        public string sprintInAnim = null;
        public string sprintInAnimL = null;
        public string sprintInAnimR = null;
        public string sprintLoopAnim = null;
        public string sprintLoopAnimL = null;
        public string sprintLoopAnimR = null;
        public string sprintOutAnim = null;
        public string sprintOutAnimL = null;
        public string sprintOutAnimR = null;
        public string stance = null;
        public string stickiness = null;
        public string stopFireSound = null;
        public string stopFireSoundPlayer = null;
        public string tracerType = null;
        public string turretBarrelSpinDownSnd1 = null;
        public string turretBarrelSpinDownSnd2 = null;
        public string turretBarrelSpinDownSnd3 = null;
        public string turretBarrelSpinDownSnd4 = null;
        public string turretBarrelSpinMaxSnd = null;
        public string turretBarrelSpinUpSnd1 = null;
        public string turretBarrelSpinUpSnd2 = null;
        public string turretBarrelSpinUpSnd3 = null;
        public string turretBarrelSpinUpSnd4 = null;
        public string turretOverheatEffect = null;
        public string turretOverheatSound = null;
        public string viewFlashEffect = null;
        public string viewLastShotEjectEffect = null;
        public string viewShellEjectEffect = null;
        public string weaponClass = null;
        public string weaponType = null;
        public string worldClipModel = null;
        public string worldFlashEffect = null;
        public string worldKnifeModel = null;
        public string worldLastShotEjectEffect = null;
        public string worldModel = null;
        public string worldModel2 = null;
        public string worldModel3 = null;
        public string worldModel4 = null;
        public string worldModel5 = null;
        public string worldModel6 = null;
        public string worldModel7 = null;
        public string worldModel8 = null;
        public string worldModel9 = null;
        public string worldShellEjectEffect = null;
        #endregion

        public static Weapon FromIW(string fileContents, Action<string> logFunction=null)
        {
            string[] allLines = fileContents.Split('\n');
            string lastLine = allLines.Last();

            // On the last line, a string is duped two times before the IW definition starts
            // The +2 is for the space and the starting \ that we do not want
            int definitionStart = lastLine.IndexOf(' ') * 2 + 2;
            string definitionLine = lastLine.Substring(definitionStart);

            string headerData = string.Join(Environment.NewLine, allLines.Take(allLines.Length - 1)) + Environment.NewLine + lastLine.Substring(0, definitionStart);

            var statsArr = definitionLine.Split('\\');
            var weapon = new Weapon(headerData.Substring(1)); // Just removing the slight "/" at the end of headerdata - we won't need it
            var properties = typeof(Weapon).GetFields();

            for (int i = 0; i < statsArr.Length - 1; i += 2)
            {
                var name = statsArr[i];
                var value = statsArr[i + 1];

                var validProperties = properties.Where(o => o.Name == name);
                if (validProperties.Count() < 1)
                {
                    logFunction?.Invoke($"The unknown property {name} will not be processed");
                    continue;
                }

                try
                {
                    var property = validProperties.First();
                    if (property.FieldType == typeof(bool?)) property.SetValue(weapon, value.ToString().Equals("0") ? false : true);
                    else if (property.FieldType == typeof(float?)) property.SetValue(weapon, float.TryParse(value, out float fValue) ? (float?)fValue : null);
                    else property.SetValue(weapon, value.ToString());

                    if (property.GetValue(weapon) == null)
                    {
                        logFunction?.Invoke($"Error while processing weapon! Met an invalid field type for {property.Name}! Value is {value.ToString()}, I was expecting a {property.FieldType.ToString()}");
                    }
                }
                catch (Exception e)
                {
                    logFunction?.Invoke($"Error while processing weapon!\n{e.ToString()}.\nInterrupting the processing there");
                    return null;
                }
            }

            return weapon;
        }

        public static Weapon FromXML(string xmlString)
        {
            using (var stringReader = new StringReader(xmlString)) {
                return new XmlSerializer(typeof(Weapon)).Deserialize(stringReader) as Weapon;
            }
        }

        public static Weapon FromJSON(string jsonString)
        {
            return JsonConvert.DeserializeObject<Weapon>(jsonString);
        }

        public string SerializeToIW()
        {
            List<string> propertyLineBuilder = new List<string>() { headerData };
            headerData = null;

            foreach (FieldInfo propertyInfo in this.GetType().GetFields())
            {
                if (propertyInfo.GetValue(this) == null) continue;

                propertyLineBuilder.Add(propertyInfo.Name);
                propertyLineBuilder.Add(propertyInfo.GetValue(this).ToString());
            }

            headerData = propertyLineBuilder[0];

            return string.Join(@"\", propertyLineBuilder);
        }

        public string SerializeToJSON()
        {
            return JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public string SerializeToXML()
        {
            using (var stringWriter = new StringWriter())
            {
                new XmlSerializer(this.GetType()).Serialize(stringWriter, this);
                return stringWriter.ToString();
            }
        }

        private Weapon(string headerData) { 
            this.headerData = headerData; 
        }

        private Weapon() { }
    }
}
