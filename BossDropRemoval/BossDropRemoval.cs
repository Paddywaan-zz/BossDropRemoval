using RoR2;
using BepInEx;
using System.Reflection;
using R2API;
using UnityEngine;
using System.Collections.Generic;
using System;
using BepInEx.Configuration;
using System.Reflection;
using MonoMod.Cil;
using KinematicCharacterController;
using System.Linq;
//using EntityStates;



namespace Paddywan
{
    [BepInDependency("com.bepis.r2api")]

    [BepInPlugin("com.Paddywan.BossDropRemoval", "BossDropRemoval", "1.0.0")]

    public class BossDropRemoval : BaseUnityPlugin
    {
        public void Awake()
        {
            On.RoR2.BossGroup.OnCharacterDeathCallback += (orig, self, damageReport) =>
            {
                self.bossDropChance = 0.0f;
                orig(self, damageReport);
            };
        }
    }
}
