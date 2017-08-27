using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarCommander.Configeration;
using StarCommander.Types;

namespace StarCommander.Factories
{
    public class ShipConfigerationFactory
    {
        public static IShipConfigeration CreateShipConfiguration(Nullable<ShipType> shipType, Nullable<ShipConfigurationType> shipConfigurationType)
        {

            switch (shipConfigurationType)
            {
                case ShipConfigurationType.Heavy:
                    IShipConfigeration heavy = new ShipConfigeration();
                    CreateHeavyDefaultCollection(heavy, shipType);
                    return heavy;
                case ShipConfigurationType.Light:
                    IShipConfigeration light = new ShipConfigeration();
                    CreateLightDefaultCollection(light, shipType);
                    return light;
                case ShipConfigurationType.Balanced:
                    IShipConfigeration balanced = new ShipConfigeration();
                    CreateBalancedDefaultCollection(balanced, shipType);
                    return balanced;
                default:
                    return null;
            }
        }

        private static void CreateBalancedDefaultCollection(IShipConfigeration balanced, ShipType? shipType)
        {
            switch (shipType)
            {
                case ShipType.Fighter:
                    CreateFighterBalancedDefaultCollection(balanced);
                    break;
                case ShipType.Friget:
                    CreateFrigetBalancedDefaultCollection(balanced);
                    break;
                case ShipType.Destroyer:
                    CreateDestoyerBalancedDefaultCollection(balanced);
                    break;
                default:
                    break;
            }
        }

        private static void CreateDestoyerBalancedDefaultCollection(IShipConfigeration balanced)
        {
            //Add multiple lasers
            for (int i = 0; i < 46; i++)
            {
                balanced.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser));
            }

            //Add multiple missiles
            for (int i = 0; i < 20; i++)
            {
                balanced.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile));
            }

            //Add multiple photonTorpedo
            for (int i = 0; i < 8; i++)
            {
                balanced.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo));
            }

            //Add multiple plasmaCannon
            for (int i = 0; i < 4; i++)
            {
                balanced.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon));
            }

            //Add multiple deflectionShield
            for (int i = 0; i < 6; i++)
            {
                balanced.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield));
            }
            
            //Add multiple shieldBooster
            for (int i = 0; i < 3; i++)
            {
                balanced.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster));
            }

            //Add single
            balanced.upgradeImplements.Add(UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MineField));
            
        }

        private static void CreateFrigetBalancedDefaultCollection(IShipConfigeration balanced)
        {
            //Add multiple lasers
            for (int i = 0; i < 12; i++)
            {
                balanced.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser));
            }

            //Add multiple missiles
            for (int i = 0; i < 6; i++)
            {
                balanced.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile));
            }

            //Add multiple photonTorpedo
            for (int i = 0; i < 4; i++)
            {
                balanced.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo));
            }

            //Add multiple deflectionShield
            for (int i = 0; i < 3; i++)
            {
                balanced.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield));
            }

            //Add singles
            balanced.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster));
            balanced.upgradeImplements.Add(UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MetalicMicrobes));
        }

        private static void CreateFighterBalancedDefaultCollection(IShipConfigeration balanced)
        {
            //Add multiple lasers
            for (int i = 0; i < 6; i++)
            {
                balanced.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser));
            }
            
            //Add multiple missiles
            for (int i = 0; i < 4; i++)
            {
                balanced.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile));
            }

            //Add singles
            balanced.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield));
            balanced.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.PolarizedPlating));
            balanced.upgradeImplements.Add(UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.WarpDrive));
        }

        private static void CreateLightDefaultCollection(IShipConfigeration light, ShipType? shipType)
        {
            switch (shipType)
            {
                case ShipType.Fighter:
                    CreateFighterLightDefaultCollection(light);
                    break;
                case ShipType.Friget:
                    CreateFrigetLightDefaultCollection(light);
                    break;
                case ShipType.Destroyer:
                    CreateDestoyerLightDefaultCollection(light);
                    break;
                default:
                    break;
            }
        }

        private static void CreateDestoyerLightDefaultCollection(IShipConfigeration light)
        {
            //Add multiple lasers
            for (int i = 0; i < 78; i++)
            {
                light.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser));
            }

            //Add multiple missiles
            for (int i = 0; i < 20; i++)
            {
                light.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile));
            }

            //Add multiple photonTorpedo
            for (int i = 0; i < 4; i++)
            {
                light.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo));
            }

            //Add multiple plasmaCannon
            for (int i = 0; i < 2; i++)
            {
                light.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon));
            }

            //Add multiple deflectionShield
            for (int i = 0; i < 8; i++)
            {
                light.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield));
            }

            //Add multiple shieldBooster
            for (int i = 0; i < 2; i++)
            {
                light.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster));
            }

            for (int i = 0; i < 2; i++)
            {
                light.upgradeImplements.Add(UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MetalicMicrobes));
            }
        }

        private static void CreateFrigetLightDefaultCollection(IShipConfigeration light)
        {
            //Add multiple lasers
            for (int i = 0; i < 20; i++)
            {
                light.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser));
            }

            //Add multiple missiles
            for (int i = 0; i < 4; i++)
            {
                light.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile));
            }

            //Add multiple photonTorpedo
            for (int i = 0; i < 2; i++)
            {
                light.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo));
            }

            //Add multiple shieldBooster
            for (int i = 0; i < 2; i++)
            {
                light.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster));
            }

            //Add multiple warpDrive
            for (int i = 0; i < 2; i++)
            {
                light.upgradeImplements.Add(UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.WarpDrive));
            }
        }

        private static void CreateFighterLightDefaultCollection(IShipConfigeration light)
        {
            //Add multiple lasers
            for (int i = 0; i < 10; i++)
            {
                light.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser));
            }

            //Add multiple missiles
            for (int i = 0; i < 2; i++)
            {
                light.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile));
            }

            //Add singles
            light.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.PolarizedPlating));
            light.upgradeImplements.Add(UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.WarpDrive));
        }

        private static void CreateHeavyDefaultCollection(IShipConfigeration heavy, Nullable<ShipType> shipType)
        {
            switch (shipType)
            {
                case ShipType.Fighter:
                    CreateFighterHeavyDefaultCollection(heavy);
                    break;
                case ShipType.Friget:
                    CreateFrigetHeavyDefaultCollection(heavy);
                    break;
                case ShipType.Destroyer:
                    CreateDestoyerHeavyDefaultCollection(heavy);
                    break;
                default:
                    break;
            }
        }

        private static void CreateDestoyerHeavyDefaultCollection(IShipConfigeration heavy)
        {
            //Add multiple lasers
            for (int i = 0; i < 22; i++)
            {
                heavy.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser));
            }

            //Add multiple missiles
            for (int i = 0; i < 20; i++)
            {
                heavy.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile));
            }

            //Add multiple photonTorpedo
            for (int i = 0; i < 10; i++)
            {
                heavy.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo));
            }

            //Add multiple plasmaCannon
            for (int i = 0; i < 6; i++)
            {
                heavy.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon));
            }

            //Add multiple deflectionShield
            for (int i = 0; i < 3; i++)
            {
                heavy.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield));
            }

            //Add multiple shieldBooster
            for (int i = 0; i < 4; i++)
            {
                heavy.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster));
            }

            //Add single
            heavy.upgradeImplements.Add(UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MineField));
        }

        private static void CreateFrigetHeavyDefaultCollection(IShipConfigeration heavy)
        {
            //Add multiple lasers
            for (int i = 0; i < 8; i++)
            {
                heavy.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser));
            }

            //Add multiple missiles
            for (int i = 0; i < 4; i++)
            {
                heavy.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile));
            }

            //Add multiple photonTorpedo
            for (int i = 0; i < 4; i++)
            {
                heavy.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.PhotonTorpedo));
            }

            //Add multiple deflectionShield
            for (int i = 0; i < 6; i++)
            {
                heavy.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.DeflectionShield));
            }

            //Add singles
            heavy.upgradeImplements.Add(UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.MetalicMicrobes));
            heavy.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.PlasmaCannon));

        }

        private static void CreateFighterHeavyDefaultCollection(IShipConfigeration heavy)
        {
            //Add multiple lasers
            for (int i = 0; i < 2; i++)
            {
                heavy.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Laser));
            }

            //Add multiple missiles
            for (int i = 0; i < 6; i++)
            {
                heavy.attackImplements.Add(AttackImplementFactory.CreateAttackImplement(AttackImplementType.Missile));
            }

            //Add singles
            heavy.defendImplements.Add(DefendImplementFactory.CreateDefendImplement(DefendImplementType.ShieldBooster));
            heavy.upgradeImplements.Add(UpgradeImplementFactory.CreateUpgradeImplement(UpgradeImplementType.WarpDrive));
        }
    }
}
