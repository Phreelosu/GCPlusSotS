﻿using System;
using R2API;
using RoR2;
using UnityEngine;

namespace GoldenCoastPlusRevived.Items
{
	internal class BigSword : ItemBase
	{
		internal override string name
		{
			get
			{
				return "Titanic Greatsword";
			}
		}

		internal override string pickup
		{
			get
			{
				return "Chance on hit to summon the sword of a long-imprisoned guardian.";
			}
		}

		internal override string description
		{
			get
			{
				return "<style=cIsDamage>5%</style> chance on hit to summon <style=cIsDamage>Aurelionite's sword</style> to strike an enemy from underneath for <style=cIsDamage>1250%</style> <style=cStack>(+1250% per stack)</style> TOTAL damage.";
			}
		}

		internal override string lore
		{
			get
			{
				return "The sword. The mark of a champion, fighting to protect. Perhaps, some day, the only thing between it and annihilation. A tool to defend.\n\nBut, also, the tool of a conqueror. One that is designed with the sole purpose to draw blood. Nothing more. In which way it is used is up to the wielder.";
			}
		}

		internal override string token
		{
			get
			{
				return "BigSword";
			}
		}

		internal override GameObject modelPrefab
		{
			get
			{
				return GCPAssets.BigSwordPrefab;
			}
		}

		internal override Sprite iconSprite
		{
			get
			{
				return GCPAssets.BigSwordIcon;
			}
		}

        internal override ItemTier Tier
        {
            get
            {
				return ItemTier.Boss;
            }
        }

		internal override ItemTag[] ItemTags
        {
            get
            {
				return new ItemTag[] { ItemTag.BrotherBlacklist, ItemTag.CannotDuplicate, ItemTag.WorldUnique };
            }
        }


		internal override bool hidden
		{
			get
			{
				return false;
			}
		}

		internal override ItemDisplayRuleDict AddItemDisplays()
		{
			ItemDisplayRule[] array = new ItemDisplayRule[1];
			int num = 0;
			ItemDisplayRule itemDisplayRule = default(ItemDisplayRule);
			itemDisplayRule.ruleType = 0;
			itemDisplayRule.followerPrefab = GCPAssets.BigSwordPrefab;
			itemDisplayRule.childName = "Chest";
			itemDisplayRule.localPos = new Vector3(-0.0329f, 0.2482f, -0.1994f);
			itemDisplayRule.localAngles = new Vector3(351.7756f, 182.8893f, 176.6553f);
			itemDisplayRule.localScale = new Vector3(0.075f, 0.075f, 0.075f);
			array[num] = itemDisplayRule;
			ItemDisplayRuleDict itemDisplayRuleDict = new ItemDisplayRuleDict(array);
			ItemDisplayRuleDict itemDisplayRuleDict2 = itemDisplayRuleDict;
			string bodyPrefabName = "mdlHuntress";
			ItemDisplayRule[] array2 = new ItemDisplayRule[1];
			int num2 = 0;
			itemDisplayRule = default(ItemDisplayRule);
			itemDisplayRule.ruleType = 0;
			itemDisplayRule.followerPrefab = GCPAssets.BigSwordPrefab;
			itemDisplayRule.childName = "Chest";
			itemDisplayRule.localPos = new Vector3(0.0638f, 0.0313f, -0.1337f);
			itemDisplayRule.localAngles = new Vector3(10.1805f, 136.4797f, 157.9499f);
			itemDisplayRule.localScale = new Vector3(0.075f, 0.075f, 0.075f);
			array2[num2] = itemDisplayRule;
			itemDisplayRuleDict2.Add(bodyPrefabName, array2);
			ItemDisplayRuleDict itemDisplayRuleDict3 = itemDisplayRuleDict;
			string bodyPrefabName2 = "mdlToolbot";
			ItemDisplayRule[] array3 = new ItemDisplayRule[1];
			int num3 = 0;
			itemDisplayRule = default(ItemDisplayRule);
			itemDisplayRule.ruleType = 0;
			itemDisplayRule.followerPrefab = GCPAssets.BigSwordPrefab;
			itemDisplayRule.childName = "HandR";
			itemDisplayRule.localPos = new Vector3(0.4984f, -0.1438f, 6.4378f);
			itemDisplayRule.localAngles = new Vector3(7.4983f, 274.1188f, 226.3156f);
			itemDisplayRule.localScale = new Vector3(1.125f, 1.125f, 1.125f);
			array3[num3] = itemDisplayRule;
			itemDisplayRuleDict3.Add(bodyPrefabName2, array3);
			ItemDisplayRuleDict itemDisplayRuleDict4 = itemDisplayRuleDict;
			string bodyPrefabName3 = "mdlEngi";
			ItemDisplayRule[] array4 = new ItemDisplayRule[1];
			int num4 = 0;
			itemDisplayRule = default(ItemDisplayRule);
			itemDisplayRule.ruleType = 0;
			itemDisplayRule.followerPrefab = GCPAssets.BigSwordPrefab;
			itemDisplayRule.childName = "Chest";
			itemDisplayRule.localPos = new Vector3(0.079f, 0.2449f, -0.3275f);
			itemDisplayRule.localAngles = new Vector3(341.1019f, 177.318f, 142.7579f);
			itemDisplayRule.localScale = new Vector3(0.1125f, 0.1125f, 0.1125f);
			array4[num4] = itemDisplayRule;
			itemDisplayRuleDict4.Add(bodyPrefabName3, array4);
			ItemDisplayRuleDict itemDisplayRuleDict5 = itemDisplayRuleDict;
			string bodyPrefabName4 = "mdlEngiTurret";
			ItemDisplayRule[] array5 = new ItemDisplayRule[1];
			int num5 = 0;
			itemDisplayRule = default(ItemDisplayRule);
			itemDisplayRule.ruleType = 0;
			itemDisplayRule.followerPrefab = GCPAssets.BigSwordPrefab;
			itemDisplayRule.childName = "Head";
			itemDisplayRule.localPos = new Vector3(0.035f, 0.7881f, 1.4463f);
			itemDisplayRule.localAngles = new Vector3(90f, 34.5601f, 0f);
			itemDisplayRule.localScale = new Vector3(0.2022f, 0.2022f, 0.2022f);
			array5[num5] = itemDisplayRule;
			itemDisplayRuleDict5.Add(bodyPrefabName4, array5);
			ItemDisplayRuleDict itemDisplayRuleDict6 = itemDisplayRuleDict;
			string bodyPrefabName5 = "mdlMage";
			ItemDisplayRule[] array6 = new ItemDisplayRule[1];
			int num6 = 0;
			itemDisplayRule = default(ItemDisplayRule);
			itemDisplayRule.ruleType = 0;
			itemDisplayRule.followerPrefab = GCPAssets.BigSwordPrefab;
			itemDisplayRule.childName = "Chest";
			itemDisplayRule.localPos = new Vector3(-0.0209f, -0.0058f, -0.358f);
			itemDisplayRule.localAngles = new Vector3(353.1851f, 177.0113f, 165.1478f);
			itemDisplayRule.localScale = new Vector3(0.0938f, 0.0938f, 0.0938f);
			array6[num6] = itemDisplayRule;
			itemDisplayRuleDict6.Add(bodyPrefabName5, array6);
			ItemDisplayRuleDict itemDisplayRuleDict7 = itemDisplayRuleDict;
			string bodyPrefabName6 = "mdlMerc";
			ItemDisplayRule[] array7 = new ItemDisplayRule[1];
			int num7 = 0;
			itemDisplayRule = default(ItemDisplayRule);
			itemDisplayRule.ruleType = 0;
			itemDisplayRule.followerPrefab = GCPAssets.BigSwordPrefab;
			itemDisplayRule.childName = "HandR";
			itemDisplayRule.localPos = new Vector3(-0.5364f, 0.2649f, -0.1585f);
			itemDisplayRule.localAngles = new Vector3(2.8962f, 342.4381f, 46.5564f);
			itemDisplayRule.localScale = new Vector3(0.0966f, 0.0966f, 0.1345f);
			array7[num7] = itemDisplayRule;
			itemDisplayRuleDict7.Add(bodyPrefabName6, array7);
			ItemDisplayRuleDict itemDisplayRuleDict8 = itemDisplayRuleDict;
			string bodyPrefabName7 = "mdlTreebot";
			ItemDisplayRule[] array8 = new ItemDisplayRule[1];
			int num8 = 0;
			itemDisplayRule = default(ItemDisplayRule);
			itemDisplayRule.ruleType = 0;
			itemDisplayRule.followerPrefab = GCPAssets.BigSwordPrefab;
			itemDisplayRule.childName = "FootFrontR";
			itemDisplayRule.localPos = new Vector3(0.0274f, -0.5904f, 0.0166f);
			itemDisplayRule.localAngles = new Vector3(1.1992f, 143.2164f, 139.9014f);
			itemDisplayRule.localScale = new Vector3(0.095f, 0.095f, 0.095f);
			array8[num8] = itemDisplayRule;
			itemDisplayRuleDict8.Add(bodyPrefabName7, array8);
			ItemDisplayRuleDict itemDisplayRuleDict9 = itemDisplayRuleDict;
			string bodyPrefabName8 = "mdlLoader";
			ItemDisplayRule[] array9 = new ItemDisplayRule[1];
			int num9 = 0;
			itemDisplayRule = default(ItemDisplayRule);
			itemDisplayRule.ruleType = 0;
			itemDisplayRule.followerPrefab = GCPAssets.BigSwordPrefab;
			itemDisplayRule.childName = "Chest";
			itemDisplayRule.localPos = new Vector3(0.0869f, 0.0385f, -0.3257f);
			itemDisplayRule.localAngles = new Vector3(358.9687f, 156.1434f, 135.99f);
			itemDisplayRule.localScale = new Vector3(0.1125f, 0.1125f, 0.1125f);
			array9[num9] = itemDisplayRule;
			itemDisplayRuleDict9.Add(bodyPrefabName8, array9);
			ItemDisplayRuleDict itemDisplayRuleDict10 = itemDisplayRuleDict;
			string bodyPrefabName9 = "mdlCroco";
			ItemDisplayRule[] array10 = new ItemDisplayRule[1];
			int num10 = 0;
			itemDisplayRule = default(ItemDisplayRule);
			itemDisplayRule.ruleType = 0;
			itemDisplayRule.followerPrefab = GCPAssets.BigSwordPrefab;
			itemDisplayRule.childName = "Head";
			itemDisplayRule.localPos = new Vector3(-5.2534f, 3.3026f, -0.8387f);
			itemDisplayRule.localAngles = new Vector3(356.6106f, 355.6419f, 44.4464f);
			itemDisplayRule.localScale = new Vector3(0.75f, 0.75f, 0.75f);
			array10[num10] = itemDisplayRule;
			itemDisplayRuleDict10.Add(bodyPrefabName9, array10);
			ItemDisplayRuleDict itemDisplayRuleDict11 = itemDisplayRuleDict;
			string bodyPrefabName10 = "mdlCaptain";
			ItemDisplayRule[] array11 = new ItemDisplayRule[1];
			int num11 = 0;
			itemDisplayRule = default(ItemDisplayRule);
			itemDisplayRule.ruleType = 0;
			itemDisplayRule.followerPrefab = GCPAssets.BigSwordPrefab;
			itemDisplayRule.childName = "HandR";
			itemDisplayRule.localPos = new Vector3(0.1117f, 0.0118f, -0.6402f);
			itemDisplayRule.localAngles = new Vector3(353.923f, 81.0515f, 224.7833f);
			itemDisplayRule.localScale = new Vector3(0.1169f, 0.1169f, 0.1169f);
			array11[num11] = itemDisplayRule;
			itemDisplayRuleDict11.Add(bodyPrefabName10, array11);
			ItemDisplayRuleDict itemDisplayRuleDict12 = itemDisplayRuleDict;
			string bodyPrefabName11 = "mdlBandit2";
			ItemDisplayRule[] array12 = new ItemDisplayRule[1];
			int num12 = 0;
			itemDisplayRule = default(ItemDisplayRule);
			itemDisplayRule.ruleType = 0;
			itemDisplayRule.followerPrefab = GCPAssets.BigSwordPrefab;
			itemDisplayRule.childName = "MuzzleShotgun";
			itemDisplayRule.localPos = new Vector3(-0.0305f, -0.0199f, 0.2406f);
			itemDisplayRule.localAngles = new Vector3(8.2793f, 270.418f, 229.606f);
			itemDisplayRule.localScale = new Vector3(0.0397f, 0.0397f, 0.0397f);
			array12[num12] = itemDisplayRule;
			itemDisplayRuleDict12.Add(bodyPrefabName11, array12);
			return itemDisplayRuleDict;
		}
	}
}
