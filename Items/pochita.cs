using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using trmod.Projectils;

namespace trmod.Items
{
	public class pochita : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.trmod.hjson file.

		public override void SetDefaults()
		{
			Item.useStyle = 5;   //使用方式
			Item.useAnimation = 24;
			Item.useTime = 13;	//攻擊間隔
			Item.shootSpeed = 40f;	//投射物速度	https://terraria.fandom.com/wiki/Velocity
			Item.knockBack = 2.75f;
			Item.width = 20;	//碰撞箱
			Item.height = 12;
			Item.damage = 23;
			Item.axe = 14;	//數值乘5倍?
			Item.UseSound = SoundID.Item23;
			Item.shoot = ModContent.ProjectileType<usepochita>();	//物品的投射物
			Item.rare = 4;	//稀有度
			Item.value = 54000;	//價值
			Item.noMelee = true;	//物品無碰撞傷害
			Item.noUseGraphic = true;	//物品不顯示圖片
			//Item.melee = true;
			Item.channel = true;	//按著右鍵有特殊效果
		}
        public override bool AltFunctionUse(Player player)
        {
			return true;
        }
        
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
		/*
		public override void UpdateAccessory(Item item, Player player, bool hideVisual)
		{
			player.thrownDamage += 0.15f;

		}
		*/
	}
}
