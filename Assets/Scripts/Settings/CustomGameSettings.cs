namespace Settings
{
    public static class CustomGameSettings
    {
        public enum GameItemTypes { Loot, Quest }
        public enum Profession { Alchemy, Blacksmithing, Enchanting, Tailoring }
        public enum ItemType { Material, Craftable, Reagent, Recipe, Quest }
        public enum ItemQuality { Junk, Common, Uncommon, Rare, Null }
    
        public const string QUEST_ASSETS_PATH = "Assets/Resources";
        public const string LOOT_ASSETS_PATH = "Assets/Resources";
        public const string STATIC_ASSETS_PATH = "Assets/StaticAssets";
        public const string TOOL_ICONS_PATH = STATIC_ASSETS_PATH + "/ToolIcons";
        public const string LOOT_CREATOR_ICON_PATH = TOOL_ICONS_PATH + "/loot.png";
        public const string QUEST_CREATOR_ICON_PATH = TOOL_ICONS_PATH + "/quest.png";
    
    }
}