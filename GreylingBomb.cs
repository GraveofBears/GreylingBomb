﻿using BepInEx;
using ItemManager;
using UnityEngine;

namespace GreylingBomb
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class GreylingBomb : BaseUnityPlugin
    {
        private const string ModName = "GreylingBomb";
        private const string ModVersion = "0.0.7";
        private const string ModGUID = "org.bepinex.plugins.greylingbomb";

        public void Awake()

        {
            Item GreylingBomb = new Item("greylingbomb", "GreylingBomb", "BoomLing");  //assetbundle name, Asset Name, Folder Contiaining AssetBundle
            GreylingBomb.Crafting.Add(CraftingTable.Forge, 3);
            GreylingBomb.RequiredItems.Add("DragonTear", 3);
            GreylingBomb.RequiredItems.Add("Flametal ", 5);
            GreylingBomb.RequiredItems.Add("GoblinTotem", 2);
            GreylingBomb.RequiredUpgradeItems.Add("Flametal", 5);
            GreylingBomb.RequiredUpgradeItems.Add("DragonTear", 3);
            GreylingBomb.RequiredUpgradeItems.Add("GoblinTotem", 2);
            GreylingBomb.CraftAmount = 1;

            GameObject Greyling_Projectile = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "Greyling_Projectile"); //custom SFX attached to projected prefab
            GameObject vfx_greyling_explode = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "vfx_greyling_explode"); //custom VFX attached to projected prefab

            Item TrollBomb = new Item("greylingbomb", "TrollBomb", "BoomLing");  //assetbundle name, Asset Name, Folder Contiaining AssetBundle
            TrollBomb.Crafting.Add(CraftingTable.Forge, 3);
            TrollBomb.RequiredItems.Add("DragonTear", 3);
            TrollBomb.RequiredItems.Add("Flametal ", 5);
            TrollBomb.RequiredItems.Add("GoblinTotem", 2);
            TrollBomb.RequiredUpgradeItems.Add("Flametal", 5);
            TrollBomb.RequiredUpgradeItems.Add("DragonTear", 3);
            TrollBomb.RequiredUpgradeItems.Add("GoblinTotem", 2);
            TrollBomb.CraftAmount = 1;

            GameObject Troll_Projectile = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "Troll_Projectile"); //custom SFX attached to projected prefab
            GameObject vfx_troll_explode = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "vfx_troll_explode"); //custom VFX attached to projected prefab
        }
    }
}