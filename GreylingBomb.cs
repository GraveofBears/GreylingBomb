using BepInEx;
using ItemManager;
using UnityEngine;

namespace GreylingBomb
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class GreylingBomb : BaseUnityPlugin
    {
        private const string ModName = "GreylingBomb";
        private const string ModVersion = "0.0.3";
        private const string ModGUID = "org.bepinex.plugins.greylingbomb";

        public void Awake()

        {
            Item GreylingBomb = new Item("greylingbomb", "GreylingBomb", "BoomLing");  //assetbundle name, Asset Name, Folder Contiaining AssetBundle
            GreylingBomb.Crafting.Add(CraftingTable.Forge, 3);
            GreylingBomb.RequiredItems.Add("Iron", 100);
            GreylingBomb.RequiredItems.Add("BlackMetal", 100);
            GreylingBomb.RequiredItems.Add("Obsidian", 400);
            GreylingBomb.RequiredUpgradeItems.Add("Iron", 50);
            GreylingBomb.RequiredUpgradeItems.Add("BlackMetal", 50);
            GreylingBomb.CraftAmount = 1;

            GameObject sfx_greyling_explode = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "sfx_greyling_explode"); //custom SFX attached to prefab
            GameObject Greyling_Projectile = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "Greyling_Projectile"); //projected prefab
            GameObject vfx_greyling_explode = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "vfx_greyling_explode"); //custom VFX attached to projected prefab
            GameObject sfx_greyling_equip = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "sfx_greyling_equip"); //custom SFX attached to SE_Stat script
            GameObject sfx_greyling_throw = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "sfx_greyling_throw"); //custom SFX attached to main prefab

        }
    }
}