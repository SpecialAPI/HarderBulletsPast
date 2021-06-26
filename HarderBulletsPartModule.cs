using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarderBulletsPast
{
    public class HarderBulletsPartModule : ETGModule
    {
        public override void Init()
        {
        }

        public override void Start()
        {
            List<AttackBehaviorGroup.AttackGroupItem> items = EnemyDatabase.GetOrLoadByGuid("2ccaa1b7ae10457396a1796decda9cf6").behaviorSpeculator.AttackBehaviorGroup.AttackBehaviors;
            items.Remove(items.Find((AttackBehaviorGroup.AttackGroupItem item) => item.NickName == "Reflect Shot"));
        }

        public override void Exit()
        {
        }
    }
}
