﻿using System.IO;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using ItemManager;
using ServerSync;
using UnityEngine;

namespace GreylingBomb
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class GreylingBomb : BaseUnityPlugin
    {
        private const string ModName = "GreylingBomb";
        private const string ModVersion = "0.0.2";
        private const string ModGUID = "org.bepinex.plugins.greylingbomb";

        public void Awake()

        {
            Item GreylingBomb = new Item("greylingbomb", "GreylingBomb", "BoomLing");
            GreylingBomb.Crafting.Add(CraftingTable.Forge, 3);
            GreylingBomb.RequiredItems.Add("Iron", 100);
            GreylingBomb.RequiredItems.Add("BlackMetal", 100);
            GreylingBomb.RequiredItems.Add("Obsidian", 400);
            GreylingBomb.RequiredUpgradeItems.Add("Iron", 50);
            GreylingBomb.RequiredUpgradeItems.Add("BlackMetal", 50);
            GreylingBomb.CraftAmount = 1;

            GameObject sfx_greyling_explode = ItemManager.PrefabManager.RegisterPrefab("greylingbomb", "sfx_greyling_explode");



        }
    }
}