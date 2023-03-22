using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UsefulMethod;
using static GameController;
using static Main;
using System;
using System.Text;
using static Localized;


public class Localized_French : LOCALIZATION
{
    public override string Basic(BasicWord basicWord)
    {
        switch (basicWord)
        {
            case BasicWord.Gain:
                return "Gain";
            case BasicWord.Area:
                return "Zone";
            case BasicWord.Wave:
                return "Vague";
            case BasicWord.Proficiency:
                return "Maîtrise";
            case BasicWord.Areacleared:
                return "Zone Complétée !";
            case BasicWord.Areafailed:
                return "Zone Échouée...";
            case BasicWord.CompltedTime:
                return "Temps";
            case BasicWord.TotalGoldGained:
                return "Or Total Gagné";
            case BasicWord.TotalExpGained:
                return "EXP Total Gagné";
            case BasicWord.TotalMaterialsGained:
                return "Matériaux Totaux Gagnés";
            case BasicWord.Mission:
                return "Mission";
            case BasicWord.AreaMastery:
                return "Maîtrise de Zone";
            case BasicWord.MasteryBonus:
                return "Bonus de Maîtrise";
            case BasicWord.CompletedNum:
                return "Completé #";
            case BasicWord.Current:
                return "Courant";
            case BasicWord.Next:
                return "Prochain";
            case BasicWord.LevelUp:
                return "Niveau +";
            case BasicWord.RankUp:
                return "Rang +";
            case BasicWord.Sec:
                return "sec";
            case BasicWord.Effect:
                return "Effet";
            case BasicWord.PassiveEffect:
                return "Effet Passif";
            case BasicWord.MaterialsToLevelUp:
                return "Matériaux pour Niveau +";
            case BasicWord.MaterialsToRankUp:
                return "Matériaux pour Rang +";
            case BasicWord.Levelup:
                return "Niveau +";
            case BasicWord.Rankup:
                return "Rang +";
            case BasicWord.Bonus:
                return "Bonus";
            case BasicWord.WorldMap:
                return "Carte Monde";
            case BasicWord.Gold:
                return "Or";
            case BasicWord.Trigger: //TODO
                return "trigger";
            case BasicWord.Gained:
                return "Gagné";
            case BasicWord.FullInventory:
                return "Inventaire Plein !";
            case BasicWord.RequiredAbility:
                return "Abilité Requise";
            case BasicWord.HeroLevel:
                return "Niveau du Héros";
            case BasicWord.Information:
                return "Information";
            case BasicWord.Rarity:
                return "Rareté";
            case BasicWord.Part:
                return "Type";
            case BasicWord.SuccessChance:
                return "Chance de Succès";
            case BasicWord.AdditionalEffect:
                return "Effet d'Enchantement";
            case BasicWord.RequiredAbilityIncrement:
                return "Required Ability Increment";
            case BasicWord.GuildLevel:
                return "Niveau de Guilde";
            case BasicWord.Cost:
                return "Coût";
            case BasicWord.Accept:
                return "Accepter";
            case BasicWord.Cancel:
                return "Annuler";
            case BasicWord.Claim:
                return "Réclamer";
            case BasicWord.GoldCap:
                return "Limite d'Or";
            case BasicWord.Client:
                return "Client";
            case BasicWord.Description:
                return "Description";
            case BasicWord.ClearCondition:
                return "Condition de Complétion";
            case BasicWord.Reward:
                return "Récompense";
            case BasicWord.UnlockCondition:
                return "Condition de Déblocage";
            case BasicWord.EpicCoin:
                return "Pièce Épique"; //TODO
            case BasicWord.Additive:
                return "Additif";
            case BasicWord.Multiplicative:
                return "Multiplicatif";
            case BasicWord.Total:
                return "Total";
            case BasicWord.ProductionCost:
                return "Coût pour Produire";
            case BasicWord.LevelupCost:
                return "Coût pour Niveau +";
            case BasicWord.Regen:
                return "Régénérer";
            case BasicWord.Dungeon:
                return "Donjon";
            case BasicWord.PortalOrb:
                return "Orbe Portail";
            case BasicWord.Nitro:
                return "Nitro";
            case BasicWord.Title:
                return "Titre";
            case BasicWord.Researching:
                return "Recherche en Cours";
            case BasicWord.Rank:
                return "Rang";
            case BasicWord.LevelEffect:
                return "Effet de Niveau";
            case BasicWord.ResearchableEffect:
                return "Effet Recherchable";
            case BasicWord.RankMilestone:
                return "Palier de Rang";
            case BasicWord.LevelMilestone:
                return "Palier de Niveau";
            case BasicWord.MaxRank:
                return "Rang Max";
            case BasicWord.RequiredConditionToRankUp:
                return "Condition Requise pour Rang +";
            case BasicWord.CostToRankUp:
                return "Coût pour Rang +";
            case BasicWord.MaxLevel:
                return "Niveau Max";
            case BasicWord.IncreaseRankToExpandTheLevelCap:
                return "Augmente le Rang pour augmenter la limite de niveau";
            case BasicWord.Research:
                return "Recherche";
            case BasicWord.Progress:
                return "Progrès";
            case BasicWord.EXP:
                return "EXP";
            case BasicWord.ResearchPower:
                return "Puissance de Recherche";
            case BasicWord.TownBuilding:
                return "Bâtiments";
            case BasicWord.TownMaterialInventory:
                return "Inventaire de Matériaux de Ville";
            case BasicWord.PurchasedNum:
                return "Acheté #";
            case BasicWord.General:
                return "Général";
            case BasicWord.SlimeBank:
                return "<size=16>Banque Slime</size>";
            case BasicWord.AvailableQueue:
                return "File Disponible";
            case BasicWord.GeneralUpgrade:
                return "Amélioration Générale";
            case BasicWord.SlimeBankUpgrade:
                return "<size=16>Amélioration de Banque Slime</size>";
            case BasicWord.Active:
                return "Actif";
            case BasicWord.Passive:
                return "Passif";
            case BasicWord.Inactive:
                return "Inactif";
            case BasicWord.Playing:
                return "En Jeu";
            case BasicWord.Play:
                return "Jouer";
            case BasicWord.Challenge:
                return "Défi";
            case BasicWord.GuildAbility:
                return "Abilité de Guilde";
            case BasicWord.Tier1WorldAscension:
                return "Ascension Monde Classe 1";
            case BasicWord.Tier2WorldAscension:
                return "Ascension Monde Classe 2";
            case BasicWord.Tier3WorldAscension:
                return "Ascension Monde Classe 3";
            case BasicWord.WorldAscension:
                return "Ascension Monde";
            case BasicWord.Points:
                return "Points";
            case BasicWord.RequiredSkill:
                return "Capacité Requise";
            case BasicWord.Select:
                return "Sélectionner";
            case BasicWord.Summon:
                return "Invocation";
            case BasicWord.PetRank:
                return "Rang de Familier";
            case BasicWord.On:
                return "Activé";
            case BasicWord.Off:
                return "Desactivé";
            case BasicWord.Level:
                return "Niveau";
            case BasicWord.LoyaltyPoint:
                return "Point de Loyauté";
            case BasicWord.Left:
                return "Restant";
            case BasicWord.Completed:
                return "Complété";
            case BasicWord.Speed:
                return "Vitesse";
            case BasicWord.Ability:
                return "Abilité";
            case BasicWord.Auto:
                return "Auto";
            case BasicWord.Main:
                return "Principal";
            case BasicWord.Elements:
                return "Éléments";
            case BasicWord.Regions:
                return "Régions";
            case BasicWord.Gains:
                return "Gains";
            case BasicWord.MainStats:
                return "Stats Principales";
            case BasicWord.ElementStats:
                return "Stats Élémentaires";
            case BasicWord.RegionStats:
                return "Stats de Région";
            case BasicWord.GainStats:
                return "Stats de Gains";
            case BasicWord.Kill:
                return "Ennemi";
            case BasicWord.Raid:
                return "Raid";
            case BasicWord.Solo:
                return "Solo";
            case BasicWord.Handicap:
                return "Handicap";
            case BasicWord.Meters:
                return "mètres";
            case BasicWord.Talisman:
                return "Talisman";
            case BasicWord.Global:
                return "Global";
            case BasicWord.Daily:
                return "Journalier";
            case BasicWord.GlobalQuest:
                return "Quête Globale";
            case BasicWord.DailyQuest:
                return "Quête Journalière";
            case BasicWord.TitleQuest:
                return "Quête de Titre";
            case BasicWord.GeneralQuest:
                return "Quête Générale";
            case BasicWord.Clear:
                return "Complété";
            case BasicWord.HC:
                return "HC";
            case BasicWord.Utility:
                return "Utilité";
            case BasicWord.Enchant:
                return "Enchanter";
            case BasicWord.TriggeredNum:
                return "Utilisé #";
            case BasicWord.RestoreHP:
                return "Restorer des PV";
            case BasicWord.NotEnoughMP:
                return "Pas assez de PM";
            case BasicWord.ChanneledMP:
                return "PM Réservés";
            case BasicWord.ChanneledMPDescription:
                return "Les PM réservés réduit les PM Max si équipé au lieu d'utiliser des PM à leur utilisation";
            case BasicWord.MysteriousWater:
                return "Eau Mystérieuse";
            case BasicWord.Pointsleft:
                return "Points restants";
            case BasicWord.Available:
                return "Disponible";
            case BasicWord.Alchemy:
                return "Alchimie";
            case BasicWord.Craft:
                return "Fabrication";
            case BasicWord.CurrentCap:
                return "Limite Courante";
            case BasicWord.MaxCap:
                return "Limite Maximale";
            case BasicWord.Type:
                return "Type";
            case BasicWord.ProducedNum:
                return "Produit #";
            case BasicWord.MixPotions:
                return "Mixer des Potions";
            case BasicWord.Upgrades:
                return "Améliorations";
            case BasicWord.Material:
                return "Matériau";
            case BasicWord.Essence:
                return "Essence";
            case BasicWord.ExpandCap:
                return "Limite +";
            case BasicWord.MaterialInventory:
                return "Inventaire de Matériaux";
            case BasicWord.EssenceInventory:
                return "Inventaire d'Essences";
            case BasicWord.CATALYSTS:
                return "CATALYSEURS";
            case BasicWord.Favorite:
                return "Favori";
            case BasicWord.Ascend: //TOD
                return "Ascend";
            case BasicWord.QuestCancelText:
                return "Êtes-vous sûr de vouloir annuler cette quête ?";
            case BasicWord.AreaMissionMilestone:
                return "Palier de Mission de Zone";
            case BasicWord.TalismanFragments:
                return "Fragments de Talisman";
            case BasicWord.Equipment:
                return "Equipement";
            case BasicWord.Weapon:
                return "Arme";
            case BasicWord.Armor:
                return "Armure";
            case BasicWord.Jewelry:
                return "Bijou";
            case BasicWord.Inventory:
                return "Inventaire";
            case BasicWord.EquipmentInventory:
                return "Équipements";
            case BasicWord.EnchantInventory:
                return "Enchantements";
            case BasicWord.UtilityInventory:
                return "Utilitaires";
            case BasicWord.Default:
                return "Défaut";
            case BasicWord.Dictionary:
                return "Dictionaire";
            case BasicWord.Disassemble:
                return "Désassembler";
            case BasicWord.EquipmentDictionary:
                return "Dictionaire d'Équipement";
            case BasicWord.DictionaryUpgrade:
                return "Amélioration du Dictionary";
            case BasicWord.Reset:
                return "Réinitialiser";
            case BasicWord.Close:
                return "Fermer";
            case BasicWord.TalismanUpgrades:
                return "Améliorations de Talisman";
            case BasicWord.Scroll:
                return "Parchemin";
            case BasicWord.EnchantScroll: //TODO
                return "Enchant Scroll";
            case BasicWord.Trap:
                return "Piège";
            case BasicWord.Blessing:
                return "Bénédiction";
            case BasicWord.TownMat:
                return "Mat de Ville";
            case BasicWord.RebirthUpgrades:
                return "Améliorations de Réincarnation";
            case BasicWord.AutoRebirth:
                return "Réincarnation Auto";
            case BasicWord.Customize:
                return "Personnaliser";
            case BasicWord.Start:
                return "Commencer";
            case BasicWord.Quit:
                return "Quitter";
            case BasicWord.Distant:
                return "Lointain";
            case BasicWord.DISTANT_EXPEDITION:
                return "EXPÉDITION LOINTAINE";
            case BasicWord.Stats:
                return "Stats";
            case BasicWord.WORLD_ASCENSION:
                return "ASCENSION DU MONDE";
            case BasicWord.MILESTONES:
                return "PALIERS";
            case BasicWord.ACCOMPLISHMENTS:
                return "ACCOMPLISSEMENTS";
            case BasicWord.OPTIONS:
                return "OPTIONS";
            case BasicWord.Options:
                return "Options";
            case BasicWord.BackgroundMode:
                return "Mode Arrière-Plan";
            case BasicWord.RealPlaytime:
                return "Temps de Jeu Réel";
            case BasicWord.InGamePlaytime:
                return "Temps de Jeu";
            case BasicWord.Clock:
                return "Horloge";
            case BasicWord.Version:
                return "Version";
            case BasicWord.HardReset:
                return "<size=16>Réinitialisation Complète</size>";
            case BasicWord.ExportFile:
                return "<size=16>Exporter un Fichier</size>";
            case BasicWord.ImportFile:
                return "<size=16>Importer un Fichier</size>";
            case BasicWord.CloudSave:
                return "<size=16>Sauvegarde Cloud</size>";
            case BasicWord.CloudLoad:
                return "<size=16>Chargement Cloud</size>";
            case BasicWord.Hapiwaku:
                return "Hapiwaku";
            case BasicWord.Discord:
                return "Discord";
            case BasicWord.EPIC_STORE:
                return "EPIC STORE";
            case BasicWord.QoL:
                return "Comfort";
            case BasicWord.Special:
                return "Spécial";
            case BasicWord.Ambition:
                return "Ambition";
            case BasicWord.DailyChest:
                return "<size=16>Coffre Journalier</size>";
            case BasicWord.PetQoL:
                return "Capacité de Familier";
            case BasicWord.NextRestockTimeLeft:
                return "Temps Avant le Prochain Réapprovisionnement";
            case BasicWord.Buy:
                return "Acheter";
            case BasicWord.Sell:
                return "Vendre";
            case BasicWord.Stock:
                return "Stock";
            case BasicWord.YouHave:
                return "Vous avez";
            case BasicWord.EmptyUtilitySlotMessage:
                return "Vous devez avoir un Emplacement d'Utilitaire vide pour acheter";
            case BasicWord.Convert:
                return "Convertir";
            case BasicWord.PetExp:
                return "Familier EXP";
            case BasicWord.GuildLevelUp:
                return "Niveau de Guilde +";
            case BasicWord.GuildExp:
                return "EXP de Guilde";
            case BasicWord.HP:
                return "PV";
            case BasicWord.MP:
                return "PM";
            case BasicWord.AutoMove:
                return "Mouvement Auto";
            case BasicWord.ManualMove:
                return "Mouvement Manuel";
            case BasicWord.ManualMoveText:
                return "WASD ou les flèches pour bouger manuellement";
            case BasicWord.CombatRange:
                return "Portée de Combat";
            case BasicWord.TotalDPS:
                return "DPS Total";
            case BasicWord.DurationLeft:
                return "Durée Restante";
            case BasicWord.NoDisassemble:
                return "Ne peut pas être désassemblé";
            case BasicWord.EffectBonus:
                return "Effet Bonus";
            case BasicWord.Equipping:
                return "Équipé";
            case BasicWord.Locked:
                return "Verrouillé";
            case BasicWord.EquipmentTenacity:
                return "Tenacité d'Équipement";
            case BasicWord.ForgedEffect:
                return "Effet Forgé";
            case BasicWord.ForgingAvailable:
                return "Forge Disponible";
            case BasicWord.ThisEquipmentLv:
                return "Nv de cet Équipement";
            case BasicWord.Efficiency:
                return "Efficacité";
            case BasicWord.Mastered:
                return "Maîtrisé";
            case BasicWord.ChooseTargetEffect:
                return "Choisir l'effet cible.";
            case BasicWord.Stack:
                return "Stack";
            case BasicWord.Unique:
                return "Unique";
            case BasicWord.Accepted:
                return "Accepté";
            case BasicWord.Questing: //TODO
                return "Questing";
            case BasicWord.Chance:
                return "Chance";
            case BasicWord.Stance:
                return "Posture";
            case BasicWord.SkillTable:
                return "Table de Capacité";
            case BasicWord.Remove:
                return "Enlever";
            case BasicWord.AutoRebirthSettings:
                return "Paramètres d'Auto Réincarnation";
            case BasicWord.RebirthUpgradeInfo:
                return "Cette amélioration affecte tous les héros.";
            case BasicWord.Capture:
                return "Capture";
            case BasicWord.To: //TODO
                return "to";
            case BasicWord.AvailableBlessing:
                return "Disponible";
            case BasicWord.StackNum: //TODO
                return "Stack #";
            case BasicWord.TotalClearNum:
                return "Complétions Totales #";
            case BasicWord.Simulation:
                return "Simulation";
            case BasicWord.Required:
                return "Requis";
            case BasicWord.UniqueEquipment:
                return "Équipment Unique";
            case BasicWord.DropChance:
                return "Chance d'Apparition";
            case BasicWord.MonsterLevel:
                return "Niveau des Monstres";
            case BasicWord.Clearable:
                return "Complétable";
            case BasicWord.Time:
                return "Temps";
            case BasicWord.ImpossibleClear:
                return "Presque impossible à compléter";
            case BasicWord.WaveReached:
                return "Vague Atteinte";
            case BasicWord.Timeout:
                return "Temps Écoulé";
            case BasicWord.Die:
                return "Mort";
            case BasicWord.Member:
                return "Membre";
            case BasicWord.StartAll:
                return "Tout Commencer";
            case BasicWord.ClaimAll:
                return "Tout Réclamer";
            case BasicWord.Duration:
                return "Durée";
            case BasicWord.BONUS_CODE:
                return "CODE BONUS";
            case BasicWord.IEH1PlayerBonus:
                return "Bonus de Joueur d'IEH1";
            case BasicWord.IEH2PlaytestBonus:
                return "Bonus de Béta Testeur IEH2";
            case BasicWord.AreaPrestigeLockText: //TODO
                return "< AREA PRESTIGE >\n" + "<sprite=\"locks\" index=0> Faire une Ascension Monde Classe 1 une fois (ça vaut le coup)";
            case BasicWord.ClickToStart:
                return "Cliquer pour Commencer";
            case BasicWord.BonusCodeDescriptionText:
                return "Débloque des objets bonus en rentrant des codes bonus qui sont distribués à travers des annonces dans les notes de version et sur Discord.";
            case BasicWord.BonusCodeButtonText:
                return "<size=16>Rentrer un Code Bonus</size>";
            case BasicWord.ResourceGain:
                return "Gain de Ressouce";
            case BasicWord.ExpGain:
                return "Gain d'EXP";
            case BasicWord.EquipmentInventorySlot:
                return "Emplacement d'Inventaire d'Équipement";
            case BasicWord.UtilityInventorySlot:
                return "Emplacement d'Inventaire d'Utilitaire";
            case BasicWord.HELP:
                return "AIDE";
            case BasicWord.STATISTICS:
                return "STATISTIQUES";
            case BasicWord.ACHIEVEMENTS:
                return "SUCCÈS";
            case BasicWord.Loadout:
                return "Collection";
            case BasicWord.TotalForAreaCount:
                return "Total";
            case BasicWord.Mutant:
                return "Mutant";
            case BasicWord.LastMinuteEXP:
                return "EXP gagné pendant la dernière minute";
            case BasicWord.AlchemyPoint:
                return "Point d'Alchimie";
            case BasicWord.Tier:
                return "Classe";
            case BasicWord.TimePlayed:
                return "Temps Joué";
            case BasicWord.Best:
                return "Meilleur";
            case BasicWord.AccomplishmentRewards:
                return "Récompenses d'Accomplissement";
            case BasicWord.Location:
                return "Localisation";
            case BasicWord.REGULAR:
                return "NORMALE";
            case BasicWord.LARGE:
                return "GROSSE";
            case BasicWord.EPIC:
                return "ÉPIQUE";
            case BasicWord.AreaInfo:
                return "Info Zone";
            case BasicWord.MaxWave:
                return "Vague Max";
            case BasicWord.PhysCrit:
                return "CritPhys";
            case BasicWord.MagCrit:
                return "CritMag";
            case BasicWord.Nothing:
                return "Rien";
            case BasicWord.FieldDebuff:
                return "Débuff de Terrain";
            case BasicWord.RewardPerClear:
                return "Récompense par Complétion";
            case BasicWord.Score:
                return "Score";
            case BasicWord.Loyalty:
                return "Loyauté";
            case BasicWord.DefeatedNum:
                return "Vaincu #";
            case BasicWord.Formula:
                return "Formule";
            case BasicWord.CapturedNum:
                return "Capturé #";
            case BasicWord.DropMaterial:
                return "Matériau Lâché";
            case BasicWord.Region:
                return "Région";
            case BasicWord.ClearPlaytime: //TODO
                return "Clear Playtime";
            case BasicWord.ThisWorldAscension:
                return "Cette Ascension Monde";
            case BasicWord.First:
                return "Premier";
            case BasicWord.ClassSkill:
                return "Capacité de Classe";
            case BasicWord.GlobalSkill:
                return "Capacité Globale";
            case BasicWord.BestLevel:
                return "Meilleur Nv";
            case BasicWord.CacheSave: //TODO
                return "Cache Save";
            case BasicWord.SetToTheCurrentArea:
                return "Sélectionne la zone courante en tant que Zone Favorite";
            case BasicWord.SucceededInCapturing:
                return "Capture réussie !";
            case BasicWord.TripleCapture:
                return "Capture triple !";
            case BasicWord.SuccessfulPilfer:
                return "Vol Réussi";
            case BasicWord.Pause:
                return "Pause";
            case BasicWord.DoubleCapture:
                return "Capture Double !";
            case BasicWord.Defeat:
                return "Vaincu";
            case BasicWord.SelectAPetToLetItGoToExpeditions:
                return "Sélectionne un familier pour l'envoyer dans une expédition.";
            case BasicWord.OrHigher:
                return "ou supérieur";
            case BasicWord.EnchantFilterDescription:
                return "Quand un équipement avec l'effet d'enchantement coché d'un niveau donné ou supérieur est récupéré, l'exclure de l'Auto Désassemblage. \nSi le [# d'Emplacements d'Enchantement incluant l'effet] est coché et est mis à 2 ou 3, alors il désassemblera tout ce qui ne suit pas son prérequis donné, peu importe les autres enchantements cochés. ";
            case BasicWord.OrMore:
                return "ou plus";
            case BasicWord.EnchantSlotNumber:
                return "# d'Emplacements d'Enchantement incluant l'effet";
            case BasicWord.Attempt: //TODO
                return "Essayer";
            case BasicWord.InputNewMultiplier:
                return "Rentrer la nouvelle valeur du multiplicateur.";
            case BasicWord.PetStats:
                return "Stats du Familier";
            case BasicWord.FieldCurse:
                return "Malédiction du Terrain";
        }
        return basicWord.ToString();
    }

    //Menu
    public override string Menu(MenuKind kind)
    {
        switch (kind)
        {
            case MenuKind.Ability:
                return "Abilité";
            case MenuKind.Skill:
                return "Capacité";
            case MenuKind.Upgrade:
                return "<size=16>Amélioration</size>";
            case MenuKind.Equip:
                return "<size=16>Équipement</size>";
            case MenuKind.Guild:
                return "Guilde";
            case MenuKind.Quest:
                return "Quête";
            case MenuKind.Lab:
                return "Lab";
            case MenuKind.Setting:
                return "Options";
            case MenuKind.Bestiary:
                return "Bestiaire";
            case MenuKind.Rebirth:
                return "<size=16>Réincarnation</size>";
            case MenuKind.Challenge:
                return "Défi";
            case MenuKind.Ascension:
                return "Ascension";
            case MenuKind.Town:
                return "Ville";
            case MenuKind.Shop:
                return "Magasin";
            case MenuKind.Expedition:
                return "Expédition";
        }
        return kind.ToString();
    }
    public override string EpicStoreMenu()
    {
        return "Magasin Épique";
    }
    //StatsBreakdown
    public override string StatsBreakdown(MultiplierKind kind)
    {
        switch (kind)
        {
            case MultiplierKind.Base:
                return "Base";
            case MultiplierKind.Ability:
                return "Abilité";
            case MultiplierKind.Title:
                return "Titre";
            case MultiplierKind.Skill:
                return "Capacité";
            case MultiplierKind.Upgrade:
                return "Amélioration";
            case MultiplierKind.Equipment:
                return "Équipement";
            case MultiplierKind.Dictionary:
                return "Dictionaire";
            case MultiplierKind.Guild:
                return "Guilde";
            case MultiplierKind.AreaPrestige:
                return "Prestige de Zone";
            case MultiplierKind.AreaDebuff:
                return "Débuff de Zone";
            case MultiplierKind.FieldCurse:
                return "Malédiction du Terrain";
            case MultiplierKind.Potion:
                return "Potion";
            case MultiplierKind.Alchemy:
                return "Amélioration d'Alchimie";
            case MultiplierKind.Pet:
                return "Familier";
            case MultiplierKind.Rebirth:
                return "Réincarnation";
            case MultiplierKind.Stance:
                return "Posture";
            case MultiplierKind.AlchemyExpand:
                return "Limite Étendue";
            case MultiplierKind.Blessing:
                return "Bénédiction";
            case MultiplierKind.Town:
                return "Ville";
            case MultiplierKind.TownResearch:
                return "Recherche de Ville";
            case MultiplierKind.MissionMilestone:
                return "Palier de Mission";
            case MultiplierKind.Debuff:
                return "Débuff";
            case MultiplierKind.EpicStore:
                return "Magasin Épique";
            case MultiplierKind.Challenge:
                return "Défi";
            case MultiplierKind.SkillPassive:
                return "Passif de Capacité";
            case MultiplierKind.Talisman:
                return "Talisman";
            case MultiplierKind.TalismanPassive:
                return "Passif de Talisman";
            case MultiplierKind.Buff:
                return "Buff de Capacité";
            case MultiplierKind.ChanneledSkill:
                return "Capacité Réservée";
            case MultiplierKind.Ascension:
                return "Ascension Monde";
            case MultiplierKind.Quest:
                return "Quête";
            case MultiplierKind.Achievement:
                return "Succès";
            case MultiplierKind.DLC:
                return "DLC de Steam";
            case MultiplierKind.Expedition:
                return "Expédition";
        }
        return kind.ToString();
    }
    //Resource
    public override string ResourceName(ResourceKind kind)
    {
        switch (kind)
        {
            case ResourceKind.Stone:
                return "Pierre";
            case ResourceKind.Crystal:
                return "Cristal";
            case ResourceKind.Leaf:
                return "Feuille";
        }
        return kind.ToString();
    }
    //Hero
    public override string Hero(HeroKind kind)
    {
        switch (kind)
        {
            case HeroKind.Warrior:
                return "Guerrier";
            case HeroKind.Wizard:
                return "Mage";
            case HeroKind.Angel:
                return "Ange";
            case HeroKind.Thief:
                return "Voleur";
            case HeroKind.Archer:
                return "Archer";
            case HeroKind.Tamer:
                return "Dompteuse";
        }
        return kind.ToString();
    }
    //Stats
    string tempStrBaseStats;
    public override string BasicStats(BasicStatsKind kind, bool isShort = false)
    {
        switch (kind)
        {
            case BasicStatsKind.HP:
                tempStrBaseStats = optStr + "<sprite=\"stats\" index=0>";
                if (!isShort) tempStrBaseStats += " PV";
                break;
            case BasicStatsKind.MP:
                tempStrBaseStats = optStr + "<sprite=\"stats\" index=1>";
                if (!isShort) tempStrBaseStats += " PM";
                break;
            case BasicStatsKind.ATK:
                tempStrBaseStats = optStr + "<sprite=\"stats\" index=2>";
                if (!isShort) tempStrBaseStats += " ATQ";
                break;
            case BasicStatsKind.MATK:
                tempStrBaseStats = optStr + "<sprite=\"stats\" index=3>";
                if (!isShort) tempStrBaseStats += " MATQ";
                break;
            case BasicStatsKind.DEF:
                tempStrBaseStats = optStr + "<sprite=\"stats\" index=4>";
                if (!isShort) tempStrBaseStats += " DEF";
                break;
            case BasicStatsKind.MDEF:
                tempStrBaseStats = optStr + "<sprite=\"stats\" index=5>";
                if (!isShort) tempStrBaseStats += " MDEF";
                break;
            case BasicStatsKind.SPD:
                tempStrBaseStats = optStr + "<sprite=\"stats\" index=6>";
                if (!isShort) tempStrBaseStats += " CEL";
                break;
        }
        return tempStrBaseStats;
    }
    public override string BasicStatsDescription(BasicStatsKind kind)
    {
        switch (kind)
        {
            case BasicStatsKind.HP:
                return "Augmente les Points de Vie";
            case BasicStatsKind.MP:
                return "Augmente des Points de Mana";
            case BasicStatsKind.ATK:
                return "Augmente les dégâts des Attaques Physiques";
            case BasicStatsKind.MATK:
                return "Augmente les dégâts des Attaques Magiques";
            case BasicStatsKind.DEF:
                return "Augmente la défense contre les Attaques Physiques";
            case BasicStatsKind.MDEF:
                return "Augmente la défense contre les Attaques Magiques";
            case BasicStatsKind.SPD:
                return "Réduit le Temps d'Utilisation des Capacités";
        }
        return kind.ToString();
    }
    string tempStrStats;
    public override string Stat(Stats stats, bool isShort = false)
    {
        switch (stats)
        {
            case Stats.FireRes:
                tempStrStats = optStr + "<sprite=\"stats\" index=7>";
                if (!isShort) tempStrStats += " Résistance au Feu";
                break;
            case Stats.IceRes:
                tempStrStats = optStr + "<sprite=\"stats\" index=8>";
                if (!isShort) tempStrStats += " Résistance à la Glace";
                break;
            case Stats.ThunderRes:
                tempStrStats = optStr + "<sprite=\"stats\" index=9>";
                if (!isShort) tempStrStats += " Résistance à l'Électricité";
                break;
            case Stats.LightRes:
                tempStrStats = optStr + "<sprite=\"stats\" index=10>";
                if (!isShort) tempStrStats += " Résistance à la Lumière";
                break;
            case Stats.DarkRes:
                tempStrStats = optStr + "<sprite=\"stats\" index=11>";
                if (!isShort) tempStrStats += " Résistance aux Ténèbres";
                break;
            case Stats.DebuffRes:
                return "Résistance aux Débuffs";
            case Stats.PhysCritChance:
                return "Critique Physique";
            case Stats.MagCritChance:
                return "Critique Magique";
            case Stats.CriticalDamage:
                return "Dégâts Critique";
            case Stats.ExpGain:
                return "EXP";
            case Stats.SkillProficiencyGain:
                return "Maîtrise de Capacité";
            case Stats.EquipmentProficiencyGain:
                return "Maîtrise d'Équipement";
            case Stats.EquipmentDropChance:
                return "Chance de Drop d'Équipement";
            case Stats.MoveSpeed:
                return "Vitesse";
            case Stats.TamingPointGain:
                return "Gain de Points de Domptage";
        }
        return tempStrStats;
    }
    public override string GlobalStat(GlobalStats stats)
    {
        switch (stats)
        {
            case GlobalStats.GoldGain:
                return "Gain d'Or";
            case GlobalStats.StoneGain:
                return "Gain de Pierre";
            case GlobalStats.CrystalGain:
                return "Gain de Cristal";
            case GlobalStats.LeafGain:
                return "Gain de Feuille";
        }
        return stats.ToString();
    }
    //Ability
    public override string Ability(AbilityKind kind)
    {
        switch (kind)
        {
            case AbilityKind.Vitality:
                return "VTL";
            case AbilityKind.Strength:
                return "FOR";
            case AbilityKind.Intelligence:
                return "INT";
            case AbilityKind.Agility:
                return "AGI";
            case AbilityKind.Luck:
                return "CHA";
        }
        return kind.ToString();
    }
    public override string AbilityDescription(AbilityKind kind)
    {
        switch (kind)
        {
            case AbilityKind.Vitality:
                return "La Vitalité a un effet sur les PV, la DEF et la MDEF.";
            case AbilityKind.Strength:
                return "La Force a un effet sur l'ATQ et la DEF.";
            case AbilityKind.Intelligence:
                return "L'Intelligence a un effet sur les PM, la MATQ et la MDEF.";
            case AbilityKind.Agility:
                return "L'Agilité a un effet sur les PM, la CEL et la Vitesse.";
            case AbilityKind.Luck:
                return "La Chance a un effet sur la Chance de Coup Critique et la Chance d'Apparition.";
        }
        return kind.ToString();
    }
    public override string AbilityWord(AbilityWord kind)
    {
        switch (kind)
        {
            case global::AbilityWord.PointLeft:
                return "Points";
            case global::AbilityWord.PhysicalDamage:
                return "Dégâts Physiques";
            case global::AbilityWord.FireDamage:
                return "Dégâts de Feu";
            case global::AbilityWord.IceDamage:
                return "Dégâts de Glace";
            case global::AbilityWord.ThunderDamage:
                return "Dégâts d'Électricité";
            case global::AbilityWord.LightDamage:
                return "Dégâts de Lumière";
            case global::AbilityWord.DarkDamage:
                return "Dégâts des Ténèbres";
            case global::AbilityWord.PhysicalAbsorption:
                return "Absorption Physique";
            case global::AbilityWord.FireAbsorption:
                return "Absorption du Feu";
            case global::AbilityWord.IceAbsorption:
                return "Absorption du Glace";
            case global::AbilityWord.ThunderAbsorption:
                return "Absorption de l'Électricité";
            case global::AbilityWord.LightAbsorption:
                return "Absorption de la Lumière";
            case global::AbilityWord.DarkAbsorption:
                return "Absorption des Ténèbres";
            case global::AbilityWord.PhysicalNullifyChance:
                return "Nullification Physique";
            case global::AbilityWord.FireNullifyChance:
                return "Nullification de Feu";
            case global::AbilityWord.IceNullifyChance:
                return "Nullification de Glace";
            case global::AbilityWord.ThunderNullifyChance:
                return "Nullification d'Électricité";
            case global::AbilityWord.LightNullifyChance:
                return "Nullification de Lumière";
            case global::AbilityWord.DarkNullifyChance:
                return "Nullification des Ténèbres";
            case global::AbilityWord.DamageToSlime:
                return "Dégâts - Slimes";
            case global::AbilityWord.DamageToMagicslime:
                return "Dégâts - Smiles Magiques";
            case global::AbilityWord.DamageToSpider:
                return "Dégâts - Araignées";
            case global::AbilityWord.DamageToBat:
                return "Dégâts - Chauve-Souris";
            case global::AbilityWord.DamageToFairy:
                return "Dégâts - Fées";
            case global::AbilityWord.DamageToFox:
                return "Dégâts - Renards";
            case global::AbilityWord.DamageToDevilfish:
                return "Dégâts - Poissons Démon";
            case global::AbilityWord.DamageToTreant:
                return "Dégâts - Tréant";
            case global::AbilityWord.DamageToFlametiger:
                return "Dégâts - Tigres de Feu";
            case global::AbilityWord.DamageToUnicorn:
                return "Dégâts - Licornes";
            case global::AbilityWord.TownMaterialGain:
                return "Matériaux de Ville";
            case global::AbilityWord.Tier1RebirthPointGain:
                return "Points de Réinc. Classe 1";
            case global::AbilityWord.Tier2RebirthPointGain:
                return "Points de Réinc. Classe 2";
            case global::AbilityWord.Tier3RebirthPointGain:
                return "Points de Réinc. Classe 3";
            case global::AbilityWord.SummonedPetEXPGain:
                return "EXP du Familier Invoqué";
            case global::AbilityWord.LoyaltyPointGain:
                return "Points de Loyauté";
            case global::AbilityWord.DamageToChallengeBoss:
                return "Dégâts sur les Boss de Défi";
            case global::AbilityWord.GuildEXPGain:
                return "EXP de Guilde";
            case global::AbilityWord.AAPA0:
                return "Ajouteur de Point d'Abilité Auto";
            case global::AbilityWord.AAPA1:
                return "Ajoute les Points d'Abilité dans l'ordre suivant :\nVTL                          FOR                          INT                          \nAGI                          CHA";
            case global::AbilityWord.AAPA2:
                return "Activer les Points d'Abilité Auto \n<color=yellow>( Changer ceci APRÈS avoir changé les réglages ci-dessus)</color>";
            case global::AbilityWord.AAPA3:
                return "Allocation de Points d'Abilité Maximale\n- Les Points d'Abilité n'iront pas au dessus de ces nombres :";
            case global::AbilityWord.AAPA4:
                return "VTL                          FOR                          INT                          \nAGI                          CHA";
            case global::AbilityWord.AAPA5:
                return "<color=yellow>0 veut dire 'Infini'</color>";
            case global::AbilityWord.BlessingEffect:
                return "Effet de Bénédiction";
        }
        return kind.ToString();
    }
    //Title
    public override string Title(TitleKind kind)
    {
        switch (kind)
        {
            case TitleKind.MonsterDistinguisher:
                return "Étude de Monstre";
            case TitleKind.EquipmentSlotWeapon:
                return "Apprenti d'Arme";
            case TitleKind.EquipmentSlotArmor:
                return "Apprenti d'Armure";
            case TitleKind.EquipmentSlotJewelry:
                return "Apprenti de Bijou";
            case TitleKind.PotionSlot:
                return "Apprenti de Potion";
            case TitleKind.EquipmentProficiency:
                return "Maître d'Équipement";
            case TitleKind.SkillMaster:
                return "Maître de Capacité";
            case TitleKind.Survival:
                return "Survivant";
            case TitleKind.FireResistance:
                return "Âme de Feu";
            case TitleKind.IceResistance:
                return "Âme de Glace";
            case TitleKind.ThunderResistance:
                return "Âme d'Électricité";
            case TitleKind.LightResistance:
                return "Âme de Lumière";
            case TitleKind.DarkResistance:
                return "Âme des Ténèbres";
            case TitleKind.DebuffResistance:
                return "Barrière Sainte";
            case TitleKind.MoveSpeed:
                return "Coureur";
            case TitleKind.Alchemist:
                return "Alchimiste";
            case TitleKind.MetalHunter:
                return "Chasseur de Métal";
            case TitleKind.BreakingTheLimit:
                return "Transcendance de Limite";
            case TitleKind.PhysicalDamage:
                return "Maître Physique";
            case TitleKind.FireDamage:
                return "Maître de Feu";
            case TitleKind.IceDamage:
                return "Maître de Glace";
            case TitleKind.ThunderDamage:
                return "Maître d'Électricité";
            case TitleKind.LightDamage:
                return "Maître de Lumière";
            case TitleKind.DarkDamage:
                return "Maître des Ténèbres";
            case TitleKind.Cooperation:
                return "Preuve de Réinc.";
            case TitleKind.Quester:
                return "Quêteur";
        }
        return kind.ToString();
    }
    public override string TitleEffect(TitleKind kind, double effectValue, bool isSub = false)
    {
        //Debug
        string tempString = kind.ToString() + " + " + tDigit(effectValue);
        switch (kind)
        {
            case TitleKind.MonsterDistinguisher:
                if (isSub) tempString = optStr + "Niveau des monsters capturables : [ Niveau du Héros " + tDigit(effectValue - 100, 0, false, null, true) + " ] ou moins";
                else
                    tempString = optStr + "Stats des monstres visibles pour les monstres de niveau " + tDigit(effectValue) + " ou moins";
                break;
            case TitleKind.EquipmentSlotWeapon:
                tempString = optStr + "Emplacements d'Arme + " + percent(effectValue);
                break;
            case TitleKind.EquipmentSlotArmor:
                tempString = optStr + "Emplacements d'Armure + " + percent(effectValue);
                break;
            case TitleKind.EquipmentSlotJewelry:
                tempString = optStr + "Emplacements de Bijou + " + percent(effectValue);
                break;
            case TitleKind.PotionSlot:
                tempString = optStr + "Emplacements d'Utilitaires + " + tDigit(effectValue);
                break;
            case TitleKind.EquipmentProficiency:
                tempString = optStr + "Gain de Maîtrise d'Équipement + " + percent(effectValue);
                break;
            case TitleKind.SkillMaster:
                if (isSub) tempString = optStr + "Gain de Maîtrise de Capacité + " + percent(effectValue);
                else tempString = optStr + "Emplacements de Capacité de Classe + " + tDigit(effectValue);
                break;
            case TitleKind.Survival:
                tempString = optStr + "Chance de Coup Critique + 50% quand les PV sont en dessous de " + percent(effectValue);
                break;
            case TitleKind.FireResistance:
                if (isSub) tempString = optStr + percent(effectValue) + " chance de nullifier les dégâts de Feu";
                else tempString = optStr + "+ " + percent(effectValue) + " résistance aux dégâts de Glace";
                break;
            case TitleKind.IceResistance:
                if (isSub) tempString = optStr + percent(effectValue) + " chance de nullifier les dégâts de Glace";
                else tempString = optStr + "+ " + percent(effectValue) + " résistance aux dégâts de Glace";
                break;
            case TitleKind.ThunderResistance:
                if (isSub) tempString = optStr + percent(effectValue) + " chance de nullifier les dégâts d'Électricité";
                else tempString = optStr + "+ " + percent(effectValue) + " résistance aux dégâts d'Électricité";
                break;
            case TitleKind.LightResistance:
                if (isSub) tempString = optStr + percent(effectValue) + " chance de nullifier les dégâts de Lumière";
                else tempString = optStr + "+ " + percent(effectValue) + " résistance aux dégâts de Lumière";
                break;
            case TitleKind.DarkResistance:
                if (isSub) tempString = optStr + percent(effectValue) + " chance de nullifier les dégâts des Ténèbres";
                else tempString = optStr + "+ " + percent(effectValue) + " résistance aux dégâts des Ténèbres";
                break;
            case TitleKind.DebuffResistance:
                tempString = optStr + "+ " + percent(effectValue) + " résistance aux débuffs";
                break;
            case TitleKind.MoveSpeed:
                tempString = optStr + "Vitesse + " + percent(effectValue);
                break;
            case TitleKind.Alchemist:
                tempString = optStr + "Gain d'Eau Mystérieuse + " + percent(effectValue);
                break;
            case TitleKind.MetalHunter:
                if (isSub) tempString = optStr + "Gain d'EXP venant de monstres Métalliques + " + percent(effectValue);
                else
                    tempString = optStr + "Dégâts aux monstres Métalliques + " + tDigit(effectValue);
                break;
            case TitleKind.BreakingTheLimit:
                tempString = optStr + "Limite de Dégâts + " + tDigit(effectValue);
                break;
            case TitleKind.PhysicalDamage:
                tempString = optStr + "Dégâts Physiques + " + percent(effectValue);
                break;
            case TitleKind.FireDamage:
                tempString = optStr + "Dégâts de Feu + " + percent(effectValue);
                break;
            case TitleKind.IceDamage:
                tempString = optStr + "Dégâts de Glace + " + percent(effectValue);
                break;
            case TitleKind.ThunderDamage:
                tempString = optStr + "Dégâts d'Électricité + " + percent(effectValue);
                break;
            case TitleKind.LightDamage:
                tempString = optStr + "Dégâts de Lumière + " + percent(effectValue);
                break;
            case TitleKind.DarkDamage:
                tempString = optStr + "Dégâts des Ténèbres + " + percent(effectValue);
                break;
            case TitleKind.Cooperation:
                tempString = optStr + "Enable Background Cooperation that you gain " + percent(effectValue) + " in background";
                break;
            case TitleKind.Quester:
                return optStr + "# Complétions de Quêtes Générales + " + tDigit(effectValue) + " par complétion";
        }
        return tempString;
    }
    //Monster
    public override string MonsterSpeciesName(MonsterSpecies species)
    {
        switch (species)
        {
            case MonsterSpecies.Slime:
                return "Slime";
            case MonsterSpecies.MagicSlime:
                return "Slime Magique";
            case MonsterSpecies.Spider:
                return "Araignée";
            case MonsterSpecies.Bat:
                return "Chauve-Souris";
            case MonsterSpecies.Fairy:
                return "Fée";
            case MonsterSpecies.Fox:
                return "Renard";
            case MonsterSpecies.DevilFish:
                return "Poisson Démon";
            case MonsterSpecies.Treant:
                return "Tréant";
            case MonsterSpecies.FlameTiger:
                return "Tigre de Feu";
            case MonsterSpecies.Unicorn:
                return "Licorne";
            case MonsterSpecies.Mimic:
                return "Mimique";
        }
        return species.ToString();
    }
    public override string MonsterName(MonsterSpecies species, MonsterColor color)
    {
        string tempColorStr = color.ToString();
        string tempSpeciesStr = MonsterSpeciesName(species);
        switch (color)
        {
            case MonsterColor.Normal:
                tempColorStr = "Normal";
                break;
            case MonsterColor.Blue:
                tempColorStr = "Bleu";
                break;
            case MonsterColor.Yellow:
                tempColorStr = "Jaune";
                break;
            case MonsterColor.Red:
                tempColorStr = "Rouge";
                break;
            case MonsterColor.Green:
                tempColorStr = "Vert";
                break;
            case MonsterColor.Purple:
                tempColorStr = "Violet";
                break;
            case MonsterColor.Boss:
                tempColorStr = "Boss";
                break;
            case MonsterColor.Metal:
                tempColorStr = "Métallique";
                break;
        }
        return tempColorStr + " " + tempSpeciesStr;
    }
    //Pet
    public override string PetActiveEffect(PetActiveEffectKind kind)
    {
        switch (kind)
        {
            case PetActiveEffectKind.None:
                return "À venir dans une mise à jour future !";
            case PetActiveEffectKind.GetResource:
                return "Récupère les Ressources au sol automatiquement";
            case PetActiveEffectKind.GetMaterial:
                return "Récupère les Matériaux au sol automatiquement";
            case PetActiveEffectKind.UpgradeQueue:
                return "File d'Améliorations Disponible + 5 \n<size=16>Effectuez un Clic Droit sur une amélioration pour l'assigner à la File, Maj + Click Droit pour l'enlever de la File</size>";
            case PetActiveEffectKind.ExpandMysteriousWaterCap:
                return "Augmente la Limite d'Eau Mystérieuse automatiquement";
            case PetActiveEffectKind.RebirthTier1:
                return "Débloque un bouton dans l'onglet de Réincarnation pour activer la Réincarnation de Classe 1 Auto";
            case PetActiveEffectKind.RebirthTier2:
                return "Active la Réincarnation de Classe 2 Auto (A besoin du Bonus de la Fée Normale)";
            case PetActiveEffectKind.RebirthTier3:
                return "Active la Réincarnation de Classe 3 Auto (A besoin du Bonus de la Fée Normale)";
            case PetActiveEffectKind.RebirthTier4:
                return "Active la Réincarnation de Classe 4 Auto (A besoin du Bonus de la Fée Normale)";
            case PetActiveEffectKind.RebirthTier5:
                return "Active la Réincarnation de Classe 5 Auto (A besoin du Bonus de la Fée Normale)";
            case PetActiveEffectKind.RebirthTier6:
                return "Active la Réincarnation de Classe 6 Auto (A besoin du Bonus de la Fée Normale)";
            case PetActiveEffectKind.AlchemyQueue:
                return "File d'Alchimie Disponible + 10 \n<size=16>ffectuez un Clic Droit sur une potion pour l'assigner à la File, Maj + Click Droit pour l'enlever de la File</size>";
            case PetActiveEffectKind.EquipPotion:
                return "Réapprovisionne les objets Utilitaires équipés";//return "Automatically equip to restore Utility items that you are equipping";
            case PetActiveEffectKind.Capture:
                return "Utilise un piège automatiquement pour capturer un monstre quand il est vaincu tant qu'un piège valide est équipé";
            case PetActiveEffectKind.GetEquipment:
                return "Récupère les Équipements au sol automatiquement";
            case PetActiveEffectKind.DisassembleEquipment:
                return "Emplacements de Désassemblage d'Équipement Auto + 10 \n<size=16>Cliquer sur un équipement dans le dictionnaire pour assigner/enlever le désassemblage auto quand il est ramassé";
            case PetActiveEffectKind.DisassemblePotion:
                return "Active la touche Maj+D pour désassembler une potion lors de son alchimie";
            case PetActiveEffectKind.BuyShopMaterialSlime:
                return "Achète l'" + Material(MaterialKind.OilOfSlime) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialMagicSlime:
                return "Achète le " + Material(MaterialKind.EnchantedCloth) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialSpider:
                return "Achète la " + Material(MaterialKind.SpiderSilk) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialBat:
                return "Achète l'" + Material(MaterialKind.BatWing) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialFairy:
                return "Achète la" + Material(MaterialKind.FairyDust) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialFox:
                return "Achète la" + Material(MaterialKind.FoxTail) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialDevilfish:
                return "Achète les" + Material(MaterialKind.FishScales) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialTreant:
                return "Achète la" + Material(MaterialKind.CarvedBranch) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialFlametiger:
                return "Achète la" + Material(MaterialKind.ThickFur) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialUnicorn:
                return "Achète la" + Material(MaterialKind.UnicornHorn) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopTrapNormal:
                return "Achète le" + PotionName(PotionKind.ThrowingNet) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopTrapIce:
                return "Achète le" + PotionName(PotionKind.IceRope) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopTrapThunder:
                return "Achète le" + PotionName(PotionKind.ThunderRope) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopTrapFire:
                return "Achète le" + PotionName(PotionKind.FireRope) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopTrapLight:
                return "Achète le" + PotionName(PotionKind.LightRope) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopTrapDark:
                return "Achète le" + PotionName(PotionKind.DarkRope) + " automatiquement dans le magasin";
            case PetActiveEffectKind.RetryDungeon:
                return "Réessaye le donjon courant automatiquement après l'avoir complété";
            case PetActiveEffectKind.OpenChest:
                return "Ouvre les trésors automatiquement dans un donjon";
            case PetActiveEffectKind.SkillRankUp:
                return "Augmente le rang des capacités automatiquement";
            case PetActiveEffectKind.SmartSlimeCoins:
                return "Garde les Pièces Slime jusqu'à atteindre la limite avant d'acheter des améliorations avec la File";
            case PetActiveEffectKind.TownLevelUp:
                return "Augmente le niveau des bâtiments automatiquement";
            case PetActiveEffectKind.RebirthUpgradeEXP:
                return "Augmente l'amélioration de Réincarnation de Classe 1 [Multiplicateur d'EXP] automatiquement";
            case PetActiveEffectKind.EquipNonMaxedEQ:
                return "Remplace les équipements au niveau max avec des équipements qui n'y sont pas automatiquement lorsqu'ils atteignent leur niveau max";
            case PetActiveEffectKind.AutoCraftDisassembleEQ:
                return "Désassemble les équipements lorsqu'ils sont construits à travers le Dictionnaire automatiquement";
            case PetActiveEffectKind.DisassembleTalismanCommon:
                return "Désassemble les Talismans communs automatiquement lorsqu'ils sont récupérés";
            case PetActiveEffectKind.BuyBlessing:
                return "Achète des Bénédictions de façon aléatoire automatiquement";
            case PetActiveEffectKind.AutoExpedition:
                return "Commence et réclame les expéditions automatiquement";
            case PetActiveEffectKind.AutoEquipTrap:
                return "Échange les pièges équipés avec ceux correspondant à la zone courante automatiquement s'ils sont dans l'inventaire (sauf les objets verrouillés)";
            case PetActiveEffectKind.AutoUseProfScroll:
                return "Utilise des Parchemins de Maîtrise automatiquement sur les objets équipés si vous avez acheté [Utilisation Intelligente des Parchemins de Maîtrise] dans le Magasin Épique";
        }
        return kind.ToString();
    }
    //Area
    public override string AreaName(AreaKind kind)
    {
        switch (kind)
        {
            case AreaKind.SlimeVillage:
                return "Village des Slimes";
            case AreaKind.MagicSlimeCity:
                return "Cité des Slimes Magiques";
            case AreaKind.SpiderMaze:
                return "Labyrinthe des Araignées";
            case AreaKind.BatCave:
                return "Grotte des Chauve-Souris";
            case AreaKind.FairyGarden:
                return "Jardin des Fées";
            case AreaKind.FoxShrine:
                return "Autel des Renards";
            case AreaKind.DevilFishLake:
                return "Lac des Poissons Démon";
            case AreaKind.TreantDarkForest:
                return "Forêt Noire des Tréants";
            case AreaKind.FlameTigerVolcano:
                return "Volcan des Tigres de Feu";
            case AreaKind.UnicornIsland:
                return "Île des Licornes";
        }
        return kind.ToString();
    }

    //未
    //AreaPrestige//未
    public override (string name, string currentEffect, string nextEffect) AreaPrestigeUpgrade(AreaPrestigeUpgrade upgrade)
    {
        string tempName = upgrade.kind.ToString();
        string tempEffect = "";
        string tempNextEffect = "";
        switch (upgrade.kind)
        {
            case AreaPrestigeUpgradeKind.MaxAreaLevelUp:
                tempName = "Prestige de Zone";
                tempEffect = "Limite de Difficulté de Zone + " + tDigit(upgrade.effectValue);
                tempNextEffect = "Limite de Difficulté de Zone + " + tDigit(upgrade.nextEffectValue);
                break;
            case AreaPrestigeUpgradeKind.UnlockMission: //TOCHECK
                tempName = "Challengeur de Mission";
                tempEffect = "Débloque une autre mission " + tDigit(upgrade.effectValue);
                tempNextEffect = "Débloque une autre mision " + tDigit(upgrade.nextEffectValue);
                break;
            case AreaPrestigeUpgradeKind.ClearCount:
                tempName = "Bénédiction de l'Explorateur";
                tempEffect = "Nombre de Complétions de Zone et de Récompenses de Zone + " + tDigit(upgrade.effectValue);
                tempNextEffect = "Nombre de Complétions de Zone et de Récompenses de Zone + " + tDigit(upgrade.nextEffectValue);
                break;
            case AreaPrestigeUpgradeKind.DecreaseMaxWave:
                tempName = "Un Moment Pour Respirer";
                tempEffect = "Nombre de values max requises pour compléter une zone - " + tDigit(upgrade.effectValue);
                tempNextEffect = "Nombre de values max requises pour compléter une zone - " + tDigit(upgrade.nextEffectValue)
                    + "\n( Ne peut pas être en dessous de 10 )";
                break;
            case AreaPrestigeUpgradeKind.ExpBonus:
                tempName = "Bonus d'EXP";
                tempEffect = "Gain d'EXP + " + percent(upgrade.effectValue) + " si vous êtes dans la région " + AreaName(upgrade.prestige.areaKind);
                tempNextEffect = "Gain d'EXP + " + percent(upgrade.nextEffectValue) + " si vous êtes dans la région " + AreaName(upgrade.prestige.areaKind);
                break;
            case AreaPrestigeUpgradeKind.MoveSpeedBonus:
                tempName = "Bonus de Vitesse";
                tempEffect = "Vitesse + " + percent(upgrade.effectValue) + " si vous êtes dans la région " + AreaName(upgrade.prestige.areaKind);
                tempNextEffect = "Vitesse + " + percent(upgrade.nextEffectValue) + " si vous êtes dans la région " + AreaName(upgrade.prestige.areaKind);
                break;
            case AreaPrestigeUpgradeKind.TreasureChest:
                tempName = "Chasseur de Trésor";
                tempEffect = "Chance d'Apparition de Coffre " + percent(upgrade.effectValue) + " quand un monstre est vaincu";
                tempNextEffect = "Chance d'Apparition de Coffre " + percent(upgrade.nextEffectValue) + " quand un monstre est vaincu";
                break;
            case AreaPrestigeUpgradeKind.LimitTime:
                tempName = "Temps Additionnel";
                tempEffect = "Limite de Temps + " + tDigit(upgrade.effectValue) + " sec";
                tempNextEffect = "Limite de Temps + " + tDigit(upgrade.nextEffectValue) + " sec";
                break;
            case AreaPrestigeUpgradeKind.MetalSlime:
                tempName = "Chasseur de Métal";
                tempEffect = "Chance d'Apparition de monstre Métallique " + percent(upgrade.effectValue, 3);
                tempNextEffect = "Chance d'Apparition de monstre Métallique " + percent(upgrade.nextEffectValue, 3);
                break;
            case AreaPrestigeUpgradeKind.PortalOrb:
                tempName = "Clé de Portail";
                tempEffect = "Coût en Orbe Portail pour entrer ce donjon - " + tDigit(upgrade.effectValue);
                tempNextEffect = "Coût en Orbe Portail pour entrer ce donjon - " + tDigit(upgrade.nextEffectValue)
                    + "\n( Ne peut pas être en dessous de 1 Orbe Portail )";
                break;
        }
        return (tempName, tempEffect, tempNextEffect);
    }
    //Equipment//未
    public override string EquipmentName(EquipmentKind kind)
    {
        switch (kind)
        {
            case EquipmentKind.Nothing:
                break;
            case EquipmentKind.DullSword:
                return "Épée Émoussée";
            case EquipmentKind.BrittleStaff:
                return "Baguette Fragile";
            case EquipmentKind.FlimsyWing:
                return "Aile Légère";
            case EquipmentKind.WornDart:
                return "Fléchette Usée";
            case EquipmentKind.SmallBow:
                return "Petit Arc";
            case EquipmentKind.WoodenRecorder:
                return "Flûte en Bois";
            case EquipmentKind.OldCloak:
                return "Vieille Cape";
            case EquipmentKind.BlueHat:
                return "Chapeau Bleu";
            case EquipmentKind.OrangeHat:
                return "Chapeau Orange";
            case EquipmentKind.ClothShoes:
                return "Chaussures en Tissu";
            case EquipmentKind.IronRing:
                return "Anneau en Fer";
            case EquipmentKind.SlimeRing:
                return "Anneau Slime";
            case EquipmentKind.SlimeSword:
                return "Épée Slime";
            case EquipmentKind.TShirt:
                return "T-shirt";
            case EquipmentKind.ClothGlove:
                return "Gant en Tissu";
            case EquipmentKind.BlueTShirt:
                return "T-shirt Bleu";
            case EquipmentKind.OrangeTShirt:
                return "T-shirt Orange";
            case EquipmentKind.ClothBelt:
                return "Ceinture en Tissu";
            case EquipmentKind.PearlEarring:
                return "Boucle d'Oreille en Perle";
            case EquipmentKind.FireBrooch:
                return "Broche de Feu";
            case EquipmentKind.IceBrooch:
                return "Broche de Glace";
            case EquipmentKind.ThunderBrooch:
                return "Broche d'Électricité";
            case EquipmentKind.LightBrooch:
                return "Broche de Lumière";
            case EquipmentKind.DarkBrooch:
                return "Broche des Ténèbres";
            case EquipmentKind.WoodenShield:
                return "Bouclier en Bois";
            case EquipmentKind.LongSword:
                return "Épée Longue";
            case EquipmentKind.LongStaff:
                return "Bâton Long";
            case EquipmentKind.WarmWing:
                return "Aile Chaude";
            case EquipmentKind.DualDagger:
                return "Double Dague";
            case EquipmentKind.ReinforcedBow:
                return "Arc Renforcé";
            case EquipmentKind.Flute:
                return "Flûte";
            case EquipmentKind.FireStaff:
                return "Bâton de Feu";
            case EquipmentKind.IceStaff:
                return "Bâton de Glace";
            case EquipmentKind.ThunderStaff:
                return "Bâton d'Électricité";
            case EquipmentKind.LeatherBelt:
                return "Ceinture en Cuir";
            case EquipmentKind.LeatherShoes:
                return "Chaussures en Cuir";
            case EquipmentKind.WarmCloak:
                return "Cape Chaude";
            case EquipmentKind.LeatherArmor:
                return "Armure en Cuir";
            case EquipmentKind.LeatherGlove:
                return "Gants en Cuir";
            case EquipmentKind.LeatherShield:
                return "Bouclier en Cuir";
            case EquipmentKind.FireRing:
                return "Anneau de Feu";
            case EquipmentKind.IceRing:
                return "Anneau de Glace";
            case EquipmentKind.ThunderRing:
                return "Anneau d'Électricité";
            case EquipmentKind.LightRing:
                return "Anneau de Lumière";
            case EquipmentKind.DarkRing:
                return "Anneau des Ténèbres";
            case EquipmentKind.EnhancedFireBrooch:
                return "Broche de Feu Supérieure";
            case EquipmentKind.EnhancedIceBrooch:
                return "Broche de Glace Supérieure";
            case EquipmentKind.EnhancedThunderBrooch:
                return "Broche d'Électricité Supérieure";
            case EquipmentKind.EnhancedLightBrooch:
                return "Broche de Lumière Supérieure";
            case EquipmentKind.EnhancedDarkBrooch:
                return "Broche des Ténèbres Supérieure";
            case EquipmentKind.BattleSword:
                return "Épée de Combat";
            case EquipmentKind.BattleStaff:
                return "Bâton de Combat";
            case EquipmentKind.BattleWing:
                return "Aile de Combat";
            case EquipmentKind.BattleDagger:
                return "Dague de Combat";
            case EquipmentKind.BattleBow:
                return "Arc de Combat";
            case EquipmentKind.BattleRecorder:
                return "Flûte de Combat";
            case EquipmentKind.SlimeGlove:
                return "Gants Slime";
            case EquipmentKind.SlimeBelt:
                return "Ceinture Slime";
            case EquipmentKind.SlimePincenez:
                return "Pince-nez Slime";
            case EquipmentKind.SlimeWing:
                return "Aile Slime";
            case EquipmentKind.SlimePoncho:
                return "Poncho Slime";
            case EquipmentKind.SlimeDart:
                return "Fléchette Slime";
            case EquipmentKind.MagicSlimeStick:
                return "Bâton de Slime Magique";
            case EquipmentKind.MagicSlimeHat:
                return "Chapeau de Slime Magique";
            case EquipmentKind.MagicSlimeBow:
                return "Arc de Slime Magique";
            case EquipmentKind.MagicSlimeShoes:
                return "Chaussures de Slime Magique";
            case EquipmentKind.MagicSlimeRecorder: //TODO
                return "Magicslime Recorder";
            case EquipmentKind.MagicSlimeEarring:
                return "Boucle d'Oreille de Slime Magique";
            case EquipmentKind.MagicSlimeBalloon:
                return "Ballon de Slime Magique";
            case EquipmentKind.MagicSlimeSkirt:
                return "Jupe de Slime Magique";
            case EquipmentKind.SpiderHat:
                return "Chapeau d'Araignée";
            case EquipmentKind.SpiderSkirt:
                return "Jupe d'Araignée";
            case EquipmentKind.SpiderSuit:
                return "Tenue d'Araignée";
            case EquipmentKind.SpiderDagger:
                return "Dague d'Araignée";
            case EquipmentKind.SpiderWing:
                return "Aile d'Araignée";
            case EquipmentKind.SpiderCatchingNet:
                return "Filet d'Araignée";
            case EquipmentKind.SpiderStick:
                return "Bâton d'Araignée";
            case EquipmentKind.SpiderFoldingFan:
                return "Éventail d'Araignée";
            case EquipmentKind.BatRing:
                return "Anneau Chauve-Souris";
            case EquipmentKind.BatShoes:
                return "Chaussures Chauve-Souris";
            case EquipmentKind.BatSword:
                return "Épée Chauve-Souris";
            case EquipmentKind.BatHat:
                return "Casque Chauve-Souris";
            case EquipmentKind.BatRecorder: //TODO
                return "Bat Recorder";
            case EquipmentKind.BatBow:
                return "Arc Chauve-Souris";
            case EquipmentKind.BatMascaradeMask:
                return "Masque de Mascarade Chauve-Souris";
            case EquipmentKind.BatCloak:
                return "Cape Chauve-Souris";
            case EquipmentKind.BronzeShoulder:
                return "Épaulière en Bronze";
            case EquipmentKind.BattleRing:
                return "Anneau de Combat";
            case EquipmentKind.Halo:
                return "Halo";
            case EquipmentKind.IronShoulder:
                return "Épaulière en Fer";
            case EquipmentKind.StrengthRing:
                return "Anneau de Force";
            case EquipmentKind.GoldenRing:
                return "Anneau Doré";
            case EquipmentKind.GoldenFireRing:
                return "Anneau Doré de Feu";
            case EquipmentKind.GoldenIceRing:
                return "Anneau Doré de Glace";
            case EquipmentKind.GoldenThunderRing:
                return "Anneau Doré d'Électricité";
            case EquipmentKind.GoldenLightRing:
                return "Anneau Doré de Lumière";
            case EquipmentKind.GoldenDarkRing:
                return "Anneau Doré des Ténèbres";
            case EquipmentKind.IronBelt:
                return "Ceinture en Fer";
            case EquipmentKind.IronShoes:
                return "Chaussures en Fer";
            case EquipmentKind.CopperArmor:
                return "Armure en Cuivre";
            case EquipmentKind.IronGlove:
                return "Gants en Fer";
            case EquipmentKind.TowerShield:
                return "Bouclier Long";
            case EquipmentKind.FireTowerShield:
                return "Bouclier Long de Feu";
            case EquipmentKind.IceTowerShield:
                return "Bouclier Long de Glace";
            case EquipmentKind.ThunderTowerShield:
                return "Bouclier Long d'Électricité";
            case EquipmentKind.LightTowerShield:
                return "Bouclier Long de Lumière";
            case EquipmentKind.DarkTowerShield:
                return "Bouclier Long des Ténèbres";
            case EquipmentKind.SavageRing:
                return "Anneau Sauvage";
            case EquipmentKind.SpellboundFireBrooch:
                return "Broche de Feu Enchantée";
            case EquipmentKind.SpellboundIceBrooch:
                return "Broche de Glace Enchantée";
            case EquipmentKind.SpellboundThunderBrooch:
                return "Broche d'Électricité Enchantée";
            case EquipmentKind.SpellboundLightBrooch:
                return "Broche de Lumière Enchantée";
            case EquipmentKind.SpellboundDarkBrooch:
                return "Broche des Ténèbres Enchantée";
            case EquipmentKind.CopperHelm:
                return "Heaume en Cuivre";
            case EquipmentKind.BattleHelm:
                return "Heaume de Combat";
            case EquipmentKind.WizardHelm:
                return "Heaume de Mage";
            case EquipmentKind.LargeSword:
                return "Grande Épée";
            case EquipmentKind.LargeStaff:
                return "Grand Bâton";
            case EquipmentKind.LargeWing:
                return "Grande Aile";
            case EquipmentKind.LargeDagger:
                return "Grande Dague";
            case EquipmentKind.LargeBow:
                return "Grand Arc";
            case EquipmentKind.LargeOcarina:
                return "Grand Ocarina";
            case EquipmentKind.FairyClothes:
                return "Vêtements Féeriques";
            case EquipmentKind.FairyStaff:
                return "Bâton Féerique";
            case EquipmentKind.FairyBoots:
                return "Chaussures Féeriques";
            case EquipmentKind.FairyGlove:
                return "Gants Féeriques";
            case EquipmentKind.FairyBrooch:
                return "Broche Féerique";
            case EquipmentKind.FairyLamp:
                return "Lampe Féerique";
            case EquipmentKind.FairyWing:
                return "Aile Féerique";
            case EquipmentKind.FairyShuriken:
                return "Shuriken Féerique";
            case EquipmentKind.FoxKanzashi:
                return "Kanzashi Renard";
            case EquipmentKind.FoxLoincloth:
                return "Pagne Renard";
            case EquipmentKind.FoxMask:
                return "Masque de Renard";
            case EquipmentKind.FoxHamayayumi:
                return "Hamaya-Yumi Renard";
            case EquipmentKind.FoxHat:
                return "Chapeau Renard";
            case EquipmentKind.FoxCoat:
                return "Manteau en Renard";
            case EquipmentKind.FoxBoot:
                return "Chaussure Renard";
            case EquipmentKind.FoxEma:
                return "Ema Renard";
            case EquipmentKind.DevilfishSword:
                return "Épée Poisson Démon";
            case EquipmentKind.DevilfishWing:
                return "Aile de Poisson Démon";
            case EquipmentKind.DevilfishRecorder: //TODO
                return "Devilfish Recorder";
            case EquipmentKind.DevilfishArmor:
                return "Armure Poisson Démon";
            case EquipmentKind.DevilfishScarf:
                return "Écharpe Poisson Démon";
            case EquipmentKind.DevilfishGill:
                return "Branchie de Poisson Démon";
            case EquipmentKind.DevilfishPendant:
                return "Pendatif de Poisson Démon";
            case EquipmentKind.DevilfishRing:
                return "Anneau de Poisson Démon";
            case EquipmentKind.TreantAmulet:
                return "Amulette Tréant";
            case EquipmentKind.TreantHagoita:
                return "Hagoita en Tréant";
            case EquipmentKind.TreantChoppingBoard:
                return "Planche à Découper en Tréant";
            case EquipmentKind.TreantDagger:
                return "Dague Tréante";
            case EquipmentKind.TreantHaniwa:
                return "Haniwa en Tréant";
            case EquipmentKind.TreantKokeshi:
                return "Kokeshi en Tréant";
            case EquipmentKind.TreantLamp:
                return "Lampe en Tréant";
            case EquipmentKind.TreantLunchbox:
                return "Gamelle en Tréant";
        }
        return kind.ToString();
    }
    public override string EquipmentEffectName(EquipmentEffectKind kind)
    {
        switch (kind)
        {
            case EquipmentEffectKind.Nothing:
                return "Enchantement Vide";
            case EquipmentEffectKind.HPAdder:
                return "PV +";
            case EquipmentEffectKind.MPAdder:
                return "PM +";
            case EquipmentEffectKind.ATKAdder:
                return "ATQ +";
            case EquipmentEffectKind.MATKAdder:
                return "MATQ +";
            case EquipmentEffectKind.DEFAdder:
                return "DEF +";
            case EquipmentEffectKind.MDEFAdder:
                return "MDEF +";
            case EquipmentEffectKind.SPDAdder:
                return "VIT +";
            case EquipmentEffectKind.HPMultiplier:
                return "Multiplicateur de PV";
            case EquipmentEffectKind.MPMultiplier:
                return "Multiplicateur de PM";
            case EquipmentEffectKind.ATKMultiplier:
                return "Multiplicateur d'ATQ";
            case EquipmentEffectKind.MATKMultiplier:
                return "Multiplicateur de MATQ";
            case EquipmentEffectKind.DEFMultiplier:
                return "Multiplicateur de DEF";
            case EquipmentEffectKind.MDEFMultiplier:
                return "Multiplicateur de MDEF";
            case EquipmentEffectKind.ATKPropotion:
                return "Proportion d'ATQ";
            case EquipmentEffectKind.MATKPropotion:
                return "Proportion de MATQ";
            case EquipmentEffectKind.DEFPropotion:
                return "Proportion de DEF";
            case EquipmentEffectKind.MDEFPropotion:
                return "Proportion de MDEF";
            case EquipmentEffectKind.FireResistance:
                return "Résistance Enflammée";
            case EquipmentEffectKind.IceResistance:
                return "Résistance Glaciale";
            case EquipmentEffectKind.ThunderResistance:
                return "Résistance Électrique";
            case EquipmentEffectKind.LightResistance:
                return "Résistance Lumineuse";
            case EquipmentEffectKind.DarkResistance:
                return "Résistance Ténèbreuse";
            case EquipmentEffectKind.PhysicalAbsorption:
                return "Résistance Physique";
            case EquipmentEffectKind.FireAbsorption:
                return "Absorption du Feu";
            case EquipmentEffectKind.IceAbsorption:
                return "Absorption de la Glace";
            case EquipmentEffectKind.ThunderAbsorption:
                return "Absorption de l'Électricité";
            case EquipmentEffectKind.LightAbsorption:
                return "Absorption de la Lumière";
            case EquipmentEffectKind.DarkAbsorption:
                return "Absorption des Ténèbres";
            case EquipmentEffectKind.DebuffResistance:
                return "Résistance Débuffs";
            case EquipmentEffectKind.PhysicalCritical:
                return "Critique Physique";
            case EquipmentEffectKind.MagicalCritical:
                return "Critique Magique";
            case EquipmentEffectKind.EXPGain:
                return "Gain d'EXP";
            case EquipmentEffectKind.SkillProficiency:
                return "Maîtrise de Capacité";
            case EquipmentEffectKind.EquipmentProficiency:
                return "Maîtrise d'Équipement";
            case EquipmentEffectKind.MoveSpeedAdder:
                return "Vitesse +";
            case EquipmentEffectKind.MoveSpeedMultiplier:
                return "Multiplicateur de Vitesse";
            case EquipmentEffectKind.GoldGain:
                return "Gain d'Or";
            case EquipmentEffectKind.StoneGain:
                return "Gain de Pierre";
            case EquipmentEffectKind.CrystalGain:
                return "Gain de Cristal";
            case EquipmentEffectKind.LeafGain:
                return "Gain de Feuille";
            case EquipmentEffectKind.WarriorSkillLevel:
                return "Capacité du Guerrier";
            case EquipmentEffectKind.WizardSkillLevel:
                return "Capacité du Mage";
            case EquipmentEffectKind.AngelSkillLevel:
                return "Capacité de l'Ange";
            case EquipmentEffectKind.ThiefSkillLevel:
                return "Capacité du Voleur";
            case EquipmentEffectKind.ArcherSkillLevel:
                return "Capacité de l'Archer";
            case EquipmentEffectKind.TamerSkillLevel:
                return "Capacité de la Dompteuse";
            case EquipmentEffectKind.AllSkillLevel:
                return "Omni Capacité";
            case EquipmentEffectKind.SlimeKnowledge:
                return "Affinité - Slimes";
            case EquipmentEffectKind.MagicSlimeKnowledge:
                return "Affinité - Slimes Magiques";
            case EquipmentEffectKind.SpiderKnowledge:
                return "Affinité - Araignées";
            case EquipmentEffectKind.BatKnowledge:
                return "Affinité - Chauve-Souris";
            case EquipmentEffectKind.FairyKnowledge:
                return "Affinité - Fées";
            case EquipmentEffectKind.FoxKnowledge:
                return "Affinité - Renards";
            case EquipmentEffectKind.DevilFishKnowledge:
                return "Affinité - Poissons Démon";
            case EquipmentEffectKind.TreantKnowledge:
                return "Affinité - Tréant";
            case EquipmentEffectKind.FlameTigerKnowledge:
                return "Affinité - Tigres de Feu";
            case EquipmentEffectKind.UnicornKnowledge:
                return "Affinité - Licornes";
            case EquipmentEffectKind.PhysicalDamage:
                return "Dégâts Physiques";
            case EquipmentEffectKind.FireDamage:
                return "Dégâts de Feu";
            case EquipmentEffectKind.IceDamage:
                return "Dégâts de Glace";
            case EquipmentEffectKind.ThunderDamage:
                return "Dégâts d'Électricité";
            case EquipmentEffectKind.LightDamage:
                return "Dégâts de Lumière";
            case EquipmentEffectKind.DarkDamage:
                return "Dégâts des Ténèbres";
            case EquipmentEffectKind.EquipmentDropChance:
                return "Apparition d'Équipement";
            case EquipmentEffectKind.SlimeDropChance:
                return "Apparition d'Objet de Slime";
            case EquipmentEffectKind.MagicSlimeDropChance:
                return "Apparition d'Objet de Slime Magique";
            case EquipmentEffectKind.SpiderDropChance:
                return "Apparition d'Objet d'Araignée";
            case EquipmentEffectKind.BatDropChance:
                return "Apparition d'Objet de Chauve-Souris";
            case EquipmentEffectKind.FairyDropChance:
                return "Apparition d'Objet de Fée";
            case EquipmentEffectKind.FoxDropChance:
                return "Apparition d'Objet de Renard";
            case EquipmentEffectKind.DevilFishDropChance:
                return "Apparition d'Objet de Poisson Démon";
            case EquipmentEffectKind.TreantDropChance:
                return "Apparition d'Objet de Tréant";
            case EquipmentEffectKind.FlameTigerDropChance:
                return "Apparition d'Objet de Tigre de Feu";
            case EquipmentEffectKind.UnicornDropChance:
                return "Apparition d'Objet de Licorne";
            case EquipmentEffectKind.ColorMaterialDropChance:
                return "Apparition de Matériaux Rares";
            case EquipmentEffectKind.HpRegen:
                return "Régénération de PV";
            case EquipmentEffectKind.MpRegen:
                return "Régénération de PM";
            case EquipmentEffectKind.TamingPoint:
                return "Point de Domptage";
            case EquipmentEffectKind.PetEXPGain:
                return "Gain d'EXP des Familiers";
            case EquipmentEffectKind.LoyaltyPointGain:
                return "Gain de Point de Loyauté";
            case EquipmentEffectKind.WarriorSkillRange:
                return "Portée des Capacités du Guerrier";
            case EquipmentEffectKind.WizardSkillRange:
                return "Portée des Capacités de la Mage";
            case EquipmentEffectKind.AngelSkillRange:
                return "Portée des Capacités de l'Ange";
            case EquipmentEffectKind.ThiefSkillRange:
                return "Portée des Capacités du Voleur";
            case EquipmentEffectKind.ArcherSkillRange:
                return "Portée des Capacités de l'Archer";
            case EquipmentEffectKind.TamerSkillRange:
                return "Portée des Capacités de la Dompteuse";
            case EquipmentEffectKind.WarriorSkillEffectRange:
                return "Portée de l'Effet des Capacités du Guerrier";
            case EquipmentEffectKind.WizardSkillEffectRange:
                return "Portée de l'Effet des Capacités de la Mage";
            case EquipmentEffectKind.AngelSkillEffectRange:
                return "Portée de l'Effet des Capacités de l'Ange";
            case EquipmentEffectKind.ThiefSkillEffectRange:
                return "Portée de l'Effet des Capacités du Voleur";
            case EquipmentEffectKind.ArcherSkillEffectRange:
                return "Portée de l'Effet des Capacités de l'Archer";
            case EquipmentEffectKind.TamerSkillEffectRange:
                return "Portée de l'Effet des Capacités de la Dompteuse";
            case EquipmentEffectKind.TownMatGain:
                return "Gain de Matériaux de Ville";
            case EquipmentEffectKind.TownMatAreaClearGain:
                return "Gain de Matériaux de Ville (Zone)";
            //case EquipmentEffectKind.TownMatDungeonRewardGain:
            //    return "Gain de Matériaux de Ville (Donjon)";
            case EquipmentEffectKind.RebirthPointGain1:
                return "Gain de Points de Réincarnation de Classe 1";
            case EquipmentEffectKind.RebirthPointGain2:
                return "Gain de Points de Réincarnation de Classe 2";
            case EquipmentEffectKind.RebirthPointGain3:
                return "Gain de Points de Réincarnation de Classe 3";
            case EquipmentEffectKind.CriticalDamage:
                return "Dégâts Critiques";
            case EquipmentEffectKind.BlessingEffect:
                return "Effet de Bénédiction";
            case EquipmentEffectKind.CatalystDoubleCriticalChance:
                return "Catalysation Critique";
        }
        return kind.ToString();
    }
    public override string EquipmentEffect(EquipmentEffectKind kind, double value, bool isLevelMaxEffect = false, double perLevelValue = 0, bool isOnlyEffectValue = false)
    {
        string tempString = "";
        switch (kind)
        {
            case EquipmentEffectKind.Nothing:
                if (isOnlyEffectValue) return "";
                if (isLevelMaxEffect) tempString = "Emplacement d'Enchantement + " + tDigit(value);
                else tempString = "[Enchantement Disponible]";
                break;
            case EquipmentEffectKind.HPAdder:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "PV + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.MPAdder:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "PM + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.ATKAdder:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "ATQ + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.MATKAdder:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "MATQ + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.DEFAdder:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "DEF + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.MDEFAdder:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "MDEF + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.SPDAdder:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "VIT <color=red>" + tDigit(value, 1) + "</color>";
                else tempString = "VIT + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.HPMultiplier:
                if (isOnlyEffectValue) return percent(value);
                tempString = "PV + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MPMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "PM <color=red>" + percent(value) + "</color>";
                else tempString = "PM + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ATKMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "ATQ <color=red>" + percent(value) + "</color>";
                else tempString = "ATQ + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MATKMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "MATQ <color=red>" + percent(value) + "</color>";
                else tempString = "MATQ + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DEFMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "DEF <color=red>" + percent(value) + "</color>";
                else tempString = "DEF + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MDEFMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "MDEF <color=red>" + percent(value) + "</color>";
                else tempString = "MDEF + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ATKPropotion:
                if (isOnlyEffectValue) return percent(value);
                tempString = "ATQ + " + percent(value) + " du Niveau du Héros";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MATKPropotion:
                if (isOnlyEffectValue) return percent(value);
                tempString = "MATQ + " + percent(value) + " du Niveau du Héros";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DEFPropotion:
                if (isOnlyEffectValue) return percent(value);
                tempString = "DEF + " + percent(value) + " du Niveau du Héros";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MDEFPropotion:
                if (isOnlyEffectValue) return percent(value);
                tempString = "MDEF + " + percent(value) + " du Niveau du Héros";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FireResistance:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Résistance au Feu + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.IceResistance:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Résistance à la Glace + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ThunderResistance:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Résistance à l'Électricité + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LightResistance:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Résistance à la Lumière + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DarkResistance:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Résistance aux Ténèbres + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PhysicalAbsorption:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Absorption Physique + " + percent(value) + " des dégâts reçus";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FireAbsorption:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Absorption du Feu + " + percent(value) + " des dégâts reçus";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.IceAbsorption:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Absorption de la Glace + " + percent(value) + " des dégâts reçus";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ThunderAbsorption:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Absorption de l'Électricité + " + percent(value) + " des dégâts reçus";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LightAbsorption:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Absorption de la Lumière + " + percent(value) + " des dégâts reçus";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DarkAbsorption:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Absorption des Ténèbres + " + percent(value) + " des dégâts reçus";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DebuffResistance:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Résistance aux Débuffs + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PhysicalCritical:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Chance de Coup Critique Physique + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MagicalCritical:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Chance de Coup Critique Magique + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.EXPGain:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain d'EXP + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.SkillProficiency:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain de Maîtrise de Capacité + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.EquipmentProficiency:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gainde Maîtrise d'Équipement + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MoveSpeedAdder:
                if (isOnlyEffectValue) return meter(value);
                if (value < 0) tempString = "Vitesse <color=red>" + meter(value) + " / sec</color>";
                else tempString = "Vitesse + " + meter(value) + " / sec";
                if (perLevelValue > 0) tempString += " ( + " + meter(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MoveSpeedMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Vitesse <color=red>" + percent(value) + "</color>";
                else tempString = "Vitesse + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.GoldGain:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain d'Or (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.StoneGain:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain de Pierre (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.CrystalGain:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gzin de Cristal (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LeafGain:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain de Feuille (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.WarriorSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "Niveau des Capacités du Guerrier (Global) + " + tDigit(value, 1); //tDigit(System.Math.Floor(value));
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.WizardSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "Niveau des Capacités de la Mage (Global) + " + tDigit(value, 1); //tDigit(System.Math.Floor(value));
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.AngelSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "Niveau des Capacités de l'Ange (Global) + " + tDigit(value, 1); //tDigit(System.Math.Floor(value));
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.ThiefSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "Niveau des Capacités du Voleur (Global) + " + tDigit(value, 1); //tDigit(System.Math.Floor(value));
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.ArcherSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "Niveau des Capacités de l'Archer (Global) + " + tDigit(value, 1); //tDigit(System.Math.Floor(value));
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.TamerSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "Niveau des Capacités de la Dompteuse (Global) + " + tDigit(value, 1); //tDigit(System.Math.Floor(value));
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.AllSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "Niveau de Toutes les Capacités (Global) + " + tDigit(value, 1); //tDigit(System.Math.Floor(value));
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.SlimeKnowledge:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts infligés aux Slimes + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MagicSlimeKnowledge:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts infligés aux Slimes Magiques + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.SpiderKnowledge:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts infligés aux Araignées + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.BatKnowledge:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts infligés aux Chauve-Souris + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FairyKnowledge:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts infligés aux Fées + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FoxKnowledge:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts infligés aux Renards + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DevilFishKnowledge:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts infligés aux Poissons Démon + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.TreantKnowledge:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts infligés aux Tréants + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FlameTigerKnowledge:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts infligés aux Tigres de Feu + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.UnicornKnowledge:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts infligés aux Licornes + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PhysicalDamage:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Physiques + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FireDamage:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts de Feu + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.IceDamage:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts de Glace + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ThunderDamage:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts d'Électricité + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LightDamage:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts de Lumière + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DarkDamage:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts des Ténèbres + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.EquipmentDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Chance d'Apparition d'Équipement + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 4) + " / Nv )";
                break;
            case EquipmentEffectKind.SlimeDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Chance d'Apparition d'" + Material(MaterialKind.OilOfSlime) + " (Global) + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.MagicSlimeDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Chance d'Apparition d'" + Material(MaterialKind.EnchantedCloth) + " (Global) + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.SpiderDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Chance d'Apparition d'" + Material(MaterialKind.SpiderSilk) + " (Global) + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.BatDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Chance d'Apparition d'" + Material(MaterialKind.BatWing) + " (Global) + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.FairyDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Chance d'Apparition d'" + Material(MaterialKind.FairyDust) + " (Global) + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.FoxDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Chance d'Apparition d'" + Material(MaterialKind.FoxTail) + " (Global) + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.DevilFishDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Chance d'Apparition d'" + Material(MaterialKind.FishScales) + " (Global) + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.TreantDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Chance d'Apparition d'" + Material(MaterialKind.CarvedBranch) + " (Global) + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.FlameTigerDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Chance d'Apparition d'" + Material(MaterialKind.ThickFur) + " (Global) + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.UnicornDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Chance d'Apparition d'" + Material(MaterialKind.UnicornHorn) + " (Global) + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.ColorMaterialDropChance:
                if (isOnlyEffectValue) return percent(value, 4);
                tempString = "Chance d'Apparition de Matériaux Rares (Global) + " + percent(value, 4);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 4) + " / Nv )";
                break;
            case EquipmentEffectKind.HpRegen:
                if (isOnlyEffectValue) return tDigit(value, 2);
                tempString = "Régénération de PV + " + tDigit(value, 2) + " / sec";
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.MpRegen:
                if (isOnlyEffectValue) return tDigit(value, 2);
                tempString = "Régénération de PM + " + tDigit(value, 2) + " / sec";
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.TamingPoint:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain de Points de Domptage + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PetEXPGain:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain d'EXP des Familiers Invoqués + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LoyaltyPointGain:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain de Points de Loyauté + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.WarriorSkillRange:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Portée des Capacités du Guerrier + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.WizardSkillRange:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Portée des Capacités de la Mage + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.AngelSkillRange:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Portée des Capacités de l'Ange + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.ThiefSkillRange:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Portée des Capacités du Voleur + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.ArcherSkillRange:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Portée des Capacités de l'Archer + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.TamerSkillRange:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Portée des Capacités de la Dompteuse + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.WarriorSkillEffectRange:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Portée des Effets des Capacités du Guerrier + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.WizardSkillEffectRange:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Portée des Effets des Capacités de la Mage + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.AngelSkillEffectRange:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Portée des Effets des Capacités de l'Ange + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.ThiefSkillEffectRange:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Portée des Effets des Capacités du Voleur + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.ArcherSkillEffectRange:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Portée des Effets des Capacités de l'Archer + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.TamerSkillEffectRange:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Portée des Effets des Capacités de la Dompteuse + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.TownMatGain:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain de Matériaux de Ville + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.TownMatAreaClearGain:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "Gain de Matériaux de Ville depuis la Complétion d'une Zone + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            //case EquipmentEffectKind.TownMatDungeonRewardGain:
            //    tempString = "Gain de Matériaux de Ville depuis la Complétion d'un Donjon + " + percent(value);
            //    if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
            //    break;
            case EquipmentEffectKind.RebirthPointGain1:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain de Points de Réincarnation de Classe 1 + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.RebirthPointGain2:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain de Points de Réincarnation de Classe 2 + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.RebirthPointGain3:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain de Points de Réincarnation de Classe 3 + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.CriticalDamage:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts des Coups Critiques + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.BlessingEffect:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Effet des Bénédictions + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.CatalystDoubleCriticalChance: //TODO
                if (isOnlyEffectValue) return percent(value);
                tempString = "Chance de Catalysation Critique (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            default:
                if (isOnlyEffectValue) return tDigit(value);
                tempString = kind.ToString() + " + " + tDigit(value);
                break;
        }
        return tempString;
    }
    public override string ForgeNameString(EquipmentForgeEffectKind kind, double value)
    {
        switch (kind)
        {
            case EquipmentForgeEffectKind.ReduceRequiredHeroLevel:
                return "Niveau du Héros - " + tDigit(value);
            case EquipmentForgeEffectKind.ReduceRequiredAbility:
                return "Abilité Requise - " + tDigit(value);
            case EquipmentForgeEffectKind.IncreaseProficiencyGain:
                return "Gain de Maîtrise + " + percent(value);
            case EquipmentForgeEffectKind.IncreaseEffect:
                return "Effet d'Équipement + " + percent(value);
        }
        return kind.ToString();
    }
    public override string ForgeEffectString(EquipmentForgeEffectKind kind, double value)
    {
        switch (kind)
        {
            case EquipmentForgeEffectKind.ReduceRequiredHeroLevel:
                return "Niveau du Héros requis pour cet équipement - " + tDigit(value);
            case EquipmentForgeEffectKind.ReduceRequiredAbility:
                return "Points d'Abilité requis pour cet équipement - " + tDigit(value);
            case EquipmentForgeEffectKind.IncreaseProficiencyGain:
                return "Gain de Maîtrise de cet équipement + " + percent(value) + " (Max: " + percent(EquipmentParameter.MaxEffectValue(kind)) + ")";
            case EquipmentForgeEffectKind.IncreaseEffect:
                return "Effet de cet équipement + " + percent(value) + " (Max: " + percent(EquipmentParameter.MaxEffectValue(kind)) + ")";
        }
        return kind.ToString();
    }
    //EquipmentDictionary
    public override (string name, string effect) DictionaryUpgarde(DictionaryUpgradeKind kind)
    {
        string name = "";
        string effect = "";
        switch (kind)
        {
            case DictionaryUpgradeKind.EquipmentProficiencyGainWarrior:
                name = "Maître d'Armes [Guerrier]";
                effect = "Gain de Maîtrise d'Équipement du Guerrier";
                break;
            case DictionaryUpgradeKind.EquipmentProficiencyGainWizard:
                name = "Maître d'Armes [Mage]";
                effect = "Gain de Maîtrise d'Équipement de la Mage";
                break;
            case DictionaryUpgradeKind.EquipmentProficiencyGainAngel:
                name = "Maître d'Armes [Ange]";
                effect = "Gain de Maîtrise d'Équipement de l'Ange";
                break;
            case DictionaryUpgradeKind.EquipmentProficiencyGainThief:
                name = "Maître d'Armes [Voleur]";
                effect = "Gain de Maîtrise d'Équipement du Voleur";
                break;
            case DictionaryUpgradeKind.EquipmentProficiencyGainArcher:
                name = "Maître d'Armes [Archer]";
                effect = "Gain de Maîtrise d'Équipement de l'Archer";
                break;
            case DictionaryUpgradeKind.EquipmentProficiencyGainTamer:
                name = "Maître d'Armes [Dompteuse]";
                effect = "Gain de Maîtrise d'Équipement de la Dompteuse";
                break;
            case DictionaryUpgradeKind.EquipmentDropChance:
                name = "Chasseur d'Equipement";
                effect = "Chance d'Apparition d'Équipement (sauf Unique) ";
                break;
            case DictionaryUpgradeKind.EnchantedEffectChance1:
                name = "Fortune d'Equipement 1";
                effect = "Chance additionnelle d'avoir un 1er enchantement";
                break;
            case DictionaryUpgradeKind.EnchantedEffectChance2:
                name = "Fortune d'Equipement 2";
                effect = "Chance additionnelle d'avoir un 2ème enchantement";
                break;
            case DictionaryUpgradeKind.EnchantedEffectChance3:
                name = "Fortune d'Equipement 3";
                effect = "Chance additionnelle d'avoir un 3ème enchantement";
                break;
        }
        return (name, effect);
    }
    //EquipmentPart
    public override string EquipmentPartName(EquipmentPart part)
    {
        switch (part)
        {
            case EquipmentPart.Weapon:
                return "Arme";
            case EquipmentPart.Armor:
                return "Armure";
            case EquipmentPart.Jewelry:
                return "Bijou";
        }
        return part.ToString();
    }
    public override string EquipmentRarityName(EquipmentRarity rarity)
    {
        switch (rarity)
        {
            case EquipmentRarity.Common:
                return "Commun";
            case EquipmentRarity.Uncommon:
                return "Peu Commun";
            case EquipmentRarity.Rare:
                return "Rare";
            case EquipmentRarity.SuperRare:
                return "Super Rare";
            case EquipmentRarity.Epic:
                return "Épique";
        }
        return rarity.ToString();
    }

    public override string EquipmentSetKindName(EquipmentSetKind kind)
    {
        switch (kind)
        {
            case EquipmentSetKind.Slime:
                return "Collection Slime";
            case EquipmentSetKind.Magicslime:
                return "Collection Slime Magique";
            case EquipmentSetKind.Spider:
                return "Collection Araignée";
            case EquipmentSetKind.Bat:
                return "Collection Chauve-Souris";
            case EquipmentSetKind.Fairy:
                return "Collection Fée";
            case EquipmentSetKind.Fox:
                return "Collection Renard";
            case EquipmentSetKind.Devilfish:
                return "Collection Poisson Démon";
            case EquipmentSetKind.Treant:
                return "Collection Tréant";
            case EquipmentSetKind.Flametiger:
                return "Collection Tigre de Feu";
            case EquipmentSetKind.Unicorn:
                return "Collection Licorne";
        }
        return kind.ToString();
    }

    //Enchant
    public override string EnchantName(EnchantKind kind)
    {
        switch (kind)
        {
            case EnchantKind.OptionAdd:
                return "Parchemin d'Enchantement";
            case EnchantKind.OptionLevelup:
                return "Parchemin de Niveau Supérieur";
            case EnchantKind.OptionLevelMax:
                return "Parchemin de Niveau Maximal";
            case EnchantKind.OptionLottery:
                return "Parchemin de Lotterie";
            case EnchantKind.OptionDelete:
                return "Parchemin de Suppression";
            case EnchantKind.OptionExtract:
                return "Parchemin d'Extraction";
            case EnchantKind.OptionCopy:
                return "Parchemin de Copie";
            case EnchantKind.ExpandEnchantSlot:
                return "Parchemin d'Expansion";
            case EnchantKind.InstantProf:
                return "Parchemin de Maîtrise";
            case EnchantKind.ForgeAdd:
                return "Enclume de Forge";
            case EnchantKind.ForgeDelete:
                return "Parchemin de Suppression [Forge]";
            case EnchantKind.ForgeExtract:
                return "Parchemin d'Extraction [Forge]";
        }
        return kind.ToString();
    }
    //EnchantInfo
    public override string EnchantInformation(EnchantKind kind)
    {
        switch (kind)
        {
            case EnchantKind.OptionAdd:
                return "Ajoute un enchantement à un équipement ayant un [Enchantement Vide].";
            case EnchantKind.OptionLevelup:
                return "Augmente le niveau de l'enchantement d'un objet équipé qui n'est pas au niveau maximal.";
            case EnchantKind.OptionLevelMax:
                return "Augmente le niveau de l'enchantement d'un objet équipé à son maximum.";
            case EnchantKind.OptionLottery:
                return "Randomise la valeur d'un enchantement sur un équipement.";//"Re-lottery an enchanted effect amount of an equipment.";
            case EnchantKind.OptionDelete:
                return "Supprime l'enchantement d'un équipement et le transforme en un [Enchantement Vide].";
            case EnchantKind.OptionExtract:
                return "Extrait l'enchantement d'un équipement et créée un Parchemin d'Enchantement associé. L'effet extrait est supprimé de l'équipement.";
            case EnchantKind.OptionCopy:
                return "Copie l'enchantement d'un équipement et créée un Parchemin d'Enchantement associé. L'enchantement originel est gardé.";
            case EnchantKind.ExpandEnchantSlot:
                return "Augmente le nombre d'enchantements d'un équipement par 1. Max 4 emplacements en tout en dehors de l'Effet de Maîtrise du Voleur.";
            case EnchantKind.InstantProf:
                return "Gagne instantanément de la Maîtrise sur cet équipement pour le héros couramment joué.";
            case EnchantKind.ForgeAdd:
                return "Donne un effet forgé à un équipement ayant un emplacement [Forge Disponible] ou le même type d'effet forgé.";
            case EnchantKind.ForgeDelete:
                return "Supprime un effet forgé d'un équipement et le remplace pat un emplacement [Forge Disponible].";
            case EnchantKind.ForgeExtract:
                return "Extrait l'effet forgé d'un équipement et créée son [Enclume de Forge] associé. L'effet forgé extrait est supprimé de l'équipement.";
        }
        return kind.ToString();
    }
    //Alchemy
    public override (string name, string description) Catalyst(Catalyst catalyst)
    {
        string tempName = "<size=20>";
        string tempDescription = optStr;
        tempDescription += "<size=20><u>Transformations d'Essence Disponibles</u><size=18>";
        for (int i = 0; i < catalyst.essenceProductionList.Count; i++)
        {
            tempDescription += "\n- " + EssenceName(catalyst.essenceProductionList[i].kind);
        }
        tempDescription += "\n\n<size=20><u>Critique</u><size=18>";
        tempDescription += "\n- <color=green>" + percent(catalyst.criticalChance, 3) + "</color> chance de gagner <color=green>" + Material(catalyst.criticalMaterial) + "</color> pour chaque transformation des Essences de ce Catalyseur";
        tempDescription += " ( + " + percent(catalyst.criticalChanceIncrementPerLevel, 3) + " / Nv )";
        double doubleCriticalChance = game.catalystCtrl.catalystDoubleCriticalChance.Value();
        if (doubleCriticalChance > 0)
            tempDescription += "\n- Chance de Catalysation Critique : <color=green>" + percent(doubleCriticalChance) + "</color>";
        tempDescription += "\n\n<size=20><u>" + Basic(BasicWord.LevelupCost) + "</u>";
        tempDescription += "  ( <color=green>+ " + tDigit(catalyst.transaction.LevelIncrement()) + "</color> ) </u><size=18>";
        tempDescription += "\n- " + "Eau Mystérieuse : ";
        if (catalyst.transaction.CanBuy(0)) tempDescription += "<color=green>";
        else tempDescription += "<color=red>";
        tempDescription += tDigit(catalyst.transaction.ResourceValue(0)) + "</color> / ";
        tempDescription += tDigit(catalyst.transaction.Cost(0));
        for (int i = 0; i < catalyst.transaction.materialKindList.Count; i++)
        {
            int count = i;
            tempDescription += "\n- " + Material(catalyst.transaction.materialKindList[count]) + " : ";
            if (catalyst.transaction.CanBuy(1 + count)) tempDescription += "<color=green>";
            else tempDescription += "<color=red>";
            tempDescription += tDigit(catalyst.transaction.ResourceValue(1 + count)) + "</color> / ";
            tempDescription += tDigit(catalyst.transaction.Cost(1 + count));
        }
        switch (catalyst.kind)
        {
            case CatalystKind.Slime:
                tempName = "Catalyste de Slime";
                break;
            case CatalystKind.Mana:
                tempName = "Catalyste de Mana";
                break;
            case CatalystKind.Frost:
                tempName = "Catalyste du Froid";
                break;
            case CatalystKind.Flame:
                tempName = "Catalyste de la Flamme";
                break;
            case CatalystKind.Storm:
                tempName = "Catalyste de la Tempête";
                break;
            case CatalystKind.Soul:
                tempName = "Catalyste de l'Âme";
                break;
            case CatalystKind.Sun:
                tempName = "Catalyste du Soleil";
                break;
            case CatalystKind.Void:
                tempName = "Catalyste du Vide";
                break;
        }
        tempName += "<size=18>\n\n<color=green>Nv " + tDigit(catalyst.level.value) + "</color> / " + tDigit(catalyst.level.maxValue());
        if (catalyst.level.value > 0 && !catalyst.isEquipped) tempName += "\n<color=yellow>Cliquez sur cet icône pour afficher le Convertisseur d'Essence !</color>";
        return (tempName, tempDescription);
    }
    //Essence
    public override string EssenceName(EssenceKind kind)
    {
        switch (kind)
        {
            case EssenceKind.EssenceOfSlime:
                return "Essence de Slime";
            case EssenceKind.EssenceOfLife:
                return "Essence de Vie";
            case EssenceKind.EssenceOfMagic:
                return "Essence de Magie";
            case EssenceKind.EssenceOfCreation:
                return "Essence de Création";
            case EssenceKind.EssenceOfIce:
                return "Essence de Glace";
            case EssenceKind.EssenceOfWinter:
                return "Essence d'Hiver";
            case EssenceKind.EssenceOfFire:
                return "Essence de Feu";
            case EssenceKind.EssenceOfSummer:
                return "Essence d'Été";
            case EssenceKind.EssenceOfThunder:
                return "Essence d'Électricité";
            case EssenceKind.EssenceOfWind:
                return "Essence de Vent";
            case EssenceKind.EssenceOfSpirit:
                return "Essence d'Esprit";
            case EssenceKind.EssenceOfDeath:
                return "Essence de Mort";
            case EssenceKind.EssenceOfLight:
                return "Essence de Lumière";
            case EssenceKind.EssenceOfRebirth:
                return "Essence de Renaissance";
            case EssenceKind.EssenceOfTime:
                return "Essence de Temps";
            case EssenceKind.EssenceOfEternity:
                return "Essence d'Éternité";
        }
        return kind.ToString();
    }
    //AlchemyUpgrade
    public override string AlchemyUpgradeName(AlchemyUpgradeKind kind)
    {
        switch (kind)
        {
            case AlchemyUpgradeKind.Purification:
                return "Purification";
            case AlchemyUpgradeKind.DeeperCapacity:
                return "Capacité Accrue";
            case AlchemyUpgradeKind.CharmedLife:
                return "charme de Vie";
            case AlchemyUpgradeKind.Catalystic:
                return "Super Catalysant";
            case AlchemyUpgradeKind.EssenceHoarder:
                return "Collectionneur d'Essence";
            case AlchemyUpgradeKind.PotentPotables:
                return "Boissons Fortes";
            case AlchemyUpgradeKind.Aurumology:
                return "Aurumologie";
            case AlchemyUpgradeKind.WaterPreservation:
                return "Préservation d'Eau";
            case AlchemyUpgradeKind.MaterialThrift:
                return "Économie de Materiaux";
            case AlchemyUpgradeKind.NitrousExtraction:
                return "Extraction Nitrique";
        }
        return kind.ToString();
    }
    public override string AlchemyUpgradeEffect(AlchemyUpgradeKind kind, double effectValue)
    {
        switch (kind)
        {
            case AlchemyUpgradeKind.Purification:
                return "Gain d'Eau Mystérieuse + " + tDigit(effectValue, 3) + " / " + Basic(BasicWord.Sec);
            case AlchemyUpgradeKind.DeeperCapacity:
                return "Nombre d'empilement max des Objets Utilitaires + " + tDigit(effectValue);
            case AlchemyUpgradeKind.CharmedLife:
                return percent(effectValue) + " chance d'empêcher la comsommation de potions et de pièges";
            case AlchemyUpgradeKind.Catalystic:
                return "Catalystes disponibles + " + tDigit(effectValue);
            case AlchemyUpgradeKind.EssenceHoarder:
                return "Taux de Transformation des Essences + " + percent(effectValue);
            case AlchemyUpgradeKind.PotentPotables:
                return "Effet des potions + " + percent(effectValue);
            case AlchemyUpgradeKind.Aurumology:
                return "Limite d'Or + " + percent(effectValue);
            case AlchemyUpgradeKind.WaterPreservation:
                return "Gain d'Eau Mystérieuse + " + percent(effectValue) + " par extension de limite";
            case AlchemyUpgradeKind.MaterialThrift:
                return "Donne " + percent(effectValue) + " de chance que les composants d'essence ne soient pas consommés lors d'une alchimie";
            case AlchemyUpgradeKind.NitrousExtraction:
                return "Donne 1% de chance de gagner " + tDigit(effectValue) + " Nitro lors d'une alchimie";
        }
        return kind.ToString();
    }

    //Potion
    public override string PotionName(PotionKind kind)
    {
        switch (kind)
        {
            case PotionKind.MinorHealthPotion:
                return "Potion de Santé Mineure";
            case PotionKind.MinorRegenerationPoultice:
                return "Bandage de Régénération Mineur";
            case PotionKind.MinorResourcePoultice:
                return "Bandage de Ressouce Mineur";
            case PotionKind.SlickShoeSolution:
                return "Solution pour Chaussures Glissantes";
            case PotionKind.MinorManaRegenerationPoultice:
                return "Bandage de Régénération de Mana Mineur";
            case PotionKind.MaterialMultiplierMist:
                return "Vaporisateur de Multiplication de Matériau";
            case PotionKind.BasicElixirOfBrawn:
                return "Élixir Basique de Muscle";
            case PotionKind.BasicElixirOfBrains:
                return "Élixir Basique d'Intelligence";
            case PotionKind.BasicElixirOfFortitude:
                return "Élixir Basique de Courage";
            case PotionKind.BasicElixirOfConcentration:
                return "Élixir Basique de Concentration";
            case PotionKind.BasicElixirOfUnderstanding:
                return "Élixir Basique de Compréhension";
            case PotionKind.ChilledHealthPotion:
                return "Potion de Santé Givrée";
            case PotionKind.ChilledRegenerationPoultice:
                return "Bandage de Régénération Givré";
            case PotionKind.FrostyDefensePotion:
                return "Potion de Défense Glaciale";
            case PotionKind.IcyAuraDraught:
                return "Philtre d'Aura Gelée";
            case PotionKind.SlightlyStickySalve:
                return "Salve Collante";
            case PotionKind.SlickerShoeSolution:
                return "Solution pour Chaussures Glissantes +";
            case PotionKind.CoolHeadOintment:
                return "Pommage de Tête Froide";
            case PotionKind.FrostySlayersOil:
                return "Huile du Tueur Glacial";
            case PotionKind.BurningDefensePotion:
                return "Poiton de Défense Brûlante";
            case PotionKind.BlazingAuraDraught:
                return "Philtre d'Aura Embrasée";
            case PotionKind.FierySlayersOil:
                return "Huile du Tueur Enflammé";
            case PotionKind.ElectricDefensePotion:
                return "Potion de Défense Électrique";
            case PotionKind.WhirlingAuraDraught:
                return "Philtre d'Aura Tourbillonante";
            case PotionKind.ShockingSlayersOil:
                return "Huile du Tueur Foudroyant";
            case PotionKind.ThrowingNet:
                return "Filet de Capture";
            case PotionKind.FireRope:
                return "Filet de Feu";
            case PotionKind.IceRope:
                return "Filet de Glace";
            case PotionKind.ThunderRope:
                return "Filet d'Électricité";
            case PotionKind.LightRope:
                return "Filet de Lumière";
            case PotionKind.DarkRope:
                return "Filet des Ténèbres";
            case PotionKind.GuildMembersEmblem:
                return "Emblème de Membre de Guilde";
            case PotionKind.CertificateOfCompetence:
                return "Certificat de Compétence";
            case PotionKind.MasonsTrowel:
                return "Truelle de Maçon";
            case PotionKind.TrappersTag:
                return "Marque du Chasseur";
            case PotionKind.EnchantedAlembic:
                return "Alambique Enchanté";
            case PotionKind.FlorzporbDoll:
                return "Poupée Florzporbe";
            case PotionKind.ArachnettaDoll:
                return "Poupée Aranetta Doll";
            case PotionKind.GuardianKorDoll:
                return "Poupée Gardien Kor";
            case PotionKind.SlimeBadge:
                return "Bagde Slime";
            case PotionKind.MagicslimeBadge:
                return "Badge Slime Magique";
            case PotionKind.SpiderBadge:
                return "Badge Araignée";
            case PotionKind.BatBadge:
                return "Badge Chauve-Souris";
            case PotionKind.FairyBadge:
                return "Badge Fée";
            case PotionKind.FoxBadge:
                return "Badge Renard";
            case PotionKind.DevilfishBadge:
                return "Badge Poisson Démon";
            case PotionKind.TreantBadge:
                return "Badge Tréant";
            case PotionKind.FlametigerBadge:
                return "Badge Tigre de Feu";
            case PotionKind.UnicornBadge:
                return "Badge Licorne";
            case PotionKind.AscendedFromIEH1:
                return "Preuve d'Ascension de IEH1";
            case PotionKind.WarriorsBadge:
                return "Badge du Guerrier";
            case PotionKind.WizardsBadge:
                return "Badge de Mage";
            case PotionKind.AngelsBadge:
                return "Badge de l'Ange";
            case PotionKind.ThiefsBadge:
                return "Badge du Voleur";
            case PotionKind.ArchersBadge:
                return "Badge de l'Archer";
            case PotionKind.TamersBadge:
                return "Badge de la Dompteuse";
            case PotionKind.NostroDoll:
                return "Poupée Nostro";
            case PotionKind.LadyEmeldaDoll:
                return "Poupée Dame Emelda";
            case PotionKind.NariSuneDoll:
                return "Poupée Nari Sune";
            case PotionKind.OctobaddieDoll:
                return "Poupée Octopabo";
            case PotionKind.BananoonDoll:
                return "Poupée Bananoutan";
            case PotionKind.GlorbliorbusDoll:
                return "Poupée Glorbliorbe";
            case PotionKind.DistortionSlimeDoll:
                return "Poupée Gankyū";
        }
        return kind.ToString();
    }
    //PotionConsumeInfo
    public override string PotionConsume(PotionConsumeConditionKind kind, double chance)
    {
        switch (kind)
        {
            case PotionConsumeConditionKind.Nothing://Talisman
                return "Les Talismans ne sont jamais consommés et leur effet est multiplié par leur # de pile";
            case PotionConsumeConditionKind.HpHalf:
                return "Utilisé automatiquement lorsque les PV du héros sont en dessous de 50%";
            case PotionConsumeConditionKind.AreaComplete:
                return optStr + percent(chance, 3) + " chance d'être consommé à chaque fois qu'une zone est commencée";
            case PotionConsumeConditionKind.Defeat:
                return optStr + percent(chance, 3) + " chance d'être consommé à chaque fois qu'un monstre est vaincu";
            case PotionConsumeConditionKind.Move:
                return optStr + percent(chance, 3) + " chance d'être consommé à chaque fois que vous parcouez 10 mètres";
            case PotionConsumeConditionKind.Capture:
                return "Clic droit pour essayer de capturer un monstre";
        }
        return kind.ToString();
    }
    //PotionEffect
    public override string PotionEffect(PotionKind kind, double effectValue, bool isPassive = false)
    {
        switch (kind)
        {
            case PotionKind.MinorHealthPotion:
                return optStr + "Récupère PV + " + tDigit(effectValue) + "</color>";
            case PotionKind.MinorRegenerationPoultice:
                return optStr + "Régénération de PM + " + tDigit(effectValue, 2) + " / " + Basic(BasicWord.Sec) + "</color>";
            case PotionKind.MinorResourcePoultice:
                return optStr + "Gain de Ressources + " + percent(effectValue) + "</color>";
            case PotionKind.SlickShoeSolution:
                return optStr + "Vitesse + " + percent(effectValue) + "</color>";
            case PotionKind.MinorManaRegenerationPoultice:
                return optStr + "Régénération de PM + " + tDigit(effectValue, 2) + " / " + Basic(BasicWord.Sec) + "</color>";
            case PotionKind.MaterialMultiplierMist:
                return optStr + "Augmente le nombre de matériaux récupérés par " + tDigit(effectValue) + "</color>";
            case PotionKind.BasicElixirOfBrawn:
                return optStr + "Dégâts Physiques + " + percent(effectValue) + "</color>";
            case PotionKind.BasicElixirOfBrains:
                return optStr + "Dégâts Magiques + " + percent(effectValue) + "</color>";
            case PotionKind.BasicElixirOfFortitude:
                return optStr + "PV + " + tDigit(effectValue) + "</color>";
            case PotionKind.BasicElixirOfConcentration:
                return optStr + "PM + " + tDigit(effectValue) + "</color>";
            case PotionKind.BasicElixirOfUnderstanding:
                return optStr + "Gain de Maîtrise de Capacité + " + percent(effectValue) + "</color>";
            case PotionKind.ChilledHealthPotion:
                return optStr + "Récupère PV + " + tDigit(effectValue) + "</color>";
            case PotionKind.ChilledRegenerationPoultice:
                return optStr + "Régénération de PV + " + tDigit(effectValue, 2) + " / " + Basic(BasicWord.Sec) + "</color>";
            case PotionKind.FrostyDefensePotion:
                return optStr + "Résistance de Glace + " + percent(effectValue, 2) + "</color>";
            case PotionKind.IcyAuraDraught:
                return optStr + "Génère une aura glaciale autour du héros qui a " + percent(effectValue) + "</color> de chances chaque seconde de donner le débuff " + DebuffName(Debuff.SpdDown) + " aux monstres";
            case PotionKind.SlightlyStickySalve:
                return optStr + "Gain d'Or + " + percent(effectValue) + "</color>";
            case PotionKind.SlickerShoeSolution:
                return optStr + "Vitesse + " + percent(effectValue) + "</color>";
            case PotionKind.CoolHeadOintment:
                return optStr + "Gain d'EXP + " + percent(effectValue) + "</color>";
            case PotionKind.FrostySlayersOil:
                return optStr + "Change le type des capacités en Glace et ajoute " + percent(effectValue) + "</color> de dégâts de Glace en plus";
            case PotionKind.BurningDefensePotion:
                return optStr + "Résistance de Feu + " + percent(effectValue, 2) + "</color>";
            case PotionKind.BlazingAuraDraught:
                return optStr + "Génère une aura flamboyante autour du héros qui a " + percent(effectValue) + "</color> de chances chaque seconde de repousser les monstres";
            case PotionKind.FierySlayersOil:
                return optStr + "Change le type des capacités en Feu et ajoute " + percent(effectValue) + "</color> de dégâts de Feu en plus";
            case PotionKind.ElectricDefensePotion:
                return optStr + "Résistance d'Électricité + " + percent(effectValue, 2) + "</color>";
            case PotionKind.WhirlingAuraDraught:
                return optStr + "Génère une aura électrique autour du héros qui a " + percent(effectValue) + "</color> de chances chaque seconde de donner le débuff " + DebuffName(Debuff.Electric) + " aux monstres";
            case PotionKind.ShockingSlayersOil:
                return optStr + "Change le type des capacités en Électricité et ajoute " + percent(effectValue) + "</color> de dégâts d'Électricité en plus";
            case PotionKind.ThrowingNet:
                return optStr + "Clic droit pour capturer les monstres de <color=green>Type Normal</color>";
            case PotionKind.FireRope:
                return optStr + "Clic droit pour capturer les monstres de <color=green>Type Rouge</color>";
            case PotionKind.IceRope:
                return optStr + "Clic droit pour capturer les monstres de <color=green>Type Bleu</color>";
            case PotionKind.ThunderRope:
                return optStr + "Clic droit pour capturer les monstres de <color=green>Type Jaune</color>";
            case PotionKind.LightRope:
                return optStr + "Clic droit pour capturer les monstres de <color=green>Type Vert</color>";
            case PotionKind.DarkRope:
                return optStr + "Clic droit pour capturer les monstres de <color=green>Type Violet</color>";

            //Talisman
            case PotionKind.GuildMembersEmblem:
                if (isPassive) return "Réduit l'EXP de Guilde requis par niveau de " + percent(effectValue);
                return "Multiplie les Gains d'EXP de Guilde par " + percent(1 + effectValue);
            case PotionKind.CertificateOfCompetence:
                if (isPassive) return "Multiplie les Gains de Maîtrise de Capacité par " + percent(1 + effectValue);
                return "Réduit le Temps de Recharge des Capacités par " + percent(effectValue);
            case PotionKind.MasonsTrowel:
                if (isPassive) return "Augmente le niveau de l'effet des Bâtiments de Ville par " + percent(effectValue);
                return "Augmente les Gains de Matériaux de Ville par " + percent(effectValue);
            case PotionKind.TrappersTag:
                if (isPassive) return "Multiplie les Gains de Points de Domptage par " + percent(1 + effectValue);
                return "Chance de Capture Triple + " + percent(effectValue);
            case PotionKind.FlorzporbDoll:
                if (isPassive) return "Multiplie les Gains d'Or par " + percent(1 + effectValue);
                return "Donne une attaque de Boule de Slime supplémentaire infligeant " + percent(effectValue) + " des dégâts de la Capacité d'Attaque de Base";
            case PotionKind.ArachnettaDoll:
                if (isPassive) return "Limite d'Or + " + percent(effectValue);
                return "Donne une chance de " + percent(System.Math.Min(1, effectValue)) + " d'appliquer le débuff Poison à travers la Capacité d'Attaque de Base";
            case PotionKind.GuardianKorDoll:
                if (isPassive) return "Multiplie les Gains de Maîtrise d'Équipemet par " + percent(1 + effectValue);
                return "Si les dégâts reçus sont éégal ou en dessous de " + percent(System.Math.Min(0.25d, effectValue)) + " des PV, ils sont nullifiés (Max : 25%)";
            case PotionKind.NostroDoll:
                if (isPassive) return "Absorption Physique + " + percent(effectValue);
                return "Augmente la Régénération de PM / sec par " + percent(effectValue) + " des PM max";
            case PotionKind.LadyEmeldaDoll:
                if (isPassive) return "Absorption Magique + " + percent(effectValue);
                return "Dégâts des Capacités infligeant des dégâts + " + percent(effectValue) + " mais leur Consommation de PM + " + percent(4 * effectValue);
            case PotionKind.NariSuneDoll:
                if (isPassive) return "Chance d'Invasion Grosse + " + percent(effectValue) + " au lieu d'une Invasion Normale";
                return "Portée des Capacités + " + percent(effectValue);
            case PotionKind.SlimeBadge:
                if (isPassive) return "PV + " + tDigit(effectValue, 1);
                return "PV + " + percent(effectValue);
            case PotionKind.MagicslimeBadge:
                if (isPassive) return "MDEF + " + tDigit(effectValue, 1);
                return "MDEF + " + percent(effectValue);
            case PotionKind.SpiderBadge:
                if (isPassive) return "DEF + " + tDigit(effectValue, 1);
                return "DEF + " + percent(effectValue);
            case PotionKind.BatBadge:
                if (isPassive) return "ATQ + " + tDigit(effectValue, 1);
                return "ATQ + " + percent(effectValue);
            case PotionKind.FairyBadge:
                if (isPassive) return "MATQ + " + tDigit(effectValue, 1);
                return "MATQ + " + percent(effectValue);
            case PotionKind.FoxBadge:
                if (isPassive) return "PM + " + tDigit(effectValue, 1);
                return "PM + " + percent(effectValue);
            case PotionKind.DevilfishBadge:
                if (isPassive) return "Gain de Pierre + " + percent(effectValue);
                return "Vitesse + " + percent(effectValue);
            case PotionKind.TreantBadge:
                if (isPassive) return "Gain de Crystal + " + percent(effectValue);
                return "Gain d'EXP + " + percent(effectValue);
            case PotionKind.FlametigerBadge:
                if (isPassive) return "Gain de Feuille + " + percent(effectValue);
                return "Gain de Maîtrise d'Équipement + " + percent(effectValue);
            case PotionKind.UnicornBadge:
                if (isPassive) return "VIT + " + tDigit(effectValue, 1);
                return "VIT + " + percent(effectValue);
            case PotionKind.AscendedFromIEH1:
                if (isPassive) return "Rien";
                return "Multiplie les Gains d'EXP par " + percent(1 + effectValue);
            case PotionKind.WarriorsBadge:
                if (isPassive) return "Réduit le Cout de Rang des Capacités du Guerrier par " + percent(effectValue);
                return "Multiplie la Chance de Coup Critique Physique par " + percent(1 + effectValue);//"Warrior's Skill Proficiency Gain + " + percent(effectValue);
            case PotionKind.WizardsBadge:
                if (isPassive) return "Réduit le Cout de Rang des Capacités de la Mage par " + percent(effectValue);
                return "Multiplie la Chance de Coup Critique Magique par " + percent(1 + effectValue);
            case PotionKind.AngelsBadge:
                if (isPassive) return "Réduit le Cout de Rang des Capacités de l'Ange par " + percent(effectValue);
                return "Multiplie les Gains de Maîtrise de Capacité par " + percent(1 + effectValue);
            case PotionKind.ThiefsBadge:
                if (isPassive) return "Réduit le Cout de Rang des Capacités du Voleur par " + percent(effectValue);
                return "Multiplie la Chance d'Apparition d'Équipement par " + percent(1 + effectValue);
            case PotionKind.ArchersBadge:
                if (isPassive) return "Réduit le Cout de Rang des Capacités de l'Archer par " + percent(effectValue);
                return "Dégâts Critiques + " + percent(effectValue);
            case PotionKind.TamersBadge:
                if (isPassive) return "Réduit le Cout de Rang des Capacités de la Dompteuse par " + percent(effectValue);
                return "Gain d'EXP + " + percent(effectValue);
        }
        return kind.ToString();
    }
    //PotionType
    public override string PotionType(PotionType type)
    {
        switch (type)
        {
            case global::PotionType.Health:
                return "Santé";
            case global::PotionType.HealthRegen:
                return "Régénération de Santé";
            case global::PotionType.ResourceGain:
                return "Ressource";
            case global::PotionType.Move:
                return "Mouvement";
            case global::PotionType.Mana:
                return "Mana";
            case global::PotionType.ManaRegen:
                return "Régénération de Mana";
            case global::PotionType.MaterialGain:
                return "Matériau";
            case global::PotionType.PhysicalDamage:
                return "Dégâts Physiques";
            case global::PotionType.MagicalDamage:
                return "Dégâts Magiques";
            case global::PotionType.MaxHP:
                return "PV Max";
            case global::PotionType.MaxMP:
                return "PM Max";
            case global::PotionType.SkillProfGain:
                return "Maîtrise de Capacité";
            case global::PotionType.ElementResistance:
                return "Résistance d'Élément";
            case global::PotionType.Aura:
                return "Aura";
            case global::PotionType.GoldGain:
                return "Or";
            case global::PotionType.ExpGain:
                return "EXP";
            case global::PotionType.SlayerOil:
                return "Huile de Tueur";
            case global::PotionType.Trap:
                return "Piège";
            case global::PotionType.Talisman:
                return "Talisman";
        }
        return type.ToString();
    }
    public override string TalismanRarity(TalismanRarity rarity)
    {
        switch (rarity)
        {
            case global::TalismanRarity.Common:
                return "Commun";
            case global::TalismanRarity.Uncommon:
                return "Peu Commun";
            case global::TalismanRarity.Rare:
                return "Rare";
            case global::TalismanRarity.SuperRare:
                return "Super Rare";
            case global::TalismanRarity.Epic:
                return "Épique";
        }
        return rarity.ToString();
    }

    //SkillName
    public string SkillName(HeroKind heroKind, int id)
    {
        switch (heroKind)
        {
            case HeroKind.Warrior:
                return SkillNameWarrior((SkillKindWarrior)id);
            case HeroKind.Wizard:
                return SkillNameWizard((SkillKindWizard)id);
            case HeroKind.Angel:
                return SkillNameAngel((SkillKindAngel)id);
            case HeroKind.Thief:
                return SkillNameThief((SkillKindThief)id);
            case HeroKind.Archer:
                return SkillNameArcher((SkillKindArcher)id);
            case HeroKind.Tamer:
                return SkillNameTamer((SkillKindTamer)id);
        }
        return "";
    }
    public override string SkillNameWarrior(SkillKindWarrior kind)
    {
        switch (kind)
        {
            case SkillKindWarrior.SwordAttack:
                return "Attaque à l'Épée";
            case SkillKindWarrior.Slash:
                return "Taillade";
            case SkillKindWarrior.DoubleSlash:
                return "Double Taillade";
            case SkillKindWarrior.SonicSlash:
                return "Taillade Éclair";
            case SkillKindWarrior.SwingDown:
                return "Tranchage vers le Bas";
            case SkillKindWarrior.SwingAround:
                return "Tranchage Circulaire";
            case SkillKindWarrior.ChargeSwing:
                return "Tranchage Concentré";
            case SkillKindWarrior.FanSwing:
                return "Tranchage en Éventail";
            case SkillKindWarrior.ShieldAttack:
                return "Attaque de Bouclier";
            case SkillKindWarrior.KnockingShot:
                return "Coup Sonnant";
        }
        return kind.ToString();
    }
    public override string SkillNameWizard(SkillKindWizard kind)
    {
        switch (kind)
        {
            case SkillKindWizard.StaffAttack:
                return "Attaque de Bâton";
            case SkillKindWizard.FireBolt:
                return "Boule de Feu";
            case SkillKindWizard.FireStorm:
                return "Tempête de Feu";
            case SkillKindWizard.MeteorStrike:
                return "Appel de Météore";
            case SkillKindWizard.IceBolt:
                return "Boule de Glace";
            case SkillKindWizard.ChillingTouch:
                return "Toucher Glacial";
            case SkillKindWizard.Blizzard:
                return "Blizzard";
            case SkillKindWizard.ThunderBolt:
                return "Boule de Foudre";
            case SkillKindWizard.DoubleThunderBolt:
                return "Double boule de Foudre";
            case SkillKindWizard.LightningThunder:
                return "Foudroiement";
        }
        return kind.ToString();
    }
    public override string SkillNameAngel(SkillKindAngel kind)
    {
        switch (kind)
        {
            case SkillKindAngel.WingAttack:
                return "Attaque d'Aile";
            case SkillKindAngel.WingShoot:
                return "Lancer de Plumes";
            case SkillKindAngel.Heal:
                return "Soin";
            case SkillKindAngel.GodBless:
                return "Béni des Dieux";
            case SkillKindAngel.MuscleInflation:
                return "Gonflement de Muscle";
            case SkillKindAngel.MagicImpact:
                return "Impact Magique";
            case SkillKindAngel.ProtectWall:
                return "Mur de Protection";
            case SkillKindAngel.Haste:
                return "Célérité Accrue";
            case SkillKindAngel.WingStorm:
                return "Temp^te de Plumes";
            case SkillKindAngel.HolyArch:
                return "Arche Sainte";
        }
        return kind.ToString();
    }
    public override string SkillNameThief(SkillKindThief kind)
    {
        switch (kind)
        {
            case SkillKindThief.DaggerAttack:
                return "Attaque de Dague";
            case SkillKindThief.Stab:
                return "Poignardement";
            case SkillKindThief.KnifeToss:
                return "Lancer de Couteau";
            case SkillKindThief.LuckyBlow:
                return "Coup Chanceux";
            case SkillKindThief.SpreadToss:
                return "Lancer Étendu";
            case SkillKindThief.ShadowStrike:
                return "Cou de l'Ombre";
            case SkillKindThief.SneakyStrike:
                return "Coup Furtif";
            case SkillKindThief.Pilfer:
                return "Chapardage";
            case SkillKindThief.DarkWield:
                return "Maniement Ténébreux";
            case SkillKindThief.Assassination:
                return "Assassinat";
        }
        return kind.ToString();
    }
    public override string SkillNameArcher(SkillKindArcher kind)
    {
        switch (kind)
        {
            case SkillKindArcher.ArrowAttak:
                return "Attaque de Flèches";
            case SkillKindArcher.PiercingArrow:
                return "Flèche Perçante";
            case SkillKindArcher.BurstArrow:
                return "Volée de Flèches";
            case SkillKindArcher.Multishot:
                return "Tir Multiple";
            case SkillKindArcher.ShockArrow:
                return "Flèche Électrique";
            case SkillKindArcher.FrozenArrow:
                return "Flèche Glaciale";
            case SkillKindArcher.ExplodingArrow:
                return "Flèche Explosive";
            case SkillKindArcher.ShiningArrow:
                return "Flèche Lumineuse";
            case SkillKindArcher.GravityArrow:
                return "Flèche de Gravité";
            case SkillKindArcher.Kiting:
                return "Kiting";
        }
        return kind.ToString();
    }
    public override string SkillNameTamer(SkillKindTamer kind)
    {
        switch (kind)
        {
            case SkillKindTamer.SonnetAttack:
                return "Attaque Sonore";
            case SkillKindTamer.AttackingOrder:
                return "Ordre d'Attaque";
            case SkillKindTamer.RushOrder:
                return "Ordre de Vitesse";
            case SkillKindTamer.DefensiveOrder:
                return "Ordre Défensif";
            case SkillKindTamer.SoothingBallad:
                return "Ballade Calmante";
            case SkillKindTamer.OdeOfFriendship:
                return "Ode à l'Amitié";
            case SkillKindTamer.AnthemOfEnthusiasm:
                return "Hymne à l'Entousiasme";
            case SkillKindTamer.FeedChilli: //TODO
                return "Feed Chilli";
            case SkillKindTamer.BreedingKnowledge:
                return "Connaissance en Domptage";
            case SkillKindTamer.TuneOfTotalTaming:
                return "Mélodie de Domptage Total";
        }
        return kind.ToString();
    }

    public override string SkillEffect(EffectKind effect)
    {
        switch (effect)
        {
            case EffectKind.PhysicalDamage:
                return "Dégâts Physiques";
            case EffectKind.FireDamage:
                return "Dégâts de Feu";
            case EffectKind.IceDamage:
                return "Dégâts de Glace";
            case EffectKind.ThunderDamage:
                return "Dégâts d'Électricité";
            case EffectKind.LightDamage:
                return "Dégâts de Lumière";
            case EffectKind.DarkDamage:
                return "Dégâts des Ténèbres";
            case EffectKind.Heal:
                return "Soigne";
            case EffectKind.DebuffKind:
                return "Débuff";
            case EffectKind.DebuffChance:
                return "Chance de Débuff";
            case EffectKind.MPGain:
                return "Gain de PM";
            case EffectKind.MPConsumption:
                return "Consommation de PM";
            case EffectKind.Cooltime:
                return "Temps d'Utilisation";
            case EffectKind.Range:
                return "Portée";
            case EffectKind.EffectRange:
                return "Portée de l'Effet";
        }
        return effect.ToString();
    }
    //バフ
    public override string BuffName(Buff kind)
    {
        switch (kind)
        {
            case Buff.HpUp:
                return "PV Max";
            case Buff.AtkUp:
                return "ATQ";
            case Buff.MatkUp:
                return "MATQ";
            case Buff.DefMDefUp:
                return "DEF & MDEF";
            case Buff.SpdUp:
                return "VIT";
            case Buff.MoveSpeedUp:
                return "Vitesse";
            case Buff.GoldUp:
                return "Gain d'Or";
            case Buff.SkillLevelUp:
                return "Niveau de Capacité";
        }
        return kind.ToString();
    }
    //デバフ
    public override string DebuffName(Debuff kind)
    {
        switch (kind)
        {
            case Debuff.AtkDown:
                return "Réduction d'ATQ";
            case Debuff.MatkDown:
                return "Réduction de MATQ";
            case Debuff.DefDown:
                return "Réduction de DEF";
            case Debuff.MdefDown:
                return "Réduction de MDEF";
            case Debuff.SpdDown:
                return "Réduction de VIT";
            case Debuff.Stop:
                return "Gel";
            case Debuff.Electric:
                return "Electrifié";
            case Debuff.Poison:
                return "Poison";
            case Debuff.Death:
                return "Mort Subite";
            case Debuff.Knockback:
                return "Poussée";
            case Debuff.FireResDown:
                return "Réduction de la Résistance au Feu";
            case Debuff.IceResDown:
                return "Réduction de la Résistance à la Glace";
            case Debuff.ThunderResDown:
                return "Réduction de la Résistance à l'Électricité";
            case Debuff.LightResDown:
                return "Réduction de la Résistance à la Lumière";
            case Debuff.DarkResDown:
                return "Réduction de la Résistance aux Ténèbres";
            case Debuff.Gravity:
                return "Gravité";
            case Debuff.MaxMPDown:
                return "Réduction des PM Max";
            case Debuff.MPAspiration:
                return "Drain de PM";
        }
        return kind.ToString();
    }
    //Stance未
    public override (string name, string effect) Stance(Stance stance)
    {
        string tempName = "Normal";
        string tempEffect = "";
        switch (stance.heroKind)
        {
            case HeroKind.Warrior:
                switch ((WarriorStanceKind)stance.id)
                {
                    case WarriorStanceKind.Attack:
                        tempName = "Attaque";
                        tempEffect = "Dégâts de l'Attaque à l'Épée + " + percent(stance.effectValueBuff);
                        break;
                    case WarriorStanceKind.Reach:
                        tempName = "Portée";
                        tempEffect = "Portée de l'Attaque à l'Épée : " + meter(stance.effectValueBuff);
                        break;
                    case WarriorStanceKind.Knock:
                        tempName = "Poussée";
                        tempEffect = "Ajoute un effet de Poussée à l'Attaque à l'Épée";
                        break;
                }
                break;
            case HeroKind.Wizard:
                switch ((WizardStanceKind)stance.id)
                {
                    case WizardStanceKind.Fire:
                        tempName = "Feu";
                        tempEffect = "Change le type de l'Attaque au Bâton en Feu";
                        break;
                    case WizardStanceKind.Ice:
                        tempName = "Glace";
                        tempEffect = "Change le type de l'Attaque au Bâton en Glace";
                        break;
                    case WizardStanceKind.Thunder:
                        tempName = "Électricité";
                        tempEffect = "Change le type de l'Attaque au Bâton en Électricité";
                        break;
                }
                break;
            case HeroKind.Angel:
                break;
            case HeroKind.Thief:
                break;
            case HeroKind.Archer:
                break;
            case HeroKind.Tamer:
                break;
        }
        return (tempName, tempEffect);
    }
    //GuildAbility
    public override string GuildAbilityName(GuildAbilityKind kind)
    {
        switch (kind)
        {
            case GuildAbilityKind.GlobalSkillSlot:
                return "Imitiation";
            case GuildAbilityKind.EquipmentInventory:
                return "Collection";
            case GuildAbilityKind.EnchantInventory:
                return "Enchantement";
            case GuildAbilityKind.PotionInventory:
                return "Alchimie";
            case GuildAbilityKind.MysteriousWater:
                return "Purification";
            case GuildAbilityKind.StoneGain:
                return "Minage";
            case GuildAbilityKind.CrystalGain:
                return "Synthèse";
            case GuildAbilityKind.LeafGain:
                return "Cueillette";
            case GuildAbilityKind.GuildExpGain:
                return "Entrainement";
            case GuildAbilityKind.SkillProficiency:
                return "Étude";
            case GuildAbilityKind.Trapping:
                return "Capture";
            case GuildAbilityKind.EquipmentProficiency:
                return "Forge";
            case GuildAbilityKind.PhysicalAbsorption:
                return "Protection";
            case GuildAbilityKind.MagicalAbsoption:
                return "Dispersion";
            case GuildAbilityKind.UpgradeCost:
                return "Financement";
            case GuildAbilityKind.MaterialDrop:
                return "Découverte";
            case GuildAbilityKind.NitroCap:
                return "Course";
            case GuildAbilityKind.GoldCap:
                return "Investissement";
            case GuildAbilityKind.GoldGain:
                return "Monétisation";
            case GuildAbilityKind.ExpGain:
                return "Apprentissage";
        }
        return kind.ToString();
    }
    //GuildAbilityEffect
    public override string GuildAbilityEffect(GuildAbilityKind kind, double effectValue)
    {
        string tempString = kind.ToString() + " + " + tDigit(effectValue);
        switch (kind)
        {
            case GuildAbilityKind.StoneGain:
                return "Gain de Pierre + " + percent(effectValue);
            case GuildAbilityKind.CrystalGain:
                return "Gain de Cristal + " + percent(effectValue);
            case GuildAbilityKind.LeafGain:
                return "Gain de Feuille + " + percent(effectValue);
            case GuildAbilityKind.EquipmentInventory:
                return "Inventaire d'Équipement + " + tDigit(effectValue);
            case GuildAbilityKind.EnchantInventory:
                return "Inentaire d'Enchantement + " + tDigit(effectValue);
            case GuildAbilityKind.PotionInventory:
                return "Inventaire d'Utilitaire + " + tDigit(effectValue);
            case GuildAbilityKind.GlobalSkillSlot:
                return "Emplacement de Capacité Global + " + tDigit(effectValue);
            case GuildAbilityKind.MysteriousWater:
                return "Gain d'Eau Mystérieuse + " + percent(effectValue);
            case GuildAbilityKind.GuildExpGain:
                return "Gain d'EXP de Guilde + " + percent(effectValue);
            case GuildAbilityKind.SkillProficiency:
                return "Multiplication des Gains de Maîtrise de Capacité par " + percent(1 + effectValue);
            case GuildAbilityKind.Trapping:
                return "Chance de Capture Double + " + percent(effectValue);
            case GuildAbilityKind.EquipmentProficiency:
                return "Multiplication des Gains de Maîtrise d'Équipement par " + percent(1 + effectValue);
            case GuildAbilityKind.PhysicalAbsorption:
                return "Absorption Physique + " + percent(effectValue);
            case GuildAbilityKind.MagicalAbsoption:
                return "Absorption Magique + " + percent(effectValue);
            case GuildAbilityKind.UpgradeCost:
                return "Réduction du Coût des améliorations Générales par " + percent(effectValue);
            case GuildAbilityKind.MaterialDrop:
                return "Gain de Matériaux + " + tDigit(effectValue);
            case GuildAbilityKind.NitroCap:
                return "Limite de Nitro + " + tDigit(effectValue);
            case GuildAbilityKind.GoldCap:
                return "Multiplication de la Limite d'Or par " + percent(1 + effectValue);
            case GuildAbilityKind.GoldGain:
                return "Multiplication des Gains d'Or par " + percent(1 + effectValue);
            case GuildAbilityKind.ExpGain:
                return "Multiplication des Gaindd'EXP par " + percent(1 + effectValue);
        }
        return tempString;
    }
    public override string DailyQuestRarityName(DailyQuestRarity rarity)
    {
        switch (rarity)
        {
            case DailyQuestRarity.Common:
                return "Commun";
            case DailyQuestRarity.Uncommon:
                return "Peu Commun";
            case DailyQuestRarity.Rare:
                return "Rare";
            case DailyQuestRarity.SuperRare:
                return "Super Rare";
            case DailyQuestRarity.Epic:
                return "Épique";
        }
        return rarity.ToString();
    }
    //Quest
    public override (string name, string client, string description, string condition, string reward, string unlock) Quest(QUEST quest)
    {
        QuestKind kind = quest.kind;
        QuestKindGlobal kindGlobal = quest.kindGlobal;
        QuestKindDaily kindDaily = quest.kindDaily;
        QuestKindTitle kindTitle = quest.kindTitle;
        QuestKindGeneral kindGeneral = quest.kindGeneral;
        HeroKind heroKind = quest.heroKind;
        string name = "";
        string client = "";
        string description = "";
        string condition = "";//特殊な場合のみ追加
        string reward = "";
        string unlock = "";
        switch (kind)
        {
            case QuestKind.Global:
                switch (kindGlobal)
                {
                    case QuestKindGlobal.AbilityVIT:
                        name = "Tutorial 1 : Basic Training";
                        client = "Hitan";
                        description = "Welcome to Incremental Epic Hero 2! First, to get tougher, assign 1 <color=orange>Ability Point (AP)</color> to <color=orange>VTL</color>. VTL is the most basic ability, which boosts your HP, DEF and MDEF. You gain 1 AP every time you level up. \n<color=yellow>- For more information about ability points, check out the Help in top left > [Ability].</color>";
                        condition = "Assign 1 AP to VTL";
                        break;
                    case QuestKindGlobal.ClearGeneralQuest:
                        name = "Tutorial 2 : General Quest";
                        client = "Hitan";
                        description = "There are four types of quests: <color=orange>Global</color>, <color=orange>Daily</color>, <color=orange>Title</color> and <color=orange>General</color>. The Global Quest is the main story of this game and progresses with all guild members. Title and General Quest are unique to each class. Try completing the first <color=orange>General Quest</color>!\n<color=yellow>- For more information about quests, check out the Help in top left > [Quest].</color>";
                        condition = "Complete the first General Quest";
                        reward = "Unleash Tab [ Skill ]";
                        break;
                    case QuestKindGlobal.ClearTitleQuest:
                        name = "Tutorial 3 : Title Quest";
                        client = "Hitan";
                        description = "Great job! Next, <color=orange>Title Quests</color> are special quests which, when completed, award Titles. These titles have unique effects. Try completing the first Title Quest! Keep in mind that you can only accept at most 3 quests between Title and General at once. You can increase the limit later on in the game. Global and Daily Quests are not affected by this limit.\n<color=yellow>- For more information about quests, check out the Help in top left > [Quest].</color>";
                        condition = "Complete the first Title Quest";
                        reward = "Unleash Tab [ Upgrade ]";
                        break;
                    case QuestKindGlobal.UpgradeResource:
                        name = "Tutorial 4 : Upgrade";
                        client = "Hitan";
                        description = "In the <color=orange>Upgrade</color> tab, you can buy various upgrades with gold to improve your stats! Try buying <color=orange>Resource Gain</color> upgrades!\n<color=yellow>- For more information about upgrades, check out the Help in top left > [Upgrade].</color>";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 25";
                        reward = "Unleash Upgrade [ Resource Gain 2 ]\n- Unleash General 2 Upgrade Tab\n- Unleash Menu [ Equip ]";
                        break;
                    case QuestKindGlobal.Equip:
                        name = "Tutorial 5 : Equipment";
                        client = "Hitan";
                        description = "While you are defeating monsters, you have a very low chance for them to drop <color=orange>Equipment</color> after they are defeated. When you get one, please bring it to me! You can equip it by dragging and dropping it to an open equipment in the <color=orange>Equip</color> tab." +
                            " After you get one, check out the <color=orange>Dictionary</color> in the Equip tab. This will show you all of the equipment you've looted so far!  In here you'll see that there are upgrades. These will help increase the heroes <color=orange>Equipment Proficiency Gain</color>, which lowers the required time to level up equipment.\n<color=yellow>- For more information about Equips and the Dictionary, check out the Help > [Equip].</color>";
                        condition = "Get any Equipment";
                        reward = "Unleash Tab [ Lab ]";
                        break;
                    case QuestKindGlobal.Alchemy:
                        name = "Tutorial 6 : Alchemy";
                        client = "Hitan";
                        description = optStr + "While you were out a guild member recently found some <color=orange>Mysterious Water</color> and set up a <color=orange>Lab</color>. You'll meet her soon enough, but for now, let's begin experimenting. Oh, you're not familiar with alchemy? Let me explain."
                            + " To alchemize you first need to go to the lab and make a Catalyst. To make your first catalyst all you need to do is get some <color=orange>Oil of Slime</color>, collect <color=orange>3 Mysterious Water</color> and use that to make a <color=orange>Slime Catalyst</color>. After that, you need to make an essence."
                            + " Essences are the raw ingredients used to make potions. To start, you need to pour at least 0.1 Mysterious Water into an essence of a catalyst you've selected to make the catalyst start producing essence. Let's try it with <color=orange>Essence of Slime</color>."
                            + " Once that's finished all you have to do is look at <color=orange>[Mix Potion]</color>, and click the icon you want to make. Simple isn't it?"
                            + " Now go play in the lab and don't forget to keep increasing your Mysterious Water Cap, refining your Catalyst, and upgrading your lab with the alchemy points you receive.\n<color=yellow>- For more information, Help > [Lab].</color>";
                        condition = "Produce " + PotionName(PotionKind.MinorHealthPotion);
                        reward = "EXP Gain Blessing (Duration 15 mins)\n- Unleash Tab [ Guild ] [ Bestiary ]";
                        break;
                    case QuestKindGlobal.Guild:
                        name = "Tutorial 7 : Guild";
                        client = "Hitan";
                        description = "To increase guild member limit, <color=orange>get Guild Lv 5!</color> Then you can select a new hero, Wizard, to play. You can also acquire various abilities in the guild tab. Guild EXP is gained through Hero leveling, which will provide guild ability points to spend." +
                            "\n- To start with your Heroes will work independently, but as you progress in the game they will learn to cooperate more. The <color=orange>Imitating</color> guild ability will give you a <color=orange>Emplacement de Capacité Global</color>, which allows a Hero to modify their play slightly by equipping a skill learned by one of the other Heroes. You may need to adjust your Hero's default <color=orange>Combat Range</color> so they move close enough to use the borrowed skill." +
                            "\n<color=yellow>- For more information, Help > [Guild].</color>";
                        condition = "Guild Lv 5";
                        reward = "Unleash Tab [ Town ] [ Shop ]";
                        break;
                    case QuestKindGlobal.Town:
                        name = "Tutorial 8 : Town";
                        client = "Hitan";
                        description = optStr + "Now you can go to <color=orange>Town</color> tab." +
                            " There are various buildings in the town." +
                            " You can improve buildings with Town Materials that you gain every time you clear any area ( you can see it in the area info )." +
                            " Dungeons give more Town Materials when you clear it." +
                            " Like skills, buildings have Rank and Level. The level cap increases by 20 per rank." +
                            " To understand more, <color=orange>let's raise Cartographer's level to 5.</color>" +
                            " Then you will be able to go to another region in the world!\n<color=yellow>- For more information, Help > [Town].</color>"
                            ;
                        condition = "Building [ Cartographer ] Lv 5";
                        reward = "EXP Gain Blessing (Duration 30 mins)";
                        break;
                    case QuestKindGlobal.Research:
                        name = "Tutorial 9 : Town Research";
                        client = "Hitan";
                        description = optStr + "While we are in the town, each building has three different <color=orange>researchable effects</color>. You can speed up the research speed by gaining more resources. <color=orange>Let's research Cartographer's Leaf Research. This will provide an additional Town Material per clear</color>, which can be extremely useful in gathering town materials to level up buildings in the town!\n<color=yellow>- For more information, Help > [Town].</color>"
                            ;
                        condition = "Cartographer's Leaf Research Lv 1";
                        reward = "Gold Gain Blessing (Duration 30 mins)\n-Unleash Tab [ Rebirth ]";
                        break;
                    case QuestKindGlobal.Rebirth:
                        name = "Tutorial 10 : Rebirth";
                        client = "Hitan";
                        description = optStr + "It's now time for a <color=orange>Rebirth</color>. There are multiple tiers of rebirthing. But for now, let's get started on Tier 1. <color=orange>Get to Hero Level 100</color> and click on the Rebirth Tab, then click on 'Rebirth'." +
                            " Don't forget to apply some upgrades after rebirthing, especially the <color=orange>EXP Multiplier</color>. \n<color=yellow>- For more information, Help > [Rebirth].</color>"; ;
                        condition = "Perform Tier 1 Rebirth of any hero";
                        reward = "EXP Gain Blessing (Duration 30 mins)\n- Unleash Tab [ Challenge ]";
                        break;
                    case QuestKindGlobal.Challenge:
                        name = "Tutorial 11 : Challenge";
                        client = "Hitan";
                        description = optStr + "Oh, looks like a horrible monster has emerged! Go to <color=orange>Challenge</color> tab to defeat <color=orange>Florzporb</color>." +
                            " On Raid Boss Battle, all heroes that are currently active will join the battle." +
                            " Since you have rebirthed, you can now get Proof of Rebirth title by the quest, which enables to activate the hero even in background." +
                            " The boss monster is very powerful, so gather active guild members to fight together and prepare well before taking it on!\n<color=yellow>- For more information, Help > [Challenge].</color>";
                        condition = "Complete Raid Boss Battle [ Florzporb Lv 100 ]";
                        reward = "Unleash Tab [ Expedition ]\n- Unlock Auto Ability Point Adder";
                        break;
                    case QuestKindGlobal.Expedition:
                        name = "Tutorial 12 : Expedition";
                        client = "Hitan";
                        description = optStr + "You have successfully unlocked the ability to send your pets out on expeditions! If you head over to the Expedition tab in the menu, you will be able to choose which pets you want to set for your first adventuring team. After that, you may choose your expedition by pulling down the drop-down menu and selecting one of the expeditions for acquiring town materials. Choose your duration and then click start. Return here once you've completed your first expedition!\n<color=yellow>- For more information, Help > [Expedition].</color>";
                        condition = "Complete any expedition once";
                        reward = "Unleash Tab [ World Ascension ]\n- Unlock 1 Expedition Team";
                        break;
                    case QuestKindGlobal.WorldAscension:
                        name = "Tutorial 13 : World Ascension";
                        client = "Hitan";
                        description = optStr + "Okay, the next tutorial is... huh? You are thinking that this is a too long tutorial? Come on, this is only the beginning of this game so far. Very exciting, isn't it?" +
                            " Now, though, it will be a while before you achieve the next goal, <color=orange>World Ascension</color>. Let's try to complete the milestones in World Ascension Tab and perform the World Ascension. Various things in this world will reset and hence further dimensional ascension will occur in this game." +
                            " It is up to you when you want to World Ascension!\n<color=yellow>- For more information, Help > [World Ascension].</color>";
                        condition = "Perform World Ascension Tier 1 once";
                        reward = "Emplacement d'Inventaire d'Équipement + 10\n- Emplacement d'Inventaire d'Enchantement + 5\n- Utility Inventory Slot + 5";
                        break;
                    case QuestKindGlobal.AreaPrestige:
                        name = "Tutorial 14 : Area Prestige";
                        client = "Hitan";
                        description = optStr + "Congratulations! After World Ascension, every area of the world also has a chance to prestige. You can earn <color=orange>Area Prestige Point</color> according to its area clear #. See the next clear # to earn points in area info." +
                            " Once you increase <color=orange>[ Area Prestige ]</color> upgrade's level, you can change the difficulty of its area. The unique equipment drop chance and the reward amount increases according to the difficulty, while the monster's level and wave # to clear increases too." +
                            " You can also try the same missions in the area of different difficulty, so you can earn another Epic Coin and Mission Milestone Count as well.\n<color=yellow>- For more information, Help > [World Map].</color>";
                        condition = "Area Prestige Upgrade of " + AreaName(AreaKind.SlimeVillage) + " Area 1 [ Area Prestige ] Lv 1";
                        break;

                    //Upgrade
                    case QuestKindGlobal.Upgrade1:
                        name = "To Further Stage 1";
                        client = "Yuni";
                        description = "You know Resources such as blue stones are useful for ranking up skills and expanding the gold cap. You can improve resource gain in the Upgrade tab. To get resources more efficiently, get Resource Gain 1 to Lv 50!";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 50";
                        reward = "Unleash Upgrade [ Resource Gain 3 ]" +
                            "\n- Upgrade File + 5";
                        break;
                    case QuestKindGlobal.Upgrade2:
                        name = "To Further Stage 2";
                        client = "Yuni";
                        description = "Good job! To further stage, get Resource Gain 1 to Lv 100!";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 100";
                        reward = "Unleash Upgrade [ Resource Gain 4 ]" +
                            "\n- Upgrade File + 5";
                        break;
                    case QuestKindGlobal.Upgrade3:
                        name = "To Further Stage 3";
                        client = "Yuni";
                        description = "Great job! To further stage, get Resource Gain 1 to Lv 150!";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 150";
                        reward = "Unleash Upgrade [ Resource Gain 5 ]" +
                            "\n- Upgrade File + 5";
                        break;
                    case QuestKindGlobal.Upgrade4:
                        name = "To Further Stage 4";
                        client = "Yuni";
                        description = "Excellent job! To further stage, get Resource Gain 1 to Lv 200!";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 200";
                        reward = "Unleash Upgrade [ Resource Gain 6 ]" +
                            "\n- Upgrade File + 5";
                        break;
                    case QuestKindGlobal.Upgrade5:
                        name = "To Further Stage 5";
                        client = "Yuni";
                        description = "Amazing job! To further stage, get Resource Gain 1 to Lv 250!";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 250";
                        reward = "Unleash Upgrade [ Resource Gain 7 ]" +
                            "\n- Upgrade File + 5";
                        break;
                    case QuestKindGlobal.Upgrade6:
                        name = "To Further Stage 6";
                        description = "Awesome job! To further stage, get Resource Gain 1 to Lv 300!";
                        client = "Yuni";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 300";
                        reward = "Unleash Upgrade [ Resource Gain 8 ]" +
                            "\n- Upgrade File + 5";
                        break;
                    case QuestKindGlobal.Upgrade7:
                        name = "To Further Stage 7";
                        client = "Yuni";
                        description = "Wonderful job! To further stage, get Resource Gain 1 to Lv 400!";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 400";
                        reward = "Unleash Upgrade [ Resource Gain 9 ]" +
                            "\n- Upgrade File + 5";
                        break;
                    case QuestKindGlobal.Upgrade8:
                        name = "To Further Stage 8";
                        client = "Yuni";
                        description = "Crazy job! To further stage, get Resource Gain 1 to Lv 500!";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 500";
                        reward = "Unleash Upgrade [ Resource Gain 10 ]" +
                            "\n- Upgrade File + 5";
                        break;
                    case QuestKindGlobal.Upgrade9:
                        name = "To Further Stage 9";
                        client = "Yuni";
                        description = "Terrific job! To further stage, get Resource Gain 1 to Lv 600!";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 600";
                        reward = "Unleash Upgrade [ Resource Gain 11 ]" +
                            "\n- Upgrade File + 5";
                        break;
                    case QuestKindGlobal.Upgrade10:
                        name = "To Further Stage 10";
                        client = "Yuni";
                        description = "Fantastic job! To further stage, get Resource Gain 1 to Lv 700!";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 700";
                        reward = "Unleash Upgrade [ Resource Gain 12 ]" +
                            "\n- Upgrade File + 5";
                        break;
                    case QuestKindGlobal.Upgrade11:
                        name = "To Further Stage 11";
                        client = "Yuni";
                        description = "Fascinating job! To further stage, get Resource Gain 1 to Lv 800!";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 800";
                        reward = "Unleash Upgrade [ Resource Gain 13 ]" +
                            "\n- Upgrade File + 5";
                        break;
                    case QuestKindGlobal.Upgrade12:
                        name = "To Further Stage 12";
                        client = "Yuni";
                        description = "Incredible job! To further stage, get Resource Gain 1 to Lv 900!";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 900";
                        reward = "Unleash Upgrade [ Resource Gain 14 ]" +
                            "\n- Upgrade File + 5";
                        break;
                    case QuestKindGlobal.Upgrade13:
                        name = "To Further Stage 13";
                        client = "Yuni";
                        description = "Cosmic job! To further stage, get Resource Gain 1 to Lv 1000!";
                        condition = "Upgrade [ Resource Gain 1 ] Lv 1000";
                        reward = "Unleash Upgrade [ Resource Gain 15 ]" +
                            "\n- Upgrade File + 5";
                        break;

                    case QuestKindGlobal.Nitro1:
                        name = "How to be a Nitro Booster Geek 1";
                        client = "Gnomish Engineer, Asgabit Tinkerbait";
                        description = "What's this? Why are you interrupting me? Can't you see that I'm busy here? Oh, you're curious about Nitro, are you? Have you ever even tried it before? Go ahead and use some Nitro (The TNT bomb icon at the top of your screen) before bothering me again.";
                        condition = "Turn on Nitro Booster";
                        break;
                    case QuestKindGlobal.Nitro2:
                        name = "How to be a Nitro Booster Geek 2";
                        client = "Gnomish Engineer, Asgabit Tinkerbait";
                        description = "Who is it?! Oh, it's you again... You tried out the Nitro, did you? Pretty great stuff. I use it when I need to focus and finish building my contraptions and doodads, but I suppose it works for adventurers like you as well. Tell you what, come see me again after you've burned through around 5000 of the stuff and I'll show you how you can carry more of it.";
                        condition = "Total Nitro consumed : " + tDigit(main.S.nitroConsumed) + " / 5000";
                        reward = "Nitro Cap + 1000";
                        break;
                    case QuestKindGlobal.Nitro3:
                        name = "How to be a Nitro Booster Geek 3";
                        client = "Gnomish Engineer, Asgabit Tinkerbait";
                        description = "You see a blur whizzing about the workshop, before it finally settles into the image of a curmudgeonly, old gnomish man. \"Who are you and why are you in my workshop?!\" He adjusts the seventeen lenses of his strange spectacle headpiece before examining you again. \"Oh, hello there. So you've used a bit more Nitro than before have you? As you have just seen, I'm quite fond of it myself. Oh you want to know how to carry more Nitro? Alright, I'll give you a expansion for it after you've burned through 30,000 again, okay? Now if you'll please leave, I have work to do.\"";
                        condition = "Total Nitro consumed : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(30000);
                        reward = "Nitro Cap + 2000";
                        break;
                    case QuestKindGlobal.Nitro4:
                        name = "How to be a Nitro Booster Geek 4";
                        client = "Gnomish Engineer, Asgabit Tinkerbait";
                        description = "A large explosion can be heard coming from a rickety looking workshop. Peering inside, you are surprised to see that the facility doesn't appear to have any indications that an explosion just occurred there. As you enter, you are greeted by a panting, eccentric, old gnome. \"Whew, experiment Z17S34.1 was a failure. Excellent, excellent. Alright...\" He lifts his head up from a journal, locking eyes with you in a sudden jolt of surprise. \"Oh sulphurous stalactites!! Don't sneak up on an elderly fellow like that. Whew... my heart... look if you're here for another Nitro expansion, just go burn through another " + tDigit(150000) + " and I'll give you another. If you have nothing else, please leave.\" He then ignores you as he carries on writing in his journal.";
                        condition = "Total Nitro consumed : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(150000);
                        reward = "Nitro Cap + 3000";
                        break;
                    case QuestKindGlobal.Nitro5:
                        name = "How to be a Nitro Booster Geek 5";
                        client = "Gnomish Engineer, Asgabit Tinkerbait";
                        description = "As you approach the gnomish workshop, a blur whizzes by you, trailing off into building. Then it whizzes again back out, stopping abruptly just two feet in front of you. \"You've returned I see. Sorry, but no one is allowed in my workshop at the moment. I'm on the brink of incredible discovery! If you want another Nitro expansion, I'm too busy to help you, so beat it.\" Your head droops a bit at hearing his words and you begin to walk away. \"Oh fine, fine. Don't be that way. Go burn through " + tDigit(500000) + " of Nitro and I'll give you another expansion. I can't keep doing this forever, though, so don't expect me to make many more exceptions for you.\" There is a brief gush of wind as the figure of the tiny gnome whooshes away, leaving a trail leading back into the workshop, ending with a loud slamming of the workshop door.";
                        condition = "Total Nitro consumed : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(500000);
                        reward = "Nitro Cap + 4000";
                        break;
                    case QuestKindGlobal.Nitro6:
                        name = "How to be a Nitro Booster Geek 6";
                        client = "Gnomish Engineer, Asgabit Tinkerbait";
                        description = "You return to the gnomish workshop only to find a giant crater in the ground where the building once stood. At the center of the crater sits a blackened, ash-covered gnome looking a bit despondent. As you approach he looks up at you a little bit embarrassed. \"I succeeded. I broke through the Nitro barrier.\" He wipes a bit of a tear from his eye, smearing the ash across his already filthy face. \"So that's it, my life's work complete. No idea what I'm going to do now. I'm sure you're here for another Nitro expansion? Fine, but this is the last time. I'll be returning to my homeland soon to report my findings and hopefully find inspiration to start a new life's work. Well, why are you still standing there? Go burn through " + tDigit(1000000) + " of Nitro and let me know when you're done. I've got some things to take care of before I go, so I'll wait till you return.\"";
                        condition = "Total Nitro consumed : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(1000000);
                        reward = "Nitro Cap + 5000";
                        break;
                    case QuestKindGlobal.Nitro7:
                        name = "How to be a Nitro Booster Geek 7";
                        client = "Gnomish Engineer, Asgabit Tinkerbait";
                        description = "";
                        condition = "Total Nitro consumed : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(5000000);
                        reward = "Nitro Cap + 6000";
                        break;
                    case QuestKindGlobal.Nitro8:
                        name = "How to be a Nitro Booster Geek 8";
                        client = "Gnomish Engineer, Asgabit Tinkerbait";
                        description = "";
                        condition = "Total Nitro consumed : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(10000000);
                        reward = "Nitro Cap + 7000";
                        break;

                    case QuestKindGlobal.Capture1:
                        name = "Capturing Monsters 1";
                        client = "Ringold";
                        description = "In the <color=orange>Shop</color>, there is a tab where you can find all of the traps that you have currently unlocked. The first trap that is unlocked is the <color=orange>Throwing Net</color>, which is ONLY capable of capturing <color=orange>'Normal' Type</color> monsters. Also keep in mind that you must at least pass the <color=orange>Title Quest [ Monster Study 1 ]</color> before you will be able to properly utilize Traps. Traps can be equipped in the <color=orange>Utility Slot</color>, you can then <color=orange>Right Click</color> on a monster. You must have the right trap type equipped and have a high enough capturable monster level for the monster you are trying to trap.";//Traps can be equipped in the <color=orange>Utility</color> slot and are activated automatically upon defeating a monster whose type and level are eligible to be captured based on the type of trap equipped.";
                        description += "\n- You can hover over a trap to see the max capturable monster level. To increase this further, you can increase your Hero level, finish Monster Study title quests, and increase the level of a particular town building.";
                        description += "\n- Captured Monsters, or Pets, provide a range of special bonuses that not only enable you to automate various aspects of the game, but also provide passive boosts to a variety of stats.";
                        description += "\n<color=yellow>For more information, Help > [Capture].</color>";
                        condition = "Total Captured Monsters # : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(10);
                        reward = "Taming Point Gain + 10%";
                        break;
                    case QuestKindGlobal.Capture2:
                        name = "Capturing Monsters 2";
                        client = "Dirgah Suebur, the Monster Handler";
                        description = "Oy d'ere! Ye must be looking for training on how to handle monstery types, yea? Well, look no fur'ter as I'd be happy to teach ye. First ting's first, ye need to get yerself a trap. Head yerself over to the Shop, buy yerself some traps and capture some monstery types, then come back and sees me. I'll be waitin' right here.";
                        condition = "Total Captured Monsters # : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(1000);
                        reward = "Taming Point Gain + 20%";
                        break;
                    case QuestKindGlobal.Capture3:
                        name = "Capturing Monsters 3";
                        client = "Dirgah Suebur, the Monster Handler";
                        description = "Ey! Yer back! Looks like ye got yer hands on some traps and figured them out alright, ye did. Yer like a wizard, ye are! Since ye know how to wrangle a monstery type now, and ye've seen hows they turn into cute, wuvable pets, they do, ye may have noticed ye can only have so many afollowing ye at once. It's important to keep improving yer Trapper building! Oh and since we be friends now, I'll tell ye a little secret that will be surely helpful to ye. Seek out a monstery type that helps ye with trapping.";
                        condition = "Total Captured Monsters # : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(10000);
                        reward = "Taming Point Gain + 30%";
                        break;
                    case QuestKindGlobal.Capture4:
                        name = "Capturing Monsters 4";
                        client = "Dirgah Suebur, the Monster Handler";
                        description = "Well 'allo d'ere! That spidery fella was helpful, it was? I bet it was! Now if ye be wanting to do this in a more professional manner, so to speak, ye best be expanding the selection at the Shop! That requires fixing up the Trapper building real nice, it does. Come back and see me when the Shop has stocked traps for red monstery types!";
                        condition = "Total Captured Monsters # : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(100000)
                            + "\n- Town Building [Trapper] Rank 3";
                        reward = "Taming Point Gain + 40%";
                        break;
                    case QuestKindGlobal.Capture5:
                        name = "Capturing Monsters 5";
                        client = "Dirgah Suebur, the Monster Handler";
                        condition = "Total Captured Monsters # : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(1000000);
                        reward = "Taming Point Gain + 50%";
                        break;
                    case QuestKindGlobal.Alchemy1:
                        name = "The Road of Alchemy 1";
                        client = "Archimedes, the Old Hermit";
                        description = "\"Hello and welcome to my hut! Fancy a potion? ... Oh you wish to learn the craft yourself? Ahh, well that is quite fortutitous, as I was just thinking of finding an apprentice. So to get started, in your lab you must... you don't have lab, you say? Fine, use mine... you will select a catalyst and then which essence you which to synthesize. It's very rudimentary stuff, really. Once you've collected enough essence, you can begin crafting potions! Improving them is essential to growth, so come back after you've improved some.\"";
                        description += "\n- When crafting potions, you will gain <color=orange>Alchemy Points</color>, which can be used to purchase <color=orange>Alchemy Upgrades</color> or to upgrade your potions, improving their effect and disassembly value. Use those points to gain a cumulative total of 100 potion levels to proceed to the next quest.";
                        description += "\n- It will benefit you to spend some time <color=orange>expanding your Mysterious Water capacity</color>, as it will be needed to upgrade your <color=orange>Catalysts</color> and increasing your Mysterious Water production amount.";
                        condition = "Total Potion Level " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 100";
                        reward = "Multiplies Critical Chance of Catalyst by 125%";
                        break;
                    case QuestKindGlobal.Alchemy2:
                        name = "The Road of Alchemy 2";
                        client = "Archimedes, the Old Hermit";
                        description = "\"Oh, uhh, there you are! I was just about to come looking for you to check on how well you are progressing with Alchemy. It seems that you've got the basics down. That's good, that's good. Now I will challenge you to continue doing that a little more, before we get into the less elementary level instruction.\"";
                        description += "\n- Continue using your Alchemy Points to level up your potions until they reach a cumulative total of 200 potion levels.";
                        description += "\n- There is an easier way to Disassemble potions for Alchemy Points and gold. Be on the look out in the Bestiary for the monster that can provide this for you.";
                        description += "\n- When using said pet, make sure to change your top left multiplier when crafting.";
                        condition = "Total Potion Level " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 200";
                        reward = "Max Mysterious Water Cap + 100";
                        break;
                    case QuestKindGlobal.Alchemy3:
                        name = "The Road of Alchemy 3";
                        client = "Archimedes, the Old Hermit";
                        description = "\"My, you are progressing much faster than any of my former pupils. Why, that's marvelous! Good, good, good. Okay, now that you've got a handle on the basics, it's time to test your skills a little. Keep improving your potions, yes, but I also want to ensure you grasp certain potions well enough for us to proceed with your training...\"";
                        description += "\n- Now you must not only reach a cumulative potion level of 300, but you must also collect critical materials that you rarely gain when essences are producted.";
                        condition = "Total Potion Level " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 300";
                        reward = "Potion Level Cap + 25";
                        break;
                    case QuestKindGlobal.Alchemy4:
                        name = "The Road of Alchemy 4";
                        client = "Archimedes, the Old Hermit";
                        description = "\"Looks good, looks good. You did well grasping the health and resource potions. I am proud of you. Now, onwards and upwards! I hope that by now you've discovered the elemental catalysts of Fire, Ice, and Thunder. I would like to see that you're experienced enough with those to have collected five of each of their special materials they sometimes produce when you are synthesizing their essences. Plus, I need those for a potion I am developing, so I hope you won't mind we both benefit from this education.\"";
                        description += "\n- Now you must not only reach a cumulative potion level of 500, but you must also collect critical materials that you rarely gain when essences are producted.";
                        condition = "Total Potion Level " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 500";
                        reward = "Catalyst Level Cap + 25";
                        break;
                    case QuestKindGlobal.Alchemy5:
                        name = "The Road of Alchemy 5";
                        client = "Archimedes, the Old Hermit";
                        description = "\"Oh these are marvelous specimans. Good work my student! I must say these are quite rare, as I'm sure you've discovered why that is, so do your best to collect as many as you can. Now, to the next endeavor. Learning Alchemy is more than simply mixing potions, you know? It's gaining an understanding of the world and the substances that make it up. While very basic, Mysterious Water, as I'm sure you've gathered, can be converted to just about anything if you apply the knowledge correctly. Gather yourself a large quantity of it, as we will be needing it for lessons to come!\"";
                        description += "\n- Now you must not only reach a cumulative potion level of 750, but you must also expand your Mysterious Water capacity to 300.";
                        condition = "Total Potion Level " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 750\n- Mysterious Water Cap " + tDigit(game.alchemyCtrl.mysteriousWaterCap.Value()) + " / 300";
                        reward = "Lower the cost for leveling Catalysts by 25%";
                        break;
                    case QuestKindGlobal.Alchemy6:
                        name = "The Road of Alchemy 6";
                        client = "Archimedes, the Old Hermit";
                        description = "\"Always you astound me with how quickly you are completing the tasks I give you. You remind me a bit of myself, now that I think about it. Anywho, let's get back to work, shall we? Let's see, you've done that... okay, and this... excellent. Alright, now I'd like for you to explore the deeper mysteries of Alchemy. Collect 30 Ectoplasm and let me know when you've got them in hand.\"";
                        description += "\n- Now you must not only reach a cumulative potion level of 1000, but you must also collect 30 Ectoplasm to give to Archimedes to proceed.";
                        condition = "Total Potion Level " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 1000";
                        reward = "Multiplies Critical Chance of Catalyst by 125%" +
                            "\n- Max Mysterious Water Cap + 250";
                        break;
                    case QuestKindGlobal.Alchemy7:
                        name = "The Road of Alchemy 7";
                        client = "Archimedes, the Old Hermit";
                        description = "\"It's miraculous, really, this Ectoplasm. It honestly shouldn't exist, belonging to another plane of existence, and yet here it is. Now, we delve deeper, as this mystery is exceeded in its enigma by another. Now you must gather the very essence of the stars and bring me 100 Stardust. Only the most powerful of wizards has reached the stars themselves, but we can sometimes synthesize the substance by using a Sun Catalyst. Return to me when you have gathered it.\"";
                        description += "\n- Now you must not only reach a cumulative potion level of 1500, but you must also collect 100 Stardust to give to Archimedes to proceed.";
                        condition = "Total Potion Level " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 1500";
                        reward = "Potion Level Cap + 25" +
                            "\n- Catalyst Level Cap + 25";
                        break;
                    case QuestKindGlobal.Alchemy8:
                        name = "The Road of Alchemy 8";
                        client = "Archimedes, the Old Hermit";
                        description = "\"Alas, I knew this day would come. You are about to graduate from my tutelage, so I shall challenge you to discover the last of the secrets of Alchemy. Beyond our world, nay beyond the veil of reality itself lies a realm only known as the Void. No one who dared venture there has ever returned, but we have found traces of it in strange objects known as Void Eggs that are sometimes left behind when a Void portal closes. We have figured out how to synthesize these ourselves, with the use of the Void Catalyst. Again, I ask you to bring me 1000 of them and I shall bestow upon you the last bits of my wisdom.\"";
                        description += "\n- Now you must not only reach a cumulative potion level of 2000, but you must also collect 1000 Void Eggs to give to Archimedes.";
                        condition = "Total Potion Level " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 2000";
                        reward = "Alchemy Point Gain + 100%" +
                            "\n- Lower the cost for leveling Catalysts by 25%";
                        break;
                }
                break;
            case QuestKind.Daily:
                switch (kindDaily)
                {
                    case QuestKindDaily.EC1:
                        name = "Epic Coin 1 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "The Adventurer's Guild";
                        description = "The Adventurer's Guild has posted a " + DailyQuestRarityName(quest.dailyQuestRarity) + " job to defeat " + tDigit(quest.defeatRequredDefeatNum()) + " " + MonsterSpeciesName(quest.dailyTargetMonsterSpecies) + " that have been terrorizing the villagers living near " + AreaName(quest.questingArea.kind) + ". Return here when you have completed the task.";
                        break;
                    case QuestKindDaily.EC2:
                        name = "Epic Coin 2 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "The Tamer's Association";
                        description = "The Tamer's Association has posted a " + DailyQuestRarityName(quest.dailyQuestRarity) + " request to capture " + tDigit(quest.captureRequiredNum()) + " " + MonsterSpeciesName(quest.dailyTargetMonsterSpecies) + " for further study and analysis. Return here when you have completed the task.";
                        break;
                    case QuestKindDaily.EC3:
                        name = "Epic Coin 3 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "The Adventurer's Guild";
                        description = "The Adventurer's Guild has posted a " + DailyQuestRarityName(quest.dailyQuestRarity) + " job to defeat " + tDigit(quest.defeatRequredDefeatNum()) + " " + MonsterSpeciesName(quest.dailyTargetMonsterSpecies) + " that have been terrorizing the villagers living near " + AreaName(quest.questingArea.kind) + ". Return here when you have completed the task.";
                        break;
                    case QuestKindDaily.EC4:
                        name = "Epic Coin 4 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "The Tamer's Association";
                        description = "The Tamer's Association has posted a " + DailyQuestRarityName(quest.dailyQuestRarity) + " request to capture " + tDigit(quest.captureRequiredNum()) + " " + MonsterSpeciesName(quest.dailyTargetMonsterSpecies) + " for further study and analysis. Return here when you have completed the task.";
                        break;
                    case QuestKindDaily.Cartographer1:
                        name = "Cartographer 1 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "The Cartographer's Symposium";
                        description = "The Cartographer's Symposium wishes to send out a few cartographers to " + AreaName(quest.completeTargetArea.kind) + " to collect more data and inspect for any changes to the landscape and the creatures that dwell there. Please escort them while they complete this work. With this job being " + DailyQuestRarityName(quest.dailyQuestRarity) + ", it is expected you will need to clear " + quest.completeTargetArea.Name(true, false) + " at least " + tDigit(quest.areaRequredCompletedNum()) + " times before the Cartographers will be finished with their task.";
                        break;
                    case QuestKindDaily.Cartographer2:
                        name = "Cartographer 2 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "The Cartographer's Symposium";
                        description = "The Cartographer's Symposium wishes to send out a few cartographers to " + AreaName(quest.completeTargetArea.kind) + " to collect more data and inspect for any changes to the landscape and the creatures that dwell there. Please escort them while they complete this work. With this job being " + DailyQuestRarityName(quest.dailyQuestRarity) + ", it is expected you will need to clear " + quest.completeTargetArea.Name(true, false) + " at least " + tDigit(quest.areaRequredCompletedNum()) + " times before the Cartographers will be finished with their task.";
                        break;
                    case QuestKindDaily.Cartographer3:
                        name = "Cartographer 3 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "The Cartographer's Symposium";
                        description = "The Cartographer's Symposium wishes to send out a few cartographers to " + AreaName(quest.completeTargetArea.kind) + " to collect more data and inspect for any changes to the landscape and the creatures that dwell there. Please escort them while they complete this work. With this job being " + DailyQuestRarityName(quest.dailyQuestRarity) + ", it is expected you will need to clear " + quest.completeTargetArea.Name(true, false) + " at least " + tDigit(quest.areaRequredCompletedNum()) + " times before the Cartographers will be finished with their task.";
                        break;
                    case QuestKindDaily.Cartographer4:
                        name = "Cartographer 4 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "The Cartographer's Symposium";
                        description = "The Cartographer's Symposium wishes to send out a few cartographers to " + AreaName(quest.completeTargetArea.kind) + " to collect more data and inspect for any changes to the landscape and the creatures that dwell there. Please escort them while they complete this work. With this job being " + DailyQuestRarityName(quest.dailyQuestRarity) + ", it is expected you will need to clear " + quest.completeTargetArea.Name(true, false) + " at least " + tDigit(quest.areaRequredCompletedNum()) + " times before the Cartographers will be finished with their task.";
                        break;
                    case QuestKindDaily.Cartographer5:
                        name = "Cartographer 5 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "The Cartographer's Symposium";
                        description = "The Cartographer's Symposium wishes to send out a few cartographers to " + AreaName(quest.completeTargetArea.kind) + " to collect more data and inspect for any changes to the landscape and the creatures that dwell there. Please escort them while they complete this work. With this job being " + DailyQuestRarityName(quest.dailyQuestRarity) + ", it is expected you will need to clear " + quest.completeTargetArea.Name(true, false) + " at least " + tDigit(quest.areaRequredCompletedNum()) + " times before the Cartographers will be finished with their task.";
                        break;

                }
                break;
            case QuestKind.Title:
                switch (kindTitle)
                {
                    case QuestKindTitle.SkillMaster1:
                        name = Title(TitleKind.SkillMaster) + " 1";
                        client = "Condescending Asian Kid";
                        description = "\"You there! Rookie! Yes, clearly I mean you, the 'Hero' who looks like you're practicing your white belt katas but keep forgetting the next step. I can see that you have potential but that's only because I have excellent eyesight! You need to walk before you can run, so I would suggest practicing your basic moves until you get the technique right and can do it without thinking. Then come back to me and I'll show you an easy one-two combo.\"";
                        description += "\n- Skills gain <color=orange>Proficiency</color> every time they trigger, and they gain levels just like your Hero. Each Hero collects a type of Resource that can be spent to increase <color=orange>Skill Ranks</color> which increase the Skill's maximum level.";
                        description += "\n- Clearing this quest gives the <color=orange>Class Master</color> Title, which expands a <color=orange>Class Skill Slot</color>. After you gain a new skill and an empty Class Skill slot, you can click the skill icon in the Skill tab to equip/remove it. Keep in mind that the first Base Attack Skill is not removable.";
                        condition = SkillName(heroKind, 0) + " Lv 7";
                        break;
                    case QuestKindTitle.SkillMaster2:
                        name = Title(TitleKind.SkillMaster) + " 2";
                        client = "Condescending Asian Kid";
                        description = "You see the kid from before practicing Tai Chi. His eyes are closed as moves smoothly from one position to the next, his breath timed perfectly with his movements. He starts to speak without opening his eyes as he continues gracefully moving. \"Hey Rookie. You're doing better but I'm afraid that's not saying much. You can't build a house without a strong foundation and your foundation is as weak as yesterday's tea. Strengthen your core and work on your balance until you can dance a waltz without tripping over your own feet.\"";
                        condition = SkillName(heroKind, 0) + " Lv 50";
                        break;
                    case QuestKindTitle.SkillMaster3:
                        name = Title(TitleKind.SkillMaster) + " 3";
                        client = "Condescending Asian Kid";
                        description = "The kid is practicing Tai Chi again, but this time he is balancing a glass of water on each upturned palm. He flows quickly and fluidly through the movements but not a ripple shows in the water. He turns and locks his gaze on you while he continues to move with the grace of a cat. \"Hey Rookie. You're getting better, I saw you almost keep control of your moves back there. Almost, anyway. Keep working on your control and your technique and before you know it you'll start to look like you know what you're doing!\"";
                        condition = SkillName(heroKind, 0) + " Lv 250";
                        break;
                    case QuestKindTitle.SkillMaster4:
                        name = Title(TitleKind.SkillMaster) + " 4";
                        client = "Condescending Asian Kid";
                        description = "You find the kid sparring with a dozen men and women. Or rather, a dozen men and women are trying to spar with him but he dances around them, redirecting their strikes with light touches and avoiding every advance. He sees you watching and calls out to you. \"Hey Rookie, looks like you built a strong foundation after all. Unfortunately that means I owe Gary fifty bucks. Make it up to me, will you? I'll raise him double or nothing that you can master your whole art, I'll even cut you in if you can do it.\"";
                        condition = "All " + Hero(heroKind) + "'s skills Lv 250";
                        break;
                    case QuestKindTitle.MonsterDistinguisher1:
                        name = Title(TitleKind.MonsterDistinguisher) + " 1";
                        client = "Ranger Rick";
                        description = "Oh, hey there, you want to be a Ranger Scout? Doing so will teach you how to be more knowledgeable about monsters, their habits, their diets, everything... oh, you want it to learn how to trap them more efficiently? I suppose that is also a benefit. Okay, so get started by going out there and defeating 20 normal slimes in combat! Pay close attention to their habits while you do and I’ll dub you a Ranger Scout when you’re done.";
                        break;
                    case QuestKindTitle.MonsterDistinguisher2:
                        name = Title(TitleKind.MonsterDistinguisher) + " 2";
                        client = "Ranger Rick";
                        description = "Studying monsters is a lot of fun, don’t you think? As you become more knowledgeable, your ability to capture higher level monsters will improve! So now let’s study a different monster. Go defeat around 100 Blue Slimes and report back to me when you’re done. I can’t wait to hear everything you’ve learned!";
                        break;
                    case QuestKindTitle.MonsterDistinguisher3:
                        name = Title(TitleKind.MonsterDistinguisher) + " 3";
                        client = "Ranger Rick";
                        description = "Ever felt the slight sting of electrocution before? Well, if you want to learn how to avoid it in the wild, you’ll need to tangle with some yellow slimes and understand how to avoid their electrically charged ooze. Learning how to deal with the strengths of these monsters will give you an edge when you are attempting to capture them. So go defeat around 250 Yellow Slimes and report back to me.";
                        break;
                    case QuestKindTitle.MonsterDistinguisher4:
                        name = Title(TitleKind.MonsterDistinguisher) + " 4";
                        client = "Ranger Rick";
                        description = "This time let’s change things up, because I’m not sure what else you will learn from fighting slimes. This time, I want you to study the habits of blue spiders. Some people are incredibly afraid of spiders, in which case it’s a good effort to overcome those fears by facing them head on! Just be careful and do your best! Let me know after you’ve defeated around 1000 Blue Spiders.";
                        break;
                    case QuestKindTitle.MonsterDistinguisher5:
                        name = Title(TitleKind.MonsterDistinguisher) + " 5";
                        client = "Ranger Rick";
                        description = "There are some pretty interesting monsters out there, aren’t there? Well, how about one that can literally make you move slower? How do you handle not being able to move at the speed you are used to moving? You adapt and make every movement matter! Go and study Red Fairies, defeating around 5000 of them ought to help you to understand how to overcome their strengths and improve your ability to capture monsters.";
                        break;
                    case QuestKindTitle.MonsterDistinguisher6:
                        name = Title(TitleKind.MonsterDistinguisher) + " 6";
                        client = "Ranger Rick";
                        description = "Alright, I don’t know if I have much left to teach you, but I must ask if you’ve ever gone fishing? It’s quite a sport indeed, for those with the patience to endure it. So, my last lesson will come in the form of fishing! Go and defeat " + tDigit(50000) + " Green Devilfish and report back to me. Remember, this is a patience building exercise, but it will vastly improve your ability to capture stronger monsters – I guarantee it!";
                        break;
                    case QuestKindTitle.MonsterDistinguisher7:
                        name = Title(TitleKind.MonsterDistinguisher) + " 7";
                        client = "Ranger Rick";
                        break;
                    case QuestKindTitle.EquipmentSlotWeapon1:
                        name = Title(TitleKind.EquipmentSlotWeapon) + " 1";
                        client = "Equipment Trainer, Tsuba";
                        description = "Greetings novice. You have come seeking knowledge for weapon mastery? Very well. First, equip any weapon and simply start using it. As you do, you will notice your proficiency with that weapon will improve until it levels up, improving the effects it bestows upon you. Return to me when you have attained Level 10 with at least one weapon, and I shall show you how to wield more weapons.";
                        condition = "1 Weapon Lv 10 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Weapon)) + " / 1";
                        break;
                    case QuestKindTitle.EquipmentSlotWeapon2:
                        name = Title(TitleKind.EquipmentSlotWeapon) + " 2";
                        client = "Equipment Trainer, Tsuba";
                        description = "You have proven yourself capable, novice. Do it again now, but this time attain Level 10 with at least five weapons, and I will again teach you how to wield more weapons!";
                        condition = "5 Weapons Lv 10 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Weapon)) + " / 5";
                        break;
                    case QuestKindTitle.EquipmentSlotWeapon3:
                        name = Title(TitleKind.EquipmentSlotWeapon) + " 3";
                        client = "Equipment Trainer, Tsuba";
                        description = "It seems I cannot keep calling you novice, as you have demonstrated fine ability with using a variety of weapons. Now, adept, if you wish to continue your training with me, I must see that you have attained Level 10 with at least 15 weapons!";
                        condition = "15 Weapons Lv 10 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Weapon)) + " / 15";
                        break;
                    case QuestKindTitle.EquipmentSlotWeapon4:
                        name = Title(TitleKind.EquipmentSlotWeapon) + " 4";
                        client = "Equipment Trainer, Tsuba";
                        description = "Well done, adept. Again, 30 weapons this time. Show me that you have what it takes to be a weapons master!";
                        condition = "30 Weapons Lv 10 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Weapon)) + " / 30";
                        break;
                    case QuestKindTitle.EquipmentSlotWeapon5:
                        name = Title(TitleKind.EquipmentSlotWeapon) + " 5";
                        client = "Equipment Trainer, Tsuba";
                        description = "I am impressed, adept. Now for something more challenging. I desire to see at least 20 weapons at level 15. Push past the limits of ordinary and begin to achieve greatness!";
                        condition = "20 Weapons Lv 15 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Weapon, 15)) + " / 20";
                        break;
                    case QuestKindTitle.EquipmentSlotWeapon6:
                        name = Title(TitleKind.EquipmentSlotWeapon) + " 6";
                        client = "Equipment Trainer, Tsuba";
                        description = "There is very little left that I can teach you, so I will issue you one last challenge. Have over 50 weapons at level 20, and I will bestow the last of my secrets to you.";
                        condition = "50 Weapons Lv 20 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Weapon, 20)) + " / 50";
                        break;
                    case QuestKindTitle.EquipmentSlotArmor1:
                        name = Title(TitleKind.EquipmentSlotArmor) + " 1";
                        client = "Equipment Trainer, Koutetsu";
                        description = "The path to armor mastery begins here, with you seeking such wisdom. Prove to me you desire this wisdom by leveling any piece of armor to Level 10.";
                        condition = "1 Armor Lv 10 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Armor)) + " / 1";
                        break;
                    case QuestKindTitle.EquipmentSlotArmor2:
                        name = Title(TitleKind.EquipmentSlotArmor) + " 2";
                        client = "Equipment Trainer, Koutetsu";
                        description = "Ahh, excellent. Your pursuit in wisdom of armor mastery is noble my young novice. Now take what you have learned and do it five times! You will begin to understand the mind of the armor the more you practice, enabling you to wear more armor without it encumbering you.";
                        condition = "5 Armor Lv 10 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Armor)) + " / 5";
                        break;
                    case QuestKindTitle.EquipmentSlotArmor3:
                        name = Title(TitleKind.EquipmentSlotArmor) + " 3";
                        client = "Equipment Trainer, Koutetsu";
                        description = "Remarkable work my keen novice. Your zeal for understanding is admirable, but you must push further if you wish to gain the clarity you seek. Now bring to me 15 pieces of armor at level 10 and I will further illuminate you to efficient armor wearing.";
                        condition = "15 Armor Lv 10 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Armor)) + " / 15";
                        break;
                    case QuestKindTitle.EquipmentSlotArmor4:
                        name = Title(TitleKind.EquipmentSlotArmor) + " 4";
                        client = "Equipment Trainer, Koutetsu";
                        description = "It would seem you have become adept at this, so now my young adept, can you handle the task of bringing me 30 armor at level 10 and I will train you further on moving freely in more armor.";
                        condition = "30 Armor Lv 10 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Armor)) + " / 30";
                        break;
                    case QuestKindTitle.EquipmentSlotArmor5:
                        name = Title(TitleKind.EquipmentSlotArmor) + " 5";
                        client = "Equipment Trainer, Koutetsu";
                        description = "Sometimes, what we think is the highest we can go is just another beginning. This time I ask you to exceed your limits and bring me 20 pieces of armor at level 15, and we can continue training your armor wearing ability.";
                        condition = "20 Armor Lv 15 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Armor, 15)) + " / 20";
                        break;
                    case QuestKindTitle.EquipmentSlotArmor6:
                        name = Title(TitleKind.EquipmentSlotArmor) + " 6";
                        client = "Equipment Trainer, Koutetsu";
                        description = "You have nearly matched me, my keen adept. The last I have to teach you is to seek the wisdom found in bringing 50 pieces of armor to level 20. I will bestow to you the last secret knowledge I have gathered in my life upon your return.";
                        condition = "50 Armor Lv 20 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Armor, 20)) + " / 50";
                        break;
                    case QuestKindTitle.EquipmentSlotJewelry1:
                        name = Title(TitleKind.EquipmentSlotJewelry) + " 1";
                        client = "Equipment Trainer, Joudama";
                        description = "Why hello there, are you interested in jewelry? Ahh, you are like an uncut diamond, my dear, but that we can fix. Bring me any accessory piece that you’ve leveled to 10 and we can speak more about refining your appearance. I’m looking forward to it.";
                        condition = "1 Jewelry Lv 10 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Jewelry)) + " / 1";
                        break;
                    case QuestKindTitle.EquipmentSlotJewelry2:
                        name = Title(TitleKind.EquipmentSlotJewelry) + " 2";
                        client = "Equipment Trainer, Joudama";
                        description = "Oh, now that is exquisite indeed. There is nothing quite like seeing a freshly polished gem in your hands, and you, my dear, are that gem to me. Now, our work is not yet done. Go now and come back to see me after you’ve got 5 accessory pieces to level 10. I’ll be thinking about you until we meet again!";
                        condition = "5 Jewelry Lv 10 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Jewelry)) + " / 5";
                        break;
                    case QuestKindTitle.EquipmentSlotJewelry3:
                        name = Title(TitleKind.EquipmentSlotJewelry) + " 3";
                        client = "Equipment Trainer, Joudama";
                        description = "Set my heart alight, you have done so well! You may very well be a diamond in the rough, my dear. Let’s continue polishing you up and expose that hidden, ravishing beauty that you are! Bring me 15 accessory items that you’ve leveled to 10 and I will show you ways to make you sparkle in the sun!";
                        condition = "15 Jewelry Lv 10 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Jewelry)) + " / 15";
                        break;
                    case QuestKindTitle.EquipmentSlotJewelry4:
                        name = Title(TitleKind.EquipmentSlotJewelry) + " 4";
                        client = "Equipment Trainer, Joudama";
                        description = "Dare I say that the stars sparkle less brightly than you? Perhaps not quite yet, but you’re certainly a twinkle in my eyes right now. Though there’s only so much we do with polishing, now we must cut this gemstone to really bring out its true beauty, as I see in you, my dear. Bring me 30 accessory pieces that are level 10, and I will show you how to shine like a diamond!";
                        condition = "30 Jewelry Lv 10 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Jewelry)) + " / 30";
                        break;
                    case QuestKindTitle.EquipmentSlotJewelry5:
                        name = Title(TitleKind.EquipmentSlotJewelry) + " 5";
                        client = "Equipment Trainer, Joudama";
                        description = "You’ve not disappointed me once, my exquisite little gem. True perfection is but a goal, though to me that which I see in you is nearly that. To rise to the next level and to reach for this goal I need you to bring me 20 accessory pieces at level 15. Only through surpassing our standards can we truly begin to glow.";
                        condition = "20 Jewelry Lv 15 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Jewelry, 15)) + " / 20";
                        break;
                    case QuestKindTitle.EquipmentSlotJewelry6:
                        name = Title(TitleKind.EquipmentSlotJewelry) + " 6";
                        client = "Equipment Trainer, Joudama";
                        description = "My dear, to say you are ravishing upon the eyes is an understatement to be sure. Alas, I fear this little project of ours is near its end. I will miss seeing your perfect little face with those dazzling eyes staring longingly at me as I return that gaze. I shall not stand in your ascent to unimaginable beauty, but I will set you on the path to reach for it. Bring me back 50 accessory pieces at level 20 and I will bestow the last bits of titillating wisdom I have with you. ";
                        condition = "50 Jewelry Lv 20 for " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Jewelry, 20)) + " / 50";
                        break;

                    case QuestKindTitle.PotionSlot1:
                        name = Title(TitleKind.PotionSlot) + " 1";
                        client = "Alchemy Guru, Flamel";
                        description = "Hmmm? Who are you and why are you in my laboratory? Oh, you come seeking advice on Alchemy, do you? Hmm, well I’m not one to share my alchemy secrets openly, but I can show you how to be more efficient with your potions. Fetch me these items and we can talk more.";
                        break;
                    case QuestKindTitle.PotionSlot2:
                        name = Title(TitleKind.PotionSlot) + " 2";
                        client = "Alchemy Guru, Flamel";
                        description = "Do I know you? Oh, that’s right, you’re seeking alchemical knowledge. Again, sorry but I won’t share that kind of knowledge with people coming in off the street. However, I do need someone to fetch me more ingredients. If you get me these, I’ll show you how to expand your potion-carrying ability.";
                        break;
                    case QuestKindTitle.PotionSlot3:
                        name = Title(TitleKind.PotionSlot) + " 3";
                        client = "Alchemy Guru, Flamel";
                        description = "I don’t remember ordering a pizza… oh sorry, you just have that look of someone always looking to run an errand for someone else. Speaking of which, I need some more ingredients. If you’d be so kind as to fetch these I’ll teach you how to unlock another potion slot, but after this I will be setting off to travel the world, and please stop asking me for alchemical recipes – I really cannot share them with you.";
                        break;

                    case QuestKindTitle.Porter1:
                        name = "The Great Race 1";
                        client = "Bebop the Warthog";
                        description = "\"Hey, you, wanna race? I bet I can run 1000 meters faster than you can. Beat me and I’ll teach you how to be even faster than me!\" You are a little concerned that racing this large, warthog man will be pointless, but you might as well since he seems interested in teaching you something that may be useful.";
                        break;
                    case QuestKindTitle.Porter2:
                        name = "The Great Race 2";
                        client = "Rocksteady the Rhino";
                        description = "\"That’s no fair, you raced that warthog-faced buffoon, but not me?! I can teach you how to be even faster than me, so let’s start now!\" Why are these strange animal people approaching you like this? Who cares, might as well get moving.";
                        break;
                    case QuestKindTitle.Porter3:
                        name = "The Great Race 3";
                        client = "Tokka the Snapping Turtle";
                        description = "\"You might think I’m slow, being a turtle, but that’s why the turtle won against the hare. I can’t stand that warhog and rhino, so I’ll teach you how to be even faster than all of us if you can beat me at running 100k meters!\" Where are these anthropomorphic animals even coming from?!";
                        break;
                    case QuestKindTitle.Porter4:
                        name = "The Great Race 4";
                        client = "Rahzar the Wolf";
                        description = "It’s easy to beat a turtle, a rhino, and a warthog… I am much more cunning and much faster in a long run than any of them. Prove to me that you’re faster than a wolf by running 1 million meters and I’ll teach you what I know about being the fastest!";
                        break;
                    case QuestKindTitle.Porter5:
                        name = "The Great Race 5";
                        client = "Baxter the Fly";
                        description = "Oh you think that beating all of these simpleton land runners that you stand a chance at beating me in a race? Hardly possible, but let’s give it a go. I won’t be running, though, since I have wings, so let’s say 10 million meters as our goal? See you at the finish line!";
                        break;
                    case QuestKindTitle.Porter6:
                        name = "The Great Race 6";
                        client = "Krang the … brain… in a flesh golem?";
                        description = "Muaha, you may have defeated all of those fools, but I can make myself grow massive with this golem body I possess. Race me! 100 million meters! Win or lose, I’ll teach you how to be the fastest in the world!";
                        break;
                    case QuestKindTitle.PhysicalAttack1:
                        name = Title(TitleKind.PhysicalDamage) + " 1";
                        client = "Boxer Tyson";
                        description = "Yo, you new around here? I’ve been using slimes as punching bags. Care to join me? Let’s beat up some monsters together. It’s very therapeutic and if you can keep up with me, I’ll give you some pointers on maximizing your physical damage.";
                        break;
                    case QuestKindTitle.PhysicalAttack2:
                        name = Title(TitleKind.PhysicalDamage) + " 2";
                        client = "Boxer Tyson";
                        description = "Not bad, not bad. You really didn’t disappoint me. But we’ve got a lot more monsters and if these fists aren’t smashing, these muscles aren’t growing. Let’s get back to it and I’ll help you with your posture when you strike.";
                        break;
                    case QuestKindTitle.PhysicalAttack3:
                        name = Title(TitleKind.PhysicalDamage) + " 3";
                        client = "Boxer Tyson";
                        description = "You’re not getting tired, are you? Come on, the monster hordes are endless and who can ask for a better workout than this? I’m not ready to plateau yet, so let’s push even harder this time and see how swole we can get.";
                        break;
                    case QuestKindTitle.PhysicalAttack4:
                        name = Title(TitleKind.PhysicalDamage) + " 4";
                        client = "Boxer Tyson";
                        description = "Oh man, I’ve had the best time punching these monsters out with you. Your muscles look great! Alright, one last stretch before we reach our limit. Come on, we got gains to make.";

                        break;
                    case QuestKindTitle.FireAttack1:
                        name = Title(TitleKind.FireDamage) + " 1";
                        client = "Pyromancer Natsu";
                        description = "Ey, you interested in fire magic? I know a thing a two I could teach you. Come on, we can train together, and I’ll see what you’re capable of with your magic.";
                        break;
                    case QuestKindTitle.FireAttack2:
                        name = Title(TitleKind.FireDamage) + " 2";
                        client = "Pyromancer Natsu";
                        description = "Wow, you might just have a fire in your belly. Fire magic is powerful, but it requires strong convictions or else it’ll backfire and burn you too. Come on, I think I’m going to enjoy blazing next to you for a while!";
                        break;
                    case QuestKindTitle.FireAttack3:
                        name = Title(TitleKind.FireDamage) + " 3";
                        client = "Pyromancer Natsu";
                        description = "Awesome! I love fighting alongside my friends, and I feel like we’re both really improving! Let’s get out there and show them our fire is the strongest!";
                        break;
                    case QuestKindTitle.FireAttack4:
                        name = Title(TitleKind.FireDamage) + " 4";
                        client = "Pyromancer Natsu";
                        description = "Looks like I’ll be needing to head back to my guild soon, but I have a little more fire in my belly to spare, so let’s go burn em up one last time. Glad I got to fight alongside you for a while!";
                        break;
                    case QuestKindTitle.IceAttack1:
                        name = Title(TitleKind.IceDamage) + " 1";
                        client = "Cryomancer, Shimo Aisu";
                        description = "It isn’t everyday I meet someone interested in the frozen arts. You are looking for someone to practice your skills with I take it? Good, let’s get started then.";
                        break;
                    case QuestKindTitle.IceAttack2:
                        name = Title(TitleKind.IceDamage) + " 2";
                        client = "Cryomancer, Shimo Aisu";
                        description = "I’d say we’re working up a good sweat, but then we’d probably freeze ourselves. You’re pretty good but remember that ice magic is about controlling the cold outside of yourself and the heat within. You must always remember to keep your heart warm, or it will freeze along with your enemies. Now practice focusing on your heart as you cast.";
                        break;
                    case QuestKindTitle.IceAttack3:
                        name = Title(TitleKind.IceDamage) + " 3";
                        client = "Cryomancer, Shimo Aisu";
                        description = "Excellent, you’re far better than I expected you to be. Ice magic tends to turn most people away because it creates unfavorable conditions for training, but a true master understands that what happens within you is more important than what happens without. Reflect on that as we practice some more.";
                        break;
                    case QuestKindTitle.IceAttack4:
                        name = Title(TitleKind.IceDamage) + " 4";
                        client = "Cryomancer, Shimo Aisu";
                        description = "I am not one for puns but watching your growth with ice magic has given me chills! You may be one of those hidden masters that only arise once a century or two! I am grateful for our time together, as I have learned much from watching you as well. Let us practice some more, though now I fear I have little left to teach you.";
                        break;
                    case QuestKindTitle.ThunderAttack1:
                        name = Title(TitleKind.ThunderDamage) + " 1";
                        client = "Thunderbeast Raiju";
                        description = "You see a strange beast, electricity arcing across its fur sporadically, resting under what appears to be a blackened tree. It glances at you, sniffs at the air, and it stares at you intently. You get the feeling it wants you to follow it and the urge to use thunder magic swells within you.";
                        break;
                    case QuestKindTitle.ThunderAttack2:
                        name = Title(TitleKind.ThunderDamage) + " 2";
                        client = "Thunderbeast Raiju";
                        description = "The beast appears pleased as it watches you sending bolts of thunderous magic left and right. Suddenly, it sends a sharp bolt of its own directly into your chest. Surprisingly, this is painless as you see dozens of battles play forth in your mind. It walks a few meters and pauses, as if waiting for you to follow again. You can feel the magic of thunder again wishing to burst forth from your fingers.";
                        break;
                    case QuestKindTitle.ThunderAttack3:
                        name = Title(TitleKind.ThunderDamage) + " 3";
                        client = "Thunderbeast Raiju";
                        description = "Incredibly, despite no regular means of communication, you feel you have learned from this strange lightning creature. Still, it seems to beckon to you that there is more it wishes to show you. You can tell the time you are spending with this beast is aiding your growth with thunder magic. It suddenly roars, though it sounds like a huge thunderclap and darts off running toward more enemies. You’ve come this, so you decide to continue fighting alongside it.";
                        break;
                    case QuestKindTitle.ThunderAttack4:
                        name = Title(TitleKind.ThunderDamage) + " 4";
                        client = "Thunderbeast Raiju";
                        description = "The beast stares at you for a moment, its eyes no longer sharp and untrusting as they were when you first met. It seems a little sad, as though it knows it must depart soon after growing a little attached to you. Still, it doesn’t look like its quite ready to leave just yet, and there are always more enemies to blast. Practicing alongside this legendary being has certainly been helpful, so before it must go you decide to continue the fight for as long as it can remain.";
                        break;
                    case QuestKindTitle.LightAttack1:
                        name = Title(TitleKind.LightDamage) + " 1";
                        client = "The lazy farmer Aggrezi";
                        description = "You there, hey, I uhh saw you could use light magic and wondered if you could help me out? I, uhh, am so weak and fragile and the monsters here are so, uhh, dark and scary. If you wouldn’t mind, uhh, practicing that light magic and keeping me, uhh, safe, I’d appreciate it. I’ll just be over here in my, uhh, recliner waiting for you to clear the fields of those abominations.";
                        break;
                    case QuestKindTitle.LightAttack2:
                        name = Title(TitleKind.LightDamage) + " 2";
                        client = "The lazy farmer Aggrezi";
                        description = "Delightful, ermm, I mean good work there! You, uhh, really showed them how it is done. Next time, though, you should, uhh, let the light pass through your crown chakra more, err, I mean let the heavens flow through you, yeah. I’m sure that’ll help you get stronger and, uhh, take down the baddies faster. If you need me, uhh, I’ll be over here sipping some lemonade.";
                        break;
                    case QuestKindTitle.LightAttack3:
                        name = Title(TitleKind.LightDamage) + " 3";
                        client = "The lazy farmer Aggrezi";
                        description = "Well done mortal, errm, I mean you’ve done a splendid job clearing my fields! Hmm, you think I’m acting suspicious? Uhh, I don’t know what you mean. Just a lazy farmer whose wings, errm, arms are too weak to do the job any longer, yeah. I couldn’t help but notice, uhh, you should find a source of purity within yourself, errm, find a happy place when you cast. I’m sure that’ll help, yeah. Alright, enough chit chat, get back out there.";
                        break;
                    case QuestKindTitle.LightAttack4:
                        name = Title(TitleKind.LightDamage) + " 4";
                        client = "The lazy farmer Aggrezi";
                        description = "I cannot hide my appearance any longer from you, dear mortal. You have done exceptionally well at honing your light magic and growing the purity within yourself. I was sent here to guide you, but I was meant to do it discreetly, but you have surpassed my expectations and so I felt I owed it to you to reveal myself at least. I will be leaving soon, but before I do it would be my honor to practice the sacred light magic alongside you.";
                        break;
                    case QuestKindTitle.DarkAttack1:
                        name = Title(TitleKind.DarkDamage) + " 1";
                        client = "Archibald, the Shadow Hunter";
                        description = "\"Psst, hey you there. You have the taint of shadow around you.\" A dark man emerges from the shadows and inspects you closely, attempting to discern whether or not you are what you appear. Looking satisfied with his inspection he continues to speak, \"Ahh, I feared you may have been something else, but fortunately for you that does not appear to be so. Still, there does appear to be some darkness in you. With the proper training, that darkness can be honed and used in battle. Since you are not a pawn of the Dark One, I am willing to share a little bit of what I know with you. Can't have that darkness within you taking over, or else you'll force my hand and I'll have to end you. Show me how you currently wield your darkness and we can continue talking later.\"";
                        break;
                    case QuestKindTitle.DarkAttack2:
                        name = Title(TitleKind.DarkDamage) + " 2";
                        client = "Archibald, the Shadow Hunter";
                        description = "\"Hmm, you are either extremely gifted, yet without any formal training, or you are just another miserable wretch whose experienced too much of grittier aspects of life. Regardless, you do have some promise, though I am perhaps a little more concerned that the darkness within you might swallow you up and turn you into one of the very monsters you regularly hunt.\" He takes some time and shows you various meditation techniques and practices sparring with you, helping you to understand the power of darkness and how to properly wield it. \"Now, you must show me what you've learned. I will wait here for your report.\"";
                        break;
                    case QuestKindTitle.DarkAttack3:
                        name = Title(TitleKind.DarkDamage) + " 3";
                        client = "Archibald, the Shadow Hunter";
                        description = "You arrive at the meeting spot, but Archibald is nowhere to be seen. Suddenly, a form solidifies from the shadows, \"Ahh, you've returned. I almost mistook you again, as I see the power of darkness has yet again grown within you, but it is less wild than it was before, so I hesitated. However, it seems you still need further training, for another other agent of my kind would likely have slain you where you stood without remorse.\" Once again, you are instructed on how to properly conduct the power of darkness within you, focusing it, learning how to use it but never let it control you. \"Much better, you've improved greatly since we first met.Now go forth and practice what I've taught you and return again when the task is done.\"";
                        break;
                    case QuestKindTitle.DarkAttack4:
                        name = Title(TitleKind.DarkDamage) + " 4";
                        client = "Archibald, the Shadow Hunter";
                        description = "Dark ichor stains the ground of the meeting place, splattered on the ground, the walls, and just about everywhere you can see, before it slowly fades away as if it were never there. A form materializes beside you, knife at your throat. \"Forget what you have seen just now.\" They remove the knife and sheathe it at their waist. \"Some fools who ignored their darkness came around, but they have been dealt with accordingly. Now, you seem to have improved greatly, still I was able to sneak up on you just now, so we must help grow your ability to sense the darkness in others, as had your sense been strong then you would have known I was here long before you even arrived.\" He then proceeds to pass on the last of his training, teaching you the greatest of his lessons on harnessing the power of darkness. \"Well done, you survived my training, but now I wish to see that you will survive out there in the world. I have one last secret to share with you, but it will require proof that you have mastered what I have taught you. Return to me when you have done so.\"";
                        break;
                    case QuestKindTitle.Alchemist1:
                        name = Title(TitleKind.Alchemist) + " 1";
                        break;
                    case QuestKindTitle.Alchemist2:
                        name = Title(TitleKind.Alchemist) + " 2";
                        break;
                    case QuestKindTitle.Alchemist3:
                        name = Title(TitleKind.Alchemist) + " 3";
                        break;
                    case QuestKindTitle.Alchemist4:
                        name = Title(TitleKind.Alchemist) + " 4";
                        break;
                    case QuestKindTitle.Alchemist5:
                        name = Title(TitleKind.Alchemist) + " 5";
                        break;
                    case QuestKindTitle.EquipmentProf1:
                        name = Title(TitleKind.EquipmentProficiency) + " 1";
                        client = "Karosis";
                        description = "\"Pssst,\" a disheveled individual wearing glasses and carrying a small collection of scrolls calls to you from a nearby alley. \"Looks like you found something unusual and hard to find there. I'll give you something nice if you can find me some other rare items.\"";
                        condition = "Equipment laying on the battlefield from monster kills : " + tDigit(GameController.game.battleCtrl.EquipmentDroppingNum()) + " / 5";
                        break;
                    case QuestKindTitle.EquipmentProf2:
                        name = Title(TitleKind.EquipmentProficiency) + " 2";
                        condition = "Equipment laying on the battlefield from monster kills : " + tDigit(GameController.game.battleCtrl.EquipmentDroppingNum()) + " / 10";
                        break;
                    case QuestKindTitle.EquipmentProf3:
                        name = Title(TitleKind.EquipmentProficiency) + " 3";
                        condition = "Equipment laying on the battlefield from monster kills : " + tDigit(GameController.game.battleCtrl.EquipmentDroppingNum()) + " / 15";
                        break;
                    case QuestKindTitle.EquipmentProf4:
                        name = Title(TitleKind.EquipmentProficiency) + " 4";
                        condition = "Equipment laying on the battlefield from monster kills : " + tDigit(GameController.game.battleCtrl.EquipmentDroppingNum()) + " / 20";
                        break;
                    case QuestKindTitle.EquipmentProf5:
                        name = Title(TitleKind.EquipmentProficiency) + " 5";
                        condition = "Equipment laying on the battlefield from monster kills : " + tDigit(GameController.game.battleCtrl.EquipmentDroppingNum()) + " / 30";
                        break;

                    case QuestKindTitle.MetalHunter1:
                        name = Title(TitleKind.MetalHunter) + " 1";
                        client = "Metallic Nuts";
                        description = "Did you know that there are metal monsters in this world? You have a rare chance of spotting them. In the Slime dungeons, there are metal slimes for instance. Their bodies are so hard that you can only deal 1 damage to them. However, if you defeat them, you'll get a bunch of EXP. First of all, I want you to go kill one metal slime. Once you've done that, I'm sure you'll be a little better at killing metal slimes.";
                        break;
                    case QuestKindTitle.MetalHunter2:
                        name = Title(TitleKind.MetalHunter) + " 2";
                        client = "Metallic Nuts";
                        description = "I see you've defeated the metal slime! It looks like you've learned a bit how to destroy metal bodies. Keep it up and you'll learn how to hunt metal more efficiently.";
                        break;
                    case QuestKindTitle.MetalHunter3:
                        name = Title(TitleKind.MetalHunter) + " 3";
                        client = "Metallic Nuts";
                        break;
                    case QuestKindTitle.MetalHunter4:
                        name = Title(TitleKind.MetalHunter) + " 4";
                        client = "Metallic Nuts";
                        break;
                    case QuestKindTitle.FireResistance1:
                        name = Title(TitleKind.FireResistance) + " 1";
                        break;
                    case QuestKindTitle.FireResistance2:
                        name = Title(TitleKind.FireResistance) + " 2";
                        break;
                    case QuestKindTitle.FireResistance3:
                        name = Title(TitleKind.FireResistance) + " 3";
                        break;
                    case QuestKindTitle.FireResistance4:
                        name = Title(TitleKind.FireResistance) + " 4";
                        break;
                    case QuestKindTitle.FireResistance5:
                        name = Title(TitleKind.FireResistance) + " 5";
                        break;
                    case QuestKindTitle.IceResistance1:
                        name = Title(TitleKind.IceResistance) + " 1";
                        break;
                    case QuestKindTitle.IceResistance2:
                        name = Title(TitleKind.IceResistance) + " 2";
                        break;
                    case QuestKindTitle.IceResistance3:
                        name = Title(TitleKind.IceResistance) + " 3";
                        break;
                    case QuestKindTitle.IceResistance4:
                        name = Title(TitleKind.IceResistance) + " 4";
                        break;
                    case QuestKindTitle.IceResistance5:
                        name = Title(TitleKind.IceResistance) + " 5";
                        break;
                    case QuestKindTitle.ThunderResistance1:
                        name = Title(TitleKind.ThunderResistance) + " 1";
                        break;
                    case QuestKindTitle.ThunderResistance2:
                        name = Title(TitleKind.ThunderResistance) + " 2";
                        break;
                    case QuestKindTitle.ThunderResistance3:
                        name = Title(TitleKind.ThunderResistance) + " 3";
                        break;
                    case QuestKindTitle.ThunderResistance4:
                        name = Title(TitleKind.ThunderResistance) + " 4";
                        break;
                    case QuestKindTitle.ThunderResistance5:
                        name = Title(TitleKind.ThunderResistance) + " 5";
                        break;
                    case QuestKindTitle.LightResistance1:
                        name = Title(TitleKind.LightResistance) + " 1";
                        break;
                    case QuestKindTitle.LightResistance2:
                        name = Title(TitleKind.LightResistance) + " 2";
                        break;
                    case QuestKindTitle.LightResistance3:
                        name = Title(TitleKind.LightResistance) + " 3";
                        break;
                    case QuestKindTitle.LightResistance4:
                        name = Title(TitleKind.LightResistance) + " 4";
                        break;
                    case QuestKindTitle.LightResistance5:
                        name = Title(TitleKind.LightResistance) + " 5";
                        break;
                    case QuestKindTitle.DarkResistance1:
                        name = Title(TitleKind.DarkResistance) + " 1";
                        break;
                    case QuestKindTitle.DarkResistance2:
                        name = Title(TitleKind.DarkResistance) + " 2";
                        break;
                    case QuestKindTitle.DarkResistance3:
                        name = Title(TitleKind.DarkResistance) + " 3";
                        break;
                    case QuestKindTitle.DarkResistance4:
                        name = Title(TitleKind.DarkResistance) + " 4";
                        break;
                    case QuestKindTitle.DarkResistance5:
                        name = Title(TitleKind.DarkResistance) + " 5";
                        break;
                    case QuestKindTitle.Survival1:
                        name = Title(TitleKind.Survival) + " 1";
                        if (!quest.isAccepted) condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(500);
                        else condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(Main.main.SR.survivalNumQuestTitle[(int)quest.heroKind]) + " / " + tDigit(500);
                        break;
                    case QuestKindTitle.Survival2:
                        name = Title(TitleKind.Survival) + " 2";
                        if (!quest.isAccepted) condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(5000);
                        else condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(Main.main.SR.survivalNumQuestTitle[(int)quest.heroKind]) + " / " + tDigit(5000);
                        break;
                    case QuestKindTitle.Survival3:
                        name = Title(TitleKind.Survival) + " 3";
                        if (!quest.isAccepted) condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(50000);
                        else condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(Main.main.SR.survivalNumQuestTitle[(int)quest.heroKind]) + " / " + tDigit(50000);
                        break;
                    case QuestKindTitle.Survival4:
                        name = Title(TitleKind.Survival) + " 4";
                        if (!quest.isAccepted) condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(500000);
                        else condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(Main.main.SR.survivalNumQuestTitle[(int)quest.heroKind]) + " / " + tDigit(500000);
                        break;
                    case QuestKindTitle.Cooperation1:
                        name = Title(TitleKind.Cooperation) + " 1";
                        client = "Morkyl";
                        description = "Hey there player! Let me introduce you to the method for improving your heroes, by allowing them to increase their background efficiency when you're playing as a different hero! With each improvement to the Proof of Rebirth title, your background efficiency will get better, but it does require that you perform a certain number of rebirths at a higher tier than the previous quest required. Let's start this off by having you perform Rebirth Tier 1 once. When you have done that, come back here for your reward!";
                        condition = "Rebirth Tier 1 # : " + tDigit(GameController.game.rebirthCtrl.Rebirth(quest.heroKind, 0).rebirthNum) + " / 1";
                        break;
                    case QuestKindTitle.Cooperation2:
                        name = Title(TitleKind.Cooperation) + " 2";
                        condition = "Rebirth Tier 2 # : " + tDigit(GameController.game.rebirthCtrl.Rebirth(quest.heroKind, 1).rebirthNum) + " / 1";
                        break;
                    case QuestKindTitle.Cooperation3:
                        name = Title(TitleKind.Cooperation) + " 3";
                        condition = "Rebirth Tier 3 # : " + tDigit(GameController.game.rebirthCtrl.Rebirth(quest.heroKind, 2).rebirthNum) + " / 1";
                        break;
                    case QuestKindTitle.Quester1:
                        name = Title(TitleKind.Quester) + " 1";
                        client = "Ivan, the Trainee Adventurer";
                        description = "Hi there, adventurer! You seem to be the questing type, but did you know that there are benefits to completing many, many quests? Yeah, there's a program through the Adventurer's Guild that grants the title of Quester to anyone who completes at least 100 general quests! I'm still too new to even think about doing that, but you look like you might be able to pull it off! Why don't you give a shot? I've heard having that title earns some great benefits when completing quests!";
                        break;
                    case QuestKindTitle.Quester2:
                        name = Title(TitleKind.Quester) + " 2";
                        break;
                    case QuestKindTitle.Quester3:
                        name = Title(TitleKind.Quester) + " 3";
                        break;
                    case QuestKindTitle.Quester4:
                        name = Title(TitleKind.Quester) + " 4";
                        break;
                    case QuestKindTitle.Quester5:
                        name = Title(TitleKind.Quester) + " 5";
                        break;
                    case QuestKindTitle.Quester6:
                        name = Title(TitleKind.Quester) + " 6";
                        break;
                    case QuestKindTitle.Quester7:
                        name = Title(TitleKind.Quester) + " 7";
                        break;
                    case QuestKindTitle.Quester8:
                        name = Title(TitleKind.Quester) + " 8";
                        break;
                    case QuestKindTitle.Quester9:
                        name = Title(TitleKind.Quester) + " 9";
                        break;
                    case QuestKindTitle.Quester10:
                        name = Title(TitleKind.Quester) + " 10";
                        break;

                }
                break;
            case QuestKind.General:
                switch (kindGeneral)
                {
                    case QuestKindGeneral.CompleteArea0_0:
                        name = "Find My Brother 1";
                        client = "Nohn";
                        description = "Can you please help me find my brother? He's been missing for some time now. He's worrying us sick! I wonder if he's in the Slime Village. Please check Area 1.";
                        break;
                    case QuestKindGeneral.CompleteArea0_1:
                        name = "Find My Brother 2";
                        client = "Nohn";
                        description = "No? Not in Area 1, was he? We must continue on then, I suppose. When I get my hands on him... well, let's just try and find him! What about Area 2?";
                        break;
                    case QuestKindGeneral.CompleteArea0_2:
                        name = "Find My Brother 3";
                        client = "Nohn";
                        description = "Ah, there was some evidence of a struggle? It better not have been those slimes. Show them what you're made of. Clear Area 3 and get my brother back for me!";
                        break;
                    case QuestKindGeneral.CompleteArea0_3:
                        name = "Find My Brother 4";
                        client = "Nohn";
                        description = "Thank you so much for finding Hitan. I can't believe those slimes took him like that. Clear Area 4 and bring him back home. I will take care of him from there.";
                        break;
                    case QuestKindGeneral.DefeatNormalSlime1:
                        name = "Slime Infestation 1";
                        client = "Village Mayor";
                        description = "The Slimes have overrun the village. Please help our village clean up these pesky monsters.";
                        break;
                    case QuestKindGeneral.DefeatNormalSlime2:
                        name = "Slime Infestation 2";
                        client = "Village Mayor";
                        description = "You did such an amazing job before. It looks like there's still a lot more. Could you help us again and help push back the slimes?";
                        break;
                    case QuestKindGeneral.DefeatNormalSlime3:
                        name = "Slime Infestation 3";
                        client = "Village Mayor";
                        description = "Oh no, your attempts to help us seem to have really upset the slimes, and now there's an army of them knocking on our doors! Since you're kind of responsible for this mess, what would you say to helping us clean... that is, cleaning it up for us?";
                        break;
                    case QuestKindGeneral.BringOilOfSlime:
                        name = "The Slime Lover";
                        client = "";
                        description = "";
                        break;
                    case QuestKindGeneral.DefeatRedSlime:
                        name = "Red Slime Threat";
                        client = "Huck the Village Farmer";
                        description = "Please help! The red slimes have been attacking my farm. Scare them away for me! Help me, you are my only hope.";
                        break;
                    case QuestKindGeneral.DefeatRedMagicSlime:
                        name = "Magicslime Menace";
                        client = "Karosis";
                        description = "A hurried individual wearing glasses and a scruffy collection of robes, runs into you, scattering scrolls everywhere. After collecting their dropped possessions, they take a look at you before nodding, \"You look like you can handle yourself. These slimes, they've been stealing my magical research and it's severely hampered my progress. Would you mind helping me out some and dealing these thieves a telling blow? I... I'm willing to pay if that's what you need.\"";
                        break;
                    case QuestKindGeneral.CompleteDungeon0_0:
                        name = "Find My Husband 1";
                        client = "Wakana";
                        description = "Excuse me, do you have a moment? My husband has been missing for the past few days. My neighbors said they saw him go to the slime cave, but I'm not good with slime so I can't go look for him. Can you please go there for me?"
                            + " After you clear <color=orange>Slime Village: Area 2</color> 100 times, you can try the Slime dungeon through <color=orange>Dungeon</color> tab in World Map. Keep in mind that you need <color=orange>Portal Orb</color> to enter Dungeons, which you can get from such as global quests and daily quests."
                            + " Before trying a dungeon, the <color=orange>Simulation</color> button in World Map is so useful. It simulates each area and tell you whether you can clear it or not.";
                        break;
                    case QuestKindGeneral.CompleteDungeon0_1:
                        name = "Find My Husband 2";
                        client = "Wakana";
                        description = "Oh, you didn't find him, I'm so sad. Maybe he's in another cave... I don't know. Please, can you go and look for him again? I'm so worried about him that I can't do anything about it."; break;
                    case QuestKindGeneral.CompleteDungeon0_2:
                        name = "Find My Husband 3";
                        client = "Wakana";
                        description = "What! You saw him being kidnapped by slime in the depths of the cave!? Oh, my god! I'm sure there's a slime hideout nearby, that's where he'll be. Please, please and please go and find him!";
                        break;
                    case QuestKindGeneral.DefeatNormalMagicSlime:
                        name = "A Debt Left Unpaid";
                        client = "Young Witch";
                        description = "I was studying by the tree when some Magicslimes asked to borrow my quills. I should have known something was wrong when they swallowed them, but I trusted them anyway. Now I have nothing to write with, and my homework for the academy is late. If you could teach them a lesson for me I'd gladly return the favor by making a quilt out of their hats.";
                        break;
                    case QuestKindGeneral.DefeatGreenMagicSlime:
                        name = "Sending A Message";
                        client = "Claire The Witch";
                        description = "\"I was doing extra credit to make up for my missing homework when one of the Magicslimes tossed this paper at me.\" She hands you a balled - up piece of paper inviting you to a tea party in Magicslime City. \"I'm no expert, but I'd say this is definitely a trap. Especially considering my friends at school are always too nervous to invite me over. I need you to go for me and send those lying Magicslimes back to where they came from.\"";
                        break;
                    case QuestKindGeneral.DefeatYellowBat:
                        name = "The Mine 1";
                        client = "Brick";
                        description = "As you are about to enter the cave a small giant sporting nothing but a pair of overalls, a mining hat, and a pickaxe. He scratches his head and addresses you with a worried expression. \"Excuse me. I need to get mining for the boss but the bats always give me the spooks. Can you lend me a hand and clear them out? I can't give you the ore, but you can have the stone.\"";
                        break;
                    case QuestKindGeneral.DefeatRedBat:
                        name = "The Mine 2";
                        client = "Mira";
                        description = "A small woman in thick steel plates and a miner helmet approaches you, \"Thank you for helping clear the bats. Brick has gotten a new sense of motivation recently. If you could go a bit deeper into the mine we could get some higher quality ore, and some rough stone you could keep.\"";
                        break;
                    case QuestKindGeneral.DefeatGreenBat:
                        name = "The Mine 3";
                        client = "Mira";
                        description = "With all those bats out of the way we saw some gems glittering deeper down in the mines. The boys and I understand that going down any deeper in the cave is dangerous. So we're willing to split our findings.";
                        break;
                    case QuestKindGeneral.DefeatPurpleBat:
                        name = "A Deep Dark Place";
                        client = "Brick";
                        description = "Brick approaches you as you return from the mine with a worried expression, \"It's good your back safe. Did you see the thing moving? It is like something was living in the void of the dark itself. I don't know why, but I don't have a good feeling about it. Could you go into that darkness and take care of it for us? I'm sure everyone would be happy being able to sleep a bit easier.\"";
                        break;
                    case QuestKindGeneral.DefeatBlueBat:
                        name = "A Strange Request";
                        client = "Miss Fizzle";
                        description = "As your leaving for Bat Cave a tomboy with thick goggles and a sharp grin eyes you down from atop a rock. Swirling a fiery potion in her hand as she calls to you, \"You. Yeah, you. I was wondering if you could bring me some guano from the bats I have a project I'm working on it's going to be great just you wait.\"";
                        break;
                    case QuestKindGeneral.BringToEnchantShard:
                        name = "The Big One";
                        client = "Miss Fizzle";
                        description = "Hey, thanks for the help earlier. My experiments are almost ready. All I need is a little Oil Of Slime to act as a base, A bit of Magical Cloth to wrap it in, and some Spider Silk for a long enough fuse. Then we can create a bomb so big it could blast away a million bats. For science of course.";
                        break;
                    case QuestKindGeneral.CompleteDungeon2_0:
                        name = "Haunted Mansion 1";
                        client = "Hansen";
                        description = "Did you hear the manor in the woods is haunted by an evil spirit? I need you to go check it out. People keep telling me there are noises coming from the walls, but I'm too busy to go look, myself. Very very busy.";
                        break;
                    case QuestKindGeneral.CompleteDungeon2_1:
                        name = "Haunted Mansion 2";
                        client = "Hansen";
                        description = "Eek it was spiders making all that noise. I mean oh spiders. Could you clear some of them out for me? I have a lot of work to do in the forest today.";
                        break;
                    case QuestKindGeneral.CaptureNormalSpider:
                        name = "Haunted Mansion 3";
                        client = "Hansen";
                        description = "The spiders just keep coming huh? There must be a queen. Sadly I'm sick and can't do it myself, but could you take some nets, and capture some spiders for me. I'll help you find the queen after.";
                        break;
                    case QuestKindGeneral.CompleteDungeon2_2:
                        name = "Haunted Mansion 4";
                        client = "A Strange Note";
                        description = "I've found the spider queen. At least one of the queens.  Sadly she has me captured. Please send help!";
                        break;
                    case QuestKindGeneral.CaptureYellowSlime:
                        name = "All Things Yellow!";
                        client = "Yellow Circle";
                        description = "An individual dressed from head to toe in Yellow robes stands just outside the slime village, bouncing on their heels in excitement as they crane their neck to get a better view of the town. As you pass by, they frantically wave you down, beckoning you over. \"Please, I was passing by this village and I saw a flash of yellow run between some buildings but I couldn't keep up with it. Can you try to catch it for me? Please oh please oh please?!\" Well, you can't say no to that face. Off you go then!";
                        break;
                    case QuestKindGeneral.CaptureNormalFairy:
                        name = "King Of The Fairies 1";
                        client = "A Lost Boy";
                        description = "A young boy, sniveling and covered in bruises, approaches you, \"I just wanted to play in the garden when I tripped on a fairy. Then they all bullied me out of the garden. Can you make sure it's safe to go back?\"";
                        break;
                    case QuestKindGeneral.CaptureBlueFairy:
                        name = "King Of The Fairies 2";
                        client = "Perky Peter";
                        description = "Young adventurers like you always come by and make things worse. Don't you know every time you slay a fairy two more comes back. You need to capture them if you really want them to stop terrorizing you. I'll do my best to help as well.";
                        break;
                    case QuestKindGeneral.CaptureYellowFairy:
                        name = "King Of The Fairies 3";
                        client = "Perky Peter";
                        description = "Now if there is one thing fairies respect. It's a stronger fairy. All we have to do is make the strongest fairy in the history of ever. Just get a strong fairy, and we can take it to the gardens to clear things up.";
                        break;
                    case QuestKindGeneral.CaptureRedFairy:
                        name = "Queen Of The Fairies";
                        client = "Perky Peter";
                        description = "You did a pretty good job helping that kid, I wouldn't expect anything less. Although this is where we part ways. I want you to take good care of that fairy I gave you.";
                        break;
                    case QuestKindGeneral.CaptureGreenFairy:
                        name = "Good Luck Charms";
                        client = "Panemu";
                        description = "You know some people think fairies' wings bring good luck? We could sure use some good karma right now. If you help me make some charms we can spread them around. Just in case there is any negative energy still in the town.";
                        break;
                    //Fox
                    case QuestKindGeneral.CaptureNormalFox:
                        name = "Fox Friends";
                        client = "Monk Of Many Tales";
                        description = "Did you hear the rumors that the local fox shrine is possessed by nine tails. How horrible the foxes are even attacking people on sight. Can you please rescue a few foxes so we can help? If you bring them here with nets we can relocate them to a small town in the forest? Rumor has it they allow foxes to roam the streets just like people.";
                        break;
                    case QuestKindGeneral.BringFoxTails:
                        name = "Fox Town";
                        client = "Monk Of Many Tales";
                        description = "The foxes in the town are doing well but they're lonely without their old friends. I see you have quite the collection of monsters in your village yourself. Could you send some to the village in the forest. They can cheer up the foxes, and collect knickknacks along the way to bring back to your village.";
                        break;
                    case QuestKindGeneral.CaptureGreenFox:
                        name = "Build A Better Shrine";
                        client = "Monk Of Many Tales";
                        description = "It seems the nine tails isn't leaving the shrine any time soon. Yet the foxes still have nowhere to go. Perhaps your little friends can come in handy again. The foxes may not trust humans, but if your companions help build them a shrine. They could stay in a shrine, and not have to worry about the nine tails. The villagers of the forest would never allow their precious foxes to be hurt after all.";
                        break;
                    case QuestKindGeneral.CapturePurpleFox:
                        name = "Journey Of A Thousand Miles";
                        client = "Monk Of Many Tales";
                        description = "Oh it's you again. Thank you for all your help before. I just came to the guild to request a small favor. There was a recent accident in the forest village when a traveler came to stay the night. It was rather unsettling and I think I need to go on a small pilgrimage to clear my head. I don't think another should come with me. It's not safe. Still, the journey will be very lonely, and I'd greatly appreciate if one of your little buddies joined me on this journey.";
                        break;
                    //Devilfish
                    case QuestKindGeneral.CaptureBlueDevilFish:
                        name = "Over The Pond";
                        client = "Brick";
                        description = "Oii we dun tunneled all the way through, and found ourselves a lake. The boss says it's safe to take a break and go swimming here, while we work on making a new mine, but I don't think it's such a good idea. Even the scary ones taking precautions. Maybe you could take a look in the lake, and see if you can find proof there are monsters down there. Rather not get a nip in my trousers.";
                        break;
                    case QuestKindGeneral.DefeatBlueDevilFish:
                        name = "Heresy";
                        client = "Cryt";
                        description = "Listen Son. Have you been listening to heresy recently? I'll tell you now this is my lake and my home, and I've lived here for a long time, and never had no problem with devilfish. Till that one man started coming around with all these fake devilfish toys to scare away the tourist. Nobody believes him of course. Everyone knows devilfish are red, not blue. How about you go stop their next line of fake devilfish fakes before the tourist get a little too worked up.";
                        break;
                    case QuestKindGeneral.DefeatBossDevilFish:
                        name = "Fishing With Dynamite";
                        client = "Miss Fizzle";
                        description = "You know I'm not one for philosophical debates on whether or not devilfish are real or not or morals for that matter. So I'm trying to stay out of those little arguments people seem to be getting into. I do know there is something big down there, and I'm not swimming till it's gone. How about I open the underwater cavern, and you go deal with it where it sleeps. Correction where it slept.";
                        break;
                    case QuestKindGeneral.BringFairyFoxFish:
                        name = "For The Casing";
                        client = "Miss Fizzle";
                        description = "You know I'm a pragmatic individual. I still don't think we have undeniable proof devilfish exist. Of course I did see you come back with multiple large fish like monsters the other day. So maybe some precautions are necessary. Waterproof bombs are hard to make though. We'll need some devilfish mat here for the casing. A few Fox Tails to help it sink fast, and enough Fairy Dust to light up the sky. Should be enough to scare them away from the shore for a little while.";
                        break;
                    //Treant
                    case QuestKindGeneral.DefeatNormalTreant:
                        name = "Wombat Escapees 1";
                        client = "Sharkbite, the Wombat Shepherd";
                        description = "You see large furry beast moving towards you. Actually no, once closer you see that it's a man ... carrying a large furry beast. The creature is enormous and completely obscures the man so all you can see is scruffy blond hair peeking over the furry face currently watching you and chewing quietly. \"G'day, could ya spare us a hand? Have ya got a minute? I've got a bunch of wombats, they're me pride and joy, but some monsters right worked me farm up and now the buggers have wandered off somewhere. Nah, the wombats, not the monsters. Well, them too. Anyway, I'd love to get them back, but while me farm's buggered there's not much point, is there ? Would ya help a guy out and find me some sturdy wood to fix me farm with? I'd do it meself, but Gus here is all I've got left and I can hardly cut wood while I'm holding this beautiful boy. No, daddy's not letting you go, ya furry bugger.\" You leave the strange man talking to his strange creature.";
                        break;
                    case QuestKindGeneral.DefeatYellowTreant:
                        name = "Wombat Escapees 2";
                        client = "Sharkbite, the Wombat Shepherd";
                        description = "You little beauty, that's just what I need to get me farm sorted. With this, me 'n Gus can fix me farm right up in two shakes of a wombat's tail! (You glance down at Gus, but he doesn't seem to have a tail) I hate to ask for more help, but since you're exploring or adventuring or whatever it is you get up to when you're not helping poor buggers like me anyway, could ya keep an eye out for the rest of me herd? Wombats are a bit of an invasive species around here. They'd never hurt anyone, but they're pretty much invulnerable and nothing can hurt them, neither. Ya shoulda seen it when Gus's ma decided to take a nap in the middle of the main road into the city. An entire adventurer's guild tried and failed to shift her until someone thought to wake her up and lure her out of the way with some carrots. Took hours for the traffic jam to clear! It was worth the fine for the drinking stories I got out of it. Anyway, we've both got work to do, and sitting here yarning won't get me farm fixed.";
                        break;
                    case QuestKindGeneral.DefeatRedTreant:
                        name = "Wombat Escapees 3";
                        client = "Sharkbite, the Wombat Shepherd";
                        description = "Me herd! Me farm! It's all coming back together thanks ta you! Except, I need ya help again. Those buggers what worked me farm up back when, they're still out there. I think they were watching me the other night, I couldn't see anything but Gus sat staring out into the dark for an age, and I swear the sound of branches rustling weren't natural. It gave me terrible flashbacks to me time in the army, when I was in charge of training up a combat wombat unit. Terrible bad it was, too much even for drinking stories. I won't face that again, but that means I can't fight around me herd, not even to protect 'em. So could ya, would ya, fight these monsters for me and let me keep me babies safe?";
                        break;
                }
                break;
        }
        return (name, client, description, condition, reward, unlock);
    }

    //Material
    public override string Material(MaterialKind kind)
    {
        switch (kind)
        {
            case MaterialKind.MonsterFluid:
                return "Fluide de Monstre";
            case MaterialKind.FlameShard:
                return "Éclat de Flamme";
            case MaterialKind.FrostShard:
                return "Éclat de Froid";
            case MaterialKind.LightningShard:
                return "Éclat de Tonnerre";
            case MaterialKind.NatureShard:
                return "Éclat de Nature";
            case MaterialKind.PoisonShard:
                return "Éclat de Poison";
            case MaterialKind.BlackPearl:
                return "Perle Noire";
            case MaterialKind.OilOfSlime:
                return "Huile de Slime";
            case MaterialKind.EnchantedCloth:
                return "Tissu de Slime Magique";
            case MaterialKind.SpiderSilk:
                return "Soie d'Araignée";
            case MaterialKind.BatWing:
                return "Aile de Chauve-Souris";
            case MaterialKind.FairyDust:
                return "Poussière de Fée";
            case MaterialKind.FoxTail:
                return "Queue de Renard";
            case MaterialKind.FishScales:
                return "Écailles de Poisson";
            case MaterialKind.CarvedBranch:
                return "Branche Sculptée";
            case MaterialKind.ThickFur:
                return "Fourrure Épaisse";
            case MaterialKind.UnicornHorn:
                return "Corne de Licorne";
            case MaterialKind.SlimeBall:
                return "Boule de Slime";
            case MaterialKind.ManaSeed:
                return "Graine de Mana";
            case MaterialKind.UnmeltingIce:
                return "Glace Éternelle";
            case MaterialKind.EternalFlame:
                return "Flamme Sacrée";
            case MaterialKind.AncientBattery:
                return "Batterie Antique";
            case MaterialKind.Ectoplasm:
                return "Ectoplasme";
            case MaterialKind.Stardust:
                return "Poussière d'Étoile";
            case MaterialKind.VoidEgg:
                return "Oeuf du Vide";
            case MaterialKind.EnchantedShard:
                return "Éclat Enchanté";
        }
        return kind.ToString();
    }
    //Setting
    public override string Toggle(ToggleKind kind)
    {
        switch (kind)
        {
            case ToggleKind.BGM:
                return "Musique";
            case ToggleKind.SFX:
                return "Sons";
            case ToggleKind.DisableDamageText:
                return "Désactiver les Textes de Dégâts";
            case ToggleKind.DisableGoldLog:
                return "Désactiver les Textes de Gain d'Or";
            case ToggleKind.FastResult:
                return "Écourter l'Écran de Résultat de Combat";
            case ToggleKind.ShowDPS:
                return "Montrer les DPS des Capacités";
            case ToggleKind.ShowDetailStats:
                return "Montrer les Stats des PV, PM et EXP";
            case ToggleKind.HideCompletedQuest:
                return "Cacher les Quêtes Complétées";
            case ToggleKind.PerformanceMode:
                return "Mode Performance";
            case ToggleKind.AutoDisassembleExcludeEnchanted:
                return "Exclure les Equipements Enchantés";
            case ToggleKind.DisableCombatRange:
                return "Désactiver la Vision de la Portée des Capactés";
            case ToggleKind.DarkenBattlefield:
                return "Assombrir la Zone de Combat";
            case ToggleKind.BuyOneGuildAbility:
                return "Ignorer le Multiplicateur [ x 1 ]";
            case ToggleKind.BuyOneRebirthUpgrade:
                return "Ignorer le Multiplicateur [ x 1 ]";
            case ToggleKind.SkillLessMPAvailable:
                return "Tenacité de Capacité";
            case ToggleKind.BuyOneWorldAscensionUpgrade:
                return "Ignorer le Multiplicateur [ x 1 ]";
            case ToggleKind.ShowEquipmentStar:
                return "Montrer les Étoiles de Maîtrise d'Équipement dans l'inventaire";
            case ToggleKind.DisableParticle:
                return "Désactiver les Particules";
            case ToggleKind.DisableAttackEffect:
                return "Désactiver les Effets des Attaques";
            case ToggleKind.DisableAnyLog:
                return "Désactiver Tous les Messages de Gains";
            case ToggleKind.BuyOneAreaPrestige1:
                return "Ignorer [ x 1 ]";
            case ToggleKind.BuyOneAreaPrestige2:
                return "Ignorer [ x 1 ]";
            case ToggleKind.SwarmChaser:
                if (game.epicStoreCtrl.Item(EpicStoreKind.SwarmChaser).IsPurchased())
                    return "Chasseur d'Invasion";
                else return "Chasseur d'Invasion (<sprite=\"locks\" index=0> Magasin Épique)";
            case ToggleKind.AdvancedAutoBuyTrap:
                if (game.epicStoreCtrl.Item(EpicStoreKind.AdvancedAutoBuyTraps).IsPurchased())
                    return "Achat de Piège Auto Avancé";
                else return "Achat de Piège Auto Avancé (<sprite=\"locks\" index=0> Magasin Épique)";
            case ToggleKind.DisableNotificationAchievement:
                return "Désactiver les Notifications pour les Succès";
            case ToggleKind.DisableNotificationQuest:
                return "Désactiver les Notifications pour les Quêtes";
            case ToggleKind.DisableNotificationLab:
                return "Désactiver les Notifications pour le Lab";
            case ToggleKind.DisableExpLog:
                return "EXP";
            case ToggleKind.DisableResourceLog:
                return "Ressources";
            case ToggleKind.DisableMaterialLog:
                return "Matériaux";
            case ToggleKind.DisableGuildLog:
                return "EXP/Niveau de Guilde";
            case ToggleKind.DisableCaptureLog:
                return "Capture";
            case ToggleKind.DisableSwarmResult:
                return "Désactiver le Pop-up de Résultat d'Invasion";
            case ToggleKind.DisableNotificationExpedition:
                return "Désactiver les Notifications pour les Expéditions";
            case ToggleKind.FullCost:
                return "Activer l'appui de Maj+F pour montrer les coûts entiers (Max x100)";
            case ToggleKind.DisableLevelUp:
                return "Désactiver le texte et les particules de gain de Niveau de Héros";
            case ToggleKind.ScientificNotifications:
                return "Toujours utiliser la Notation Scientifique";
            case ToggleKind.DisableNotificationSetting:
                return "Désactiver les Notifications pour les Options";
            case ToggleKind.FastResult2:
                return "Accélérer la Fenêtre de Résultat de Combat";
            case ToggleKind.DisableConfirmDungeonEnter:
                return "Désactiver la confirmation pour rentrer dans un donjon";
            case ToggleKind.LockPlaceItemOnSort:
                return "Désactiver le déplacement d'objets verrouillés pendant un tri";
            case ToggleKind.ShowUtilityCooltime:
                return "Afficher le temps de recharge des Objets Utilitaires dans l'aire de combat";
            case ToggleKind.AutoCombineProfScroll:
                return "Combiner l'effet des Parchemins de Maîtrise automatiquement";
            case ToggleKind.AutoCombineAnvil:
                return "Combiner l'effet de l'Enclume";
            case ToggleKind.AutoCacheSave:
                return "Sauvegarde Automatique en Cache (10 sec)";
            case ToggleKind.AutoChooseBlessingFromChest:
                return "Choisir une bénédiction aléatoire lorsqu'un trésor de bénédiction est ouvert";
            case ToggleKind.PurpleFoxDisableLockedItem:
                return "Empêcher le mouvement d'objets verrouillés par l'effet du Familier Renard Violet";
            case ToggleKind.PurpleFoxMastery:
                if (game.epicStoreCtrl.Item(EpicStoreKind.PurpleFoxMastery).IsPurchased())
                    return "Maîtrise du Renard Violet";
                else return "Maîtrise du Renard Violet (<sprite=\"locks\" index=0> Magasin Épique)";
            case ToggleKind.ProfScrollMastery:
                return "Utiliser les Parchemins de Maîtrise jusqu'à la maîtrise (Nv 10) plutôt qu'au niveau max";
            case ToggleKind.HideCompletedChallenge:
                return "Cacher les Défis Compétés";
        }
        return kind.ToString();
    }

    //Rebirth
    public override (string name, string effect, string nextEffect) Rebirth(RebirthUpgrade upgrade)
    {
        string tempName = "";
        string tempEffect = "";
        string tempNextEffect = "";
        switch (upgrade.kind)
        {
            case RebirthUpgradeKind.ExpGain:
                tempName = "Expérience Innée";
                tempEffect = "Multiplie les Gains d'EXP par " + percent(1 + upgrade.effectValue, 0);
                tempNextEffect = "Multiplie les Gains d'EXP par " + percent(1 + upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.EQRequirement:
                tempName = "Force d'Équipement";
                tempEffect = "Augmente le Niveau de Héros effectif pour les équipements par " + tDigit(upgrade.effectValue);
                tempNextEffect = "Augmente le Niveau de Héros effectif pour les équipements par " + tDigit(upgrade.nextEffectValue);
                break;
            case RebirthUpgradeKind.QuestAcceptableNum:
                tempName = "Multitâche";
                tempEffect = "Limite de Quêtes Acceptées + " + tDigit(upgrade.effectValue);
                tempNextEffect = "Limite de Quêtes Acceptées + " + tDigit(upgrade.nextEffectValue);
                break;
            case RebirthUpgradeKind.BasicAtk:
                tempName = "ATQ Basique";
                tempEffect = "ATQ + " + tDigit(upgrade.effectValue, 2) + " par Niveau de Héros";
                tempNextEffect = "ATQ + " + tDigit(upgrade.nextEffectValue, 2) + " par Niveau de Héros";
                break;
            case RebirthUpgradeKind.BasicMAtk:
                tempName = "MATQ Basique";
                tempEffect = "MATQ + " + tDigit(upgrade.effectValue, 2) + " par Niveau de Héros";
                tempNextEffect = "MATQ + " + tDigit(upgrade.nextEffectValue, 2) + " par Niveau de Héros";
                break;
            case RebirthUpgradeKind.BasicHp:
                tempName = "PV Basique";
                tempEffect = "PV + " + tDigit(upgrade.effectValue, 2) + " par Niveau de Héros";
                tempNextEffect = "PV + " + tDigit(upgrade.nextEffectValue, 2) + " par Niveau de Héros";
                break;
            case RebirthUpgradeKind.BasicDef:
                tempName = "DEF Basique";
                tempEffect = "DEF + " + tDigit(upgrade.effectValue, 2) + " par Niveau de Héros";
                tempNextEffect = "DEF + " + tDigit(upgrade.nextEffectValue, 2) + " par Niveau de Héros";
                break;
            case RebirthUpgradeKind.BasicMDef:
                tempName = "MDEF Basique";
                tempEffect = "MDEF + " + tDigit(upgrade.effectValue, 2) + " par Niveau de Héros";
                tempNextEffect = "MDEF + " + tDigit(upgrade.nextEffectValue, 2) + " par Niveau de Héros";
                break;
            case RebirthUpgradeKind.BasicMp:
                tempName = "PM Basique";
                tempEffect = "PM + " + tDigit(upgrade.effectValue, 2) + " par Niveau de Héros";
                tempNextEffect = "PM + " + tDigit(upgrade.nextEffectValue, 2) + " par Niveau de Héros";
                break;
            case RebirthUpgradeKind.StoneGain:
                tempName = "Meilleure Extraction";
                tempEffect = "Gain de Pierre + " + percent(upgrade.effectValue);
                tempNextEffect = "Gain de Pierre + " + percent(upgrade.nextEffectValue);
                break;
            case RebirthUpgradeKind.CrystalGain:
                tempName = "Meilleure Cristallisation";
                tempEffect = "Gain de Cristal + " + percent(upgrade.effectValue);
                tempNextEffect = "Gain de Cristal + " + percent(upgrade.nextEffectValue);
                break;
            case RebirthUpgradeKind.LeafGain:
                tempName = "Meilleure Cueillette";
                tempEffect = "Gain de Feuille + " + percent(upgrade.effectValue);
                tempNextEffect = "Gain de Feuille + " + percent(upgrade.nextEffectValue);
                break;
            case RebirthUpgradeKind.StoneGoldCap:
                tempName = "Limite d'Or Rocheuse";
                tempEffect = "Stone Gold Cap Upgrade's effect + " + percent(upgrade.effectValue);
                tempNextEffect = "Stone Gold Cap Upgrade's effect + " + percent(upgrade.nextEffectValue);
                break;
            case RebirthUpgradeKind.CrystalGoldCap:
                tempName = "Limite d'Or Cristallique";
                tempEffect = "Crystal Gold Cap Upgrade's effect + " + percent(upgrade.effectValue);
                tempNextEffect = "Crystal Gold Cap Upgrade's effect + " + percent(upgrade.nextEffectValue);
                break;
            case RebirthUpgradeKind.LeafGoldCap:
                tempName = "Limite d'Or Végétale";
                tempEffect = "Leaf Gold Cap Upgrade's effect + " + percent(upgrade.effectValue);
                tempNextEffect = "Leaf Gold Cap Upgrade's effect + " + percent(upgrade.nextEffectValue);
                break;
            case RebirthUpgradeKind.SkillProfGain:
                tempName = "Maîtrise de Capacité X";
                tempEffect = "Multiply Skill Proficiency Gain by " + percent(1 + upgrade.effectValue, 0);
                tempNextEffect = "Multiply Skill Proficiency Gain by " + percent(1 + upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.SkillRankCostReduction:
                tempName = "Apprentissage Aisé";
                tempEffect = "Réduit le coût de Rang de Capacité par " + percent(upgrade.effectValue, 4, true);
                tempNextEffect = "Reduce skill's Rank cost to " + percent(upgrade.nextEffectValue, 4, true);
                break;
            case RebirthUpgradeKind.ClassSkillSlot:
                tempName = "Prodige";
                tempEffect = "Emplacement de Capacité de Classe + " + tDigit(upgrade.effectValue, 0);
                tempNextEffect = "Emplacement de Capacité de Classe + " + tDigit(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.ShareSkillPassive:
                tempName = "Partage de Connaissances";
                tempEffect = "Partage " + percent(upgrade.effectValue) + " des Effets Passifs des Capacité avec les autres héros";
                tempNextEffect = "Partage " + percent(upgrade.nextEffectValue) + " des Effets Passifs des Capacité avec les autres héros";
                break;
            case RebirthUpgradeKind.T1ExpGainBoost:
                tempName = "Expérience Innée +";
                tempEffect = "Effet d'[Expérience Innée] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet d'[Expérience Innée] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1RebirthPointGainBoost:
                tempName = "Réincarnation Profonde 1";
                tempEffect = "Gains de Points de Réincarnation de Classe 1 + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Gains de Points de Réincarnation de Classe 1 + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1BasicAtkBoost:
                tempName = "ATQ Basique +";
                tempEffect = "Effet d'[ATQ Basique] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet d'[ATQ Basique] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1BasicMAtkBoost:
                tempName = "MATQ Basique +";
                tempEffect = "Effet de [MATQ Basique] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [MATQ Basique] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1BasicHpBoost:
                tempName = "PV Basique +";
                tempEffect = "Effet de [PV Basique] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [PV Basique] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1BasicDefBoost:
                tempName = "DEF Basique +";
                tempEffect = "Effet de [DEF Basique] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [DEF Basique] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1BasicMDefBoost:
                tempName = "MDEF Basique +";
                tempEffect = "Effet de [MDEF Basique] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [MDEF Basique] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1BasicMpBoost:
                tempName = "PM Basique +";
                tempEffect = "Effet de [PM Basique] +" + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [PM Basique] +" + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1StoneGainBoost:
                tempName = "Meilleure Extraction +";
                tempEffect = "Effet de [Meilleure Extraction] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Meilleure Extraction] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1CrystalGainBoost:
                tempName = "Meilleure Cristallisation +";
                tempEffect = "Effet de [Meilleure Cristallisation] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Meilleure Cristallisation] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1LeafGainBoost:
                tempName = "Meilleure Cueillette +";
                tempEffect = "Effet de [Meilleure Cueillette] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Meilleure Cueillette] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1StoneGoldCapBoost:
                tempName = "Limite d'Or Rocheuse +";
                tempEffect = "Effet de [Limite d'Or Rocheuse] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Limite d'Or Rocheuse] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1CrystalGoldCapBoost:
                tempName = "Limite d'Or Cristallique +";
                tempEffect = "Effet de [Limite d'Or Cristallique] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Limite d'Or Cristallique] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1LeafGoldCapBoost:
                tempName = "Limite d'Or Végétale +";
                tempEffect = "Effet de [Limite d'Or Végétale] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Limite d'Or Végétale] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.EQLevelCap:
                tempName = "Transcendance d'Équipement";
                tempEffect = "Augmente la Limite de Niveau des Équipements par " + tDigit(upgrade.effectValue, 0);
                tempNextEffect = "Augmente la Limite de Niveau des Équipements par " + tDigit(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.EQProfGain:
                tempName = "Maître d'Équipement";
                tempEffect = "Multiplie les Gains de Maîtrise d'Équipement par " + percent(1 + upgrade.effectValue, 0);
                tempNextEffect = "Multiplie les Gains de Maîtrise d'Équipement par " + percent(1 + upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.EQWeaponSlot:
                tempName = "Armé Jusqu'au Dents";
                tempEffect = "Emplacement d'Arme + " + tDigit(upgrade.effectValue, 0);
                tempNextEffect = "Emplacement d'Arme + " + tDigit(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.EQArmorSlot:
                tempName = "Protection Maximale";
                tempEffect = "Emplacement d'Armure + " + tDigit(upgrade.effectValue, 0);
                tempNextEffect = "Emplacement d'Armure + " + tDigit(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.EQJewelrySlot:
                tempName = "Bling-Bling";
                tempEffect = "Emplacement de Bijou + " + tDigit(upgrade.effectValue, 0);
                tempNextEffect = "Emplacement de Bijou + " + tDigit(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2ExpGainBoost:
                tempName = "Expérience Innée ++";
                tempEffect = "Effet d'[Expérience Innée +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet d'[Expérience Innée +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2RebirthPointGainBoost:
                tempName = "Réincarnation Profonde 2";
                tempEffect = "Tier 2 Rebirth Point Gain + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Tier 2 Rebirth Point Gain + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2BasicAtkBoost:
                tempName = "ATQ Basique ++";
                tempEffect = "Effet d'[ATQ Basique +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet d'[ATQ Basique +]  + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2BasicMAtkBoost:
                tempName = "MATQ Basique ++";
                tempEffect = "Effet de [MATQ Basique +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [MATQ Basique +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2BasicHpBoost:
                tempName = "PV Basique ++";
                tempEffect = "Effet de [PV Basique +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [PV Basique +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2BasicDefBoost:
                tempName = "DEF Basique ++";
                tempEffect = "Effet de [DEF Basique +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [DEF Basique +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2BasicMDefBoost:
                tempName = "MDEF Basique ++";
                tempEffect = "Effet de [MDEF Basique +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [MDEF Basique +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2BasicMpBoost:
                tempName = "PM Basique ++";
                tempEffect = "Effet de [PM Basique +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [PM Basique +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2StoneGainBoost:
                tempName = "Meilleure Extraction ++";
                tempEffect = "Effet de [Meilleure Extraction +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Meilleure Extraction +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2CrystalGainBoost:
                tempName = "Meilleure Cristallisation ++";
                tempEffect = "Effet de [Meilleure Cristallisation +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Meilleure Cristallisation +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2LeafGainBoost:
                tempName = "Meilleure Cueillette ++";
                tempEffect = "Effet de [Meilleure Cueillette +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Meilleure Cueillette +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2StoneGoldCapBoost:
                tempName = "Limite d'Or Rocheuse ++";
                tempEffect = "Effet de [Limite d'Or Rocheuse +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Limite d'Or Rocheuse +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2CrystalGoldCapBoost:
                tempName = "Limite d'Or Cristallique ++";
                tempEffect = "Tier 2 Crystal Gold Cap Booster's effect + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Tier 2 Crystal Gold Cap Booster's effect + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2LeafGoldCapBoost:
                tempName = "Limite d'Or Végétale ++";
                tempEffect = "Effet de [Limite d'Or Végétale +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Limite d'Or Végétale +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2SkillProfGainBoost:
                tempName = "Maître d'Équipement +";
                tempEffect = "Effet de [Maître d'Équipement] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Maître d'Équipement] + " + percent(upgrade.nextEffectValue, 0);
                break;
        }
        if (upgrade.level.IsMaxed()) tempNextEffect = Basic(BasicWord.Level) + " Max";
        else tempNextEffect += " ( <color=green>Nv " + tDigit(upgrade.transaction.ToLevel()) + "</color> )";
        return (tempName, tempEffect, tempNextEffect);
    }
    //RebirthPoint
    public override string RebirthPointGain(Rebirth rebirth)
    {
        string tempString = "Vous gagnez <color=green>" + tDigit(rebirth.RebirthPointGain()) + " Points de Réincarnation </color> de " + " Classe " + tDigit(rebirth.tier + 1) + " si vous vous réincarnez maintenant !";
        for (int i = 0; i < rebirth.rebirthPointKinds.Count; i++)
        {
            int count = i;
            tempString += "\n- " + RebirthPointGainKind(rebirth.rebirthPointKinds[count]) + " : " + tDigit(rebirth.RebirthPointGain(rebirth.rebirthPointKinds[count]), 1) + "</color>";
        }
        return tempString;
    }
    //RebirthPoint
    public override string RebirthPointGainKind(RebirthPointKind kind)
    {
        switch (kind)
        {
            case RebirthPointKind.HeroLevel:
                return "Niveau du Héros";
            case RebirthPointKind.Quest:
                return "Quête Générale";
            case RebirthPointKind.Move:
                return "Dsitance Parcourue";
            case RebirthPointKind.SkillLevel:
                return "Niveau des Capacités";
            case RebirthPointKind.EQLevel:
                return "Niveau d'Équipement";
        }
        return kind.ToString();
    }
    //RebirthInfo
    public override string RebirthInfo(Rebirth rebirth)
    {
        string tempString = Hero(rebirth.heroKind);
        tempString += "\nRéincarnation de Classe " + tDigit(1 + rebirth.tier) + " # <color=green>" + tDigit(rebirth.rebirthNum) + "</color>";
        tempString += "\nNiveau de Héros Max Atteint : <color=green>Nv " + tDigit(rebirth.maxHeroLevel) + "</color>";
        switch (rebirth.tier)
        {
            case 0://Tier1
                tempString += "\nPoints d'Abilité Additionnels : <color=green>" + tDigit(rebirth.additionalAbilityPoint.Value()) + "</color>";
                break;
            case 1://Tier2
                tempString += "\nPoints d'Abilité Additionnels : <color=green>" + tDigit(rebirth.additionalAbilityPoint.Value()) + " tous les 25èmes Niveaux de Héros</color>";
                tempString += "\nEffet Bonus de Réincarnation de Classe 1 : <color=green>+ " + percent(rebirth.bonusEffectFactorOneDownTier.Value()) + "</color>";
                break;
            case 2://Tier3
                tempString += "\nNiveau de Capacité Initial : <color=green>" + tDigit(rebirth.additionalAbilityPoint.Value()) + "</color>";
                tempString += "\nEffet Bonus de Réincarnation de Classe 2 : <color=green>+ " + percent(rebirth.bonusEffectFactorOneDownTier.Value()) + "</color>";
                break;
        }
        return tempString;
    }
    //AutoRebirthInfo
    public override string AutoRebirthInfo(int id)
    {
        switch (id)
        {
            case 0: return "Performe une Réincarnation automatiquement";
            case 1: return "à                          Points de Réincarnation ou plus quand le héros est <color=green>Nv</color>                      ou plus";
            case 2: return "- Zone Favorite\nAprès une Réincarnation, vous commencerez à ";
            case 3: return "Aller à la meilleure zone de gain d'EXP/sec tous les 25èmes Niveaux de Héros. <size=16>( Seulement valide pour le héros courant )";
        }
        return "";
    }

    //Challenge
    public override string ChallengeType(ChallengeType type)
    {
        switch (type)
        {
            case global::ChallengeType.RaidBossBattle:
                return "Boss de Raid";
            case global::ChallengeType.SingleBossBattle:
                return "Boss Solo";
            case global::ChallengeType.HandicappedBattle:
                return "Boss avec Handicap";
            case global::ChallengeType.SuperDungeon:
                return "Super Donjon";
        }
        return type.ToString();
    }
    //ChallengeHandicap
    public override string HandicapString(ChallengeHandicapKind kind)
    {
        switch (kind)
        {
            case ChallengeHandicapKind.OnlyWeapon:
                return "Seules les Armes sont équipées";
            case ChallengeHandicapKind.OnlyArmor:
                return "Seules les Armures sont équipées";
            case ChallengeHandicapKind.OnlyJewelry:
                return "Seuls les Bijoux sont équipés";
            case ChallengeHandicapKind.Only1EQforAllPart:
                return "Seulement un Équipement de chaque catégorie peut être équipé";
            case ChallengeHandicapKind.Only1Weapon:
                return "Seule une Arme est équipée";
            case ChallengeHandicapKind.Only1Armor:
                return "Seule une Armure est équipée";
            case ChallengeHandicapKind.Only1Jewelry:
                return "Seul un Bijou est équipé";
            case ChallengeHandicapKind.NoEQ:
                return "Aucun Équipement ne peut être équipé";
            case ChallengeHandicapKind.OnlyClassSkill:
                return "Seuls les Emplacements de Capacité de Classe sont disponibles";
            case ChallengeHandicapKind.OnlyBaseAndGlobal:
                return "Seuls les Emplacements de Capacité Globaux sont disponibles";
            case ChallengeHandicapKind.Only2ClassSkillAnd1Global:
                return "Seuls deux Emplacements de Capacité de Classe et un Emplacement de Capacité Global sont disponibles";
            case ChallengeHandicapKind.Only2ClassSkill:
                return "Seuls deux Emplacements de Capacité de Classe sont disponibles";
            case ChallengeHandicapKind.OnlyBaseSkill:
                return "Seule l'Attaque de Base est disponible";
            case ChallengeHandicapKind.DamageLimit:
                return "Les dégâts de toutes les attaques sont limités à 1";
            case ChallengeHandicapKind.DisableManualMove:
                return "Le mouvement manuel est désactivé";
        }
        return kind.ToString();
    }

    //ExpeditionMilestone
    public override string ExpeditionMilestoneString(int id)
    {
        switch (id)
        {
            case 0: return "Débloque une Équipe d'Expédition";
            case 1: return "Palier d'Expédition Nv 10";
            case 2: return "Débloque une Nouvelle Expédition Lointaine";
            case 3: return "Débloque une Équipe d'Expédition";
            case 4: return "Palier d'Expédition Nv 20";
            case 5: return "Débloque une Nouvelle Expédition Lointaine";
            case 6: return "Débloque une Équipe d'Expédition";
            case 7: return "Palier d'Expédition Nv 50";
            case 8: return "Débloque une Nouvelle Expédition Lointaine";
            case 9: return "Palier d'Expédition Nv 75";
            case 10: return "Débloque une Nouvelle Expédition Lointaine";
        }
        return "";
    }

    //AreaMissionMilestone
    public override string MissionMilestoneString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Gain d'EXP + 20%";
            case 1: return "Gain de Maîtrise d'Équipement + 10%";
            case 2: return "Gain de Matériaux de Ville + 50%";
            case 3: return "Emplacement d'Inventaire d'Équipement + 10";
            case 4: return "Gain d'EXP + 30%";
            case 5: return "Limite d'Or + " + text;
            case 6: return "Gain de Maîtrise d'Equipement + 20%";
            case 7: return "Gain d'Eau Mystérieuse + 50%";
            case 8: return "Emplacement d'Inventaire d'Équipement + 10";
            case 9: return "Gain de Matériaux de Ville + 50%";
            case 10: return "Gain de Ressources + " + text;
            case 11: return "Gain d'Or + 50%";
            case 12: return "Gain d'EXP + 50%";
            case 13: return "Multiplie la Chance d'Apparition de Matériau Rare par 150%";
            case 14: return "Emplacement de Capacité Global + 1";
            case 15: return "Gain d'EXP dans les Expéditions + 100%";
            case 16: return "Gain de Points d'Alchimie + 100%";
            case 17: return "Montant des Récompenses d'Expédition + 25%";
            case 18: return "Gain de Ressources + 1000%";
            case 19: return "Réduit le Coût des Améliorations Générales par " + text;
            case 20: return "Emplacement d'Inventaire d'Enchantement + 10";
            case 21: return "Emplacement de Tenue d'Équipement + 1";
            case 22: return "Gain de Maîtrise de Capacité + 100%";
            case 23: return "Limite d'Or + 100%";
            case 24: return "Gain d'Or + 100%";
            case 25: return "Efficacité des Pièces Slime + 25%";
            case 26: return "Emplacement d'Inventaire d'Enchantement + 10";
            case 27: return "Effet des Béndictions + 100%";
            case 28: return "Emplacement de Familier Actif + 5";
            case 29: return "Limite de Niveau des Catalystes + 25";
            case 30: return "Emplacement de Set de Capacité + 1";
            case 31: return "Niveau de Bâtiment de Ville + " + text;
            case 32: return "Limite de Loyauté de Familier + " + text;
            case 33: return "Améliore l'effet des améliorations de Gain de Ressources";
            case 34: return "Réduit l'incrément du coût par Nv des améliorations de Gain de Ressources par " + text;
        }
        return "";
    }

    //WorldAscensionMissions
    public override string AscensionMissionString(int id, string str1 = "")
    {
        switch (id)
        {
            case 0: return "Effectuer la Réincarnation de Classe 1 de n'importe quel héros en 3 heures ou moins";
            case 1: return "Effectuer la Réincarnation de Classe 1 de n'importe quel héros en 1 heure ou moins";
            case 2: return "Effectuer la Réincarnation de Classe 1 de n'importe quel héros en 20 minutes ou moins";
            case 3: return "Effectuer la Réincarnation de Classe 1 de n'importe quel héros en 5 minutes ou moins";
            case 4: return "Effectuer la Réincarnation de Classe 2 de n'importe quel héros en 3 heures ou moins";
            case 5: return "Effectuer la Réincarnation de Classe 2 de n'importe quel héros en une heure ou moins";
            case 6: return "Effectuer la Réincarnation de Classe 2 de n'importe quel héros en 20 minutes ou moins";
            case 7: return "Effectuer la Réincarnation de Classe 2 de n'importe quel héros en 5 minutes ou moins";
            case 8: return "Effectuer la Réincarnation de Classe 3 de n'importe quel héros en 8 heures ou moins";
            case 9: return "Effectuer la Réincarnation de Classe 3 de n'importe quel héros en 3 heures ou moins";
            case 10: return "Effectuer la Réincarnation de Classe 3 de n'importe quel héros en une heure ou moins";
            case 11: return "Effectuer la Réincarnation de Classe 3 de n'importe quel héros en 20 minutes ou moins";
            case 12: return "Effectuer la Réincarnation de Classe 3 de n'importe quel héros en 5 minutes ou moins";
            case 13: return "Vaincre le Boss de Raid [Florzporbe Nv 100] en 8 heures ou moins";
            case 14: return "Vaincre le Boss de Raid [Florzporbe Lv 100] en 3 heures ou moins";
            case 15: return "Vaincre le Boss de Raid [Florzporbe Lv 100] en une heure ou moins";
            case 16: return "Vaincre le Boss de Raid [Florzporbe Lv 100] en 20 minutes ou moins";
            case 17: return "Vaincre le Boss de Raid [Florzporbe Lv 100] en 5 minutes ou moins";
            case 18: return "Vaincre le Boss de Raid [Aranetta Lv 150] en 8 heures ou moins";
            case 19: return "Vaincre le Boss de Raid [Aranetta Lv 150] en 3 heures ou moins";
            case 20: return "Vaincre le Boss de Raid [Aranetta Lv 150] en une heure ou moins";
            case 21: return "Vaincre le Boss de Raid [Aranetta Lv 150] en 20 minutes ou moins";
            case 22: return "Vaincre le Boss de Raid [Aranetta Lv 150] en 5 minutes ou moins";
            case 23: return "Vaincre le Boss de Raid [Gardien Kor Lv 200] en 8 heures ou moins";
            case 24: return "Vaincre le Boss de Raid [Gardien Kor Lv 200] en 3 heures ou moins";
            case 25: return "Vaincre le Boss de Raid [Gardien Kor Lv 200] en une heure ou moins";
            case 26: return "Vaincre le Boss de Raid [Gardien Kor Lv 200] en 20 minutes ou moins";
            case 27: return "Vaincre le Boss de Raid [Gardien Kor Lv 200] en 5 minutes ou moins";
            case 28: return "Vaincre le Boss de Raid [" + str1 + "] en 8 heures ou moins";
            case 29: return "Vaincre le Boss de Raid [" + str1 + "] en 3 heures ou moins";
            case 30: return "Vaincre le Boss de Raid [" + str1 + "] en une heure ou moins";
            case 31: return "Vaincre le Boss de Raid [" + str1 + "] en 20 minutes ou moins";
            case 32: return "Vaincre le Boss de Raid [" + str1 + "] en 5 minutes ou moins";
            case 33: return "Atteindre le Niveau de Guilde 10 en 5 minutes ou moins";
            case 34: return "Atteindre le Niveau de Guilde 15 en 20 minutes ou moins";
            case 35: return "Atteindre le Niveau de Guilde 15 en 5 minutes ou moins";
            case 36: return "Atteindre le Niveau de Guilde 20 en une heure ou moins";
            case 37: return "Atteindre le Niveau de Guilde 20 en 20 minutes ou moins";
            case 38: return "Atteindre le Niveau de Guilde 20 en 5 minutes ou moins";
            case 39: return "Atteindre le Niveau de Guilde 25 en 3 heures ou moins";
            case 40: return "Atteindre le Niveau de Guilde 25 en une heure ou moins";
            case 41: return "Atteindre le Niveau de Guilde 25 en 20 minutes ou moins";
            case 42: return "Atteindre le Niveau de Guilde 25 en 5 minutes ou moins";
            case 43: return "Atteindre le Niveau de Guilde 30 en 8 heures ou moins";
            case 44: return "Atteindre le Niveau de Guilde 30 en 3 heures ou moins";
            case 45: return "Atteindre le Niveau de Guilde 30 en une heure ou moins";
            case 46: return "Atteindre le Niveau de Guilde 30 en 20 minutes ou moins";
            case 47: return "Atteindre le Niveau de Guilde 30 en 5 minutes ou moins";
            case 48: return "Atteindre le Niveau de Guilde 35 en 24 heures ou moins";
            case 49: return "Atteindre le Niveau de Guilde 35 en 8 heures ou moins";
            case 50: return "Atteindre le Niveau de Guilde 35 en 3 heures ou moins";
            case 51: return "Atteindre le Niveau de Guilde 35 en une heure ou moins";
            case 52: return "Atteindre le Niveau de Guilde 35 en 20 minutes ou moins";
            case 53: return "Atteindre le Niveau de Guilde 35 en 5 minutes ou moins";
            case 54: return "Atteindre le Niveau de Guilde 40 en 24 heures ou moins";
            case 55: return "Atteindre le Niveau de Guilde 40 en 8 heures ou moins";
            case 56: return "Atteindre le Niveau de Guilde 40 en 3 heures ou moins";
            case 57: return "Atteindre le Niveau de Guilde 40 en une heure ou moins";
            case 58: return "Atteindre le Niveau de Guilde 40 en 20 minutes ou moins";
            case 59: return "Atteindre le Niveau de Guilde 40 en 5 minutes ou moins";
            case 60: return "Atteindre le Niveau de Guilde 45 en 24 heures ou moins";
            case 61: return "Atteindre le Niveau de Guilde 45 en 8 heures ou moins";
            case 62: return "Atteindre le Niveau de Guilde 45 en 3 heures ou moins";
            case 63: return "Atteindre le Niveau de Guilde 45 en une heure ou moins";
            case 64: return "Atteindre le Niveau de Guilde 45 en 20 minutes ou moins";
            case 65: return "Atteindre le Niveau de Guilde 45 en 5 minutes ou moins";
            case 66: return "Atteindre le Niveau de Guilde 50 en 24 heures ou moins";
            case 67: return "Atteindre le Niveau de Guilde 50 en 8 heures ou moins";
            case 68: return "Atteindre le Niveau de Guilde 50 en 3 heures ou moins";
            case 69: return "Atteindre le Niveau de Guilde 50 en une heure ou moins";
            case 70: return "Atteindre le Niveau de Guilde 50 en 20 minutes ou moins";
            case 71: return "Atteindre le Niveau de Guilde 50 en 5 minutes ou moins";
            case 72: return "Atteindre le Niveau de Guilde " + str1 + " en 24 heures ou moins";
            case 73: return "Atteindre le Niveau de Guilde " + str1 + " en 8 heures ou moins";
            case 74: return "Atteindre le Niveau de Guilde " + str1 + " en 3 heures ou moins";
            case 75: return "Atteindre le Niveau de Guilde " + str1 + " en une heure ou moins";
            case 76: return "Atteindre le Niveau de Guilde " + str1 + " en 20 minutes ou moins";
            case 77: return "Atteindre le Niveau de Guilde " + str1 + " en 5 minutes ou moins";
            case 78: return "Les Équipements Uniques sont préservés sont préservés lors d'une Ascension Monde";
            case 79: return "Le Niveau des Catalystes est préservé lors d'une Ascension Monde";
            case 80: return "Les objets dans l'Inventaire d'Enchantement sont préservés lors d'une Ascension Monde";
            case 81: return "Le Rang de la Statue des Héros est préservé lors d'une Ascension Monde";
            case 82: return "Le Rang du Cartographeur est préservé lors d'une Ascension Monde";
            case 83: return "Le Rang de la Hutte de l'Alchimiste est préservé lors d'une Ascension Monde";
            case 84: return "Le Rang du Trappeur est préservé lors d'une Ascension Monde";
            case 85: return "Le Rang du Temple est préservé lors d'une Ascension Monde";
            case 86: return "Le Rang de la Forge est préservé lors d'une Ascension Monde";
            case 87: return "Le Rang de la Banque Slime est préservé lors d'une Ascension Monde";
            case 88: return "Le Rang de l'Arène Mystique est préservé lors d'une Ascension Monde";
            case 89: return "Le Rang du Chercheur Arcanique est préservé lors d'une Ascension Monde";
            case 90: return "Le Rang de l'Équipe d'Aventuriers est préservé lors d'une Ascension Monde";
            case 91: return "Le Rang du Dojo est préservé lors d'une Ascension Monde";
            case 92: return "Le Rang de la Taverne est préservé lors d'une Ascension Monde";
            case 93: return "Les zones " + str1 + " débloquées et leur # de Complétions sont préservés";
        }
        return "";
    }

    public override string WarriorSkillsString(int id)
    {
        switch (id)
        {
            case 0: return "Nombre de Coups de cette Capacité + 1";
            case 1: return "Consommation de PM de cette Capacité -50%";
            case 2: return "Portée de l'Effet de cette Capacité + ";
            case 3: return "Temps de Recharge de cette Capacité -50%";
            case 4: return "Enlève la Consommation de PM de cette Capacité";
            case 5: return "Portée de cette Capacité + ";
            case 6: return "Temps de Recharge de cette Capacité -25%";
            case 7: return "À Définir";
            case 8: return "Dégâts de cette capacité +50% par mètre parcouru";
            case 9: return "Effectue une charge rapide vers la cible pour attaquer.";
        }
        return "";
    }

    public override string WizardSkillsString(int id)
    {
        switch (id)
        {
            case 0: return "Portée de l'Effet de cette Capacité + ";
            case 1: return "Nombre de Coups de cette Capacité + 1";
            case 2: return "Portée de l'Effet de cette Capacité + ";
            case 3: return "Consommation de PM de cette Capacité -50%";
            case 4: return "Gain de PM de cette Capacité + 100%";
            case 5: return "Temps de Recharge de cette Capacité -50%";
            case 6: return "À Définir";
        }
        return "";
    }

    public override string AngelSkillsString(int id, double value = 0)
    {
        switch (id)
        {
            case 0: return "Cette Capacité créée un projectile supplémentaire";
            case 1: return "25% de chance de doubler le nombre de PV soignés à chaque utilisation";
            case 2: return "25% de chance de soigner les débuffs à chaque utilisation";
            case 3: return "5% de chance de soigner 10% des PV Max en plus";
            case 4: return "0.5% de chance de soigner complètement à chaque utilisation";
            case 5: return "Régénération de PV + " + tDigit(value, 1) + " / sec tant que cette Capacité est équipée";
            case 6: return "+" + percent(value, 2) + " de Nullifier les Dégâts Physiques tant que cette Capacité est équipée";
            case 7: return "Vitesse + " + percent(value) + " tant que cette Capacité est équipée";
            case 8: return "+50% de dégats pour cette Capacité par mètre parcouru";
            case 9: return "Portée de l'Effet de cette Capacité + ";
            case 10: return "Nombre de Coups de cette Capacité + 1";
            case 11: return "Temps de Recharge de cette Capacité -25%";
            case 12: return "À Définir";
            case 13: return "Résistance aux Débuffs +" + percent(value, 2) + " tant que cette Capacité est équipée";
        }
        return "";
    }

    public override string ThiefSkillsString(int id, double value = 0)
    {
        switch (id)
        {
            case 0: return "Nombre de Coups de cette Capacité + 1";
            case 1: return "Chance de Coup Critique Physique +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 2: return "Cette Capacité a maintenant une attaque transperçante";
            case 3: return "Dégâts de cette Capacité";
            case 4: return "Chance de Coup Critique Magique +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 5: return "Chance de Vol";
            case 6: return "Portée de l'Effet de cette Capacité + ";
            case 7: return "À Définir";
            case 8: return "Chance de Coup Critique de cette Capacité : ";
            case 9: return "Disparait momentanément et apparait de nouveau près de l'ennemi le plus éloigné pour lui ingliger des dégats";
            case 10: return " chance de voler un matériau laché à chaque utilisation";
        }
        return "";
    }

    public override string ArcherSkillsString(int id, double value = 0)
    {
        switch (id)
        {
            case 0: return "Nombre de Coups de cette Capacité + 1";
            case 1: return "Dégâts Physiques +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 2: return "Enables a penetrating attack for this skill";
            case 3: return "À Définir";
            case 4: return "Tire plusieurs flèches qui vise tous les monstres sur le champ de bataille";
            case 5: return "Dégâts d'Électricité +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 6: return "Dégâts de Glace +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 7: return "Tire une flèche de glace perçante vers le monstre le plus éloigné";
            case 8: return "Dégâts de Feu +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 9: return "Dégats de Lumière +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 10: return "Dégâts des Ténèbres +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 11: return "Tire une flèche vers le centre qui attire tous les ennemis à l'écran vers celle-ci";
            case 12: return "Permet de se déplacer aux bords de l'écran pour échapper à la portée au corps à corps des ennemies avec une pénalité de vitesse dans le mode Mouvement Auto";
        }
        return "";
    }

    public override string TamerSkillsString(int id, double value = 0)
    {
        switch (id)
        {
            case 0: return "Emplacements d'Invocation de Familier +" + tDigit(value, 0) + " Pet Summon Slot tant que cette Capacité est équipée";
            case 1: return "Permet d'invoquer des familiers\n- Multiplicateur de l'Attaque de Base des Familiers : ";
            case 2: return "Multiplie le Multiplicateur de Dégâts de cette Capacité par ";
            case 3: return "Donne aux familiers un ordre d'attaquer peu importe leur temps de recharge\n- PMultiplicateur de l'Attaque des Familiers : ";
            case 4: return "Donne aux familiers un ordre pour qu'ils se ruent vers des ennemis aléatoires\n- Multiplicateur de l'Attaque des Familiers : ";
            case 5: return "Donne aux familiers un ordre pour revenir près du héros et attaquer le monstre le plus près du héros\n- Multiplicateur de l'Attaque des Familiers : ";
            case 6: return "25% de chance de doubler le nombre de PV soignés à chaque utilisation";
            case 7: return "25% de chance de soigner les débuffs à chaque utilisation";
            case 8: return "5% de chance de soigner 10% des PV Max en plus";
            case 9: return "0.5% de chance de soigner complètement à chaque utilisation";
            case 10: return "Soigne les PV des familiers";
            case 11: return "Effets de chance de cette Capacité + ";
            case 12: return " chance que tous les familiers utilisent une capacité aléatoire équipée par le héros tous les ";
            case 13: return "\n- Les familiers n'utilisent aucun PM pour lancer utiliser une capacité peu importe son temps de recharge";
            case 14: return "\n- Taux de Gain de Maîtrise de Capacité pour chaque utilisation par un familier : ";
            case 15: return "Chance de Coup Critique des Familiers +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 16: return "ATQ & MATQ des Familiers : + ";
            case 17: return "Chance de Coup Critique des Familiers +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 18: return "Vitesse & Vitesse d'Attaque des Familiers + ";
            case 19: return "Gain de Points de Loyauté +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 20: return "Gain d'EXP des Familiers : + ";
            case 21: return "À Définir";
            case 22: return " chance de capturer le monstre cible sans utiliser de piège à chaque utilisation ( + ";
            case 23: return "\n- Pour la capture, le piège adapté doit être débloqué dans le Magasin et l'ennemi doit être à un niveau capturable";
        }
        return "";
    }

    public override string BattleControllerUIString(int id)
    {
        switch (id)
        {
            case 0: return "Auto Récolte des Ressources";
            case 1: return "Auto Récolte de Matériaux";
            case 2: return "Auto Récolte d'Équipement";
            case 3: return "Auto Capture de Monstre";
            case 4: return "Auto Réessayer les Donjons";
            case 5: return "Ouverture de Coffre Auto";
            case 6: return "Dif. ";
            case 7: return "Invasion !!";
            case 8: return "Choisissez une bénédiction !";
            case 9: return "Durée";
            case 10: return "<size=18>Réinitialiser les améliorations suivantes est possible ";
            case 11: return " fois plus";
            case 12: return "Magasin Épique [Réinitialisation de Prestige de Zone/Donjon]";
            case 13: return "Total Complété #";
            case 14: return "Difficulté ";
            case 15: return "Améliorations de Prestige de Zone  ( Points : ";
            case 16: return "MAX";
            case 17: return "récompense unique";
            case 18: return "Niveau + !!!";
            case 19: return "Vous vous êtes Réincarné !";
            case 20: return "Dégâts vers vous";
            case 21: return "DPS";
            case 22: return "<size=20>Convocation<size=18>\n- Cliquer pour convoquer tous les héros passifs en arrière-plan.\n- Vous ne pouvez pas utiliser ceci dans un Donjon ou un Défi.";
            case 23: return "Maj + Clic pour déplacer tous les héros dans leur zone favorite.";
            case 24: return "Magasin Épique [ Convocation ]";
            case 25: return "Bâtiment [Cartographeur] Nv ";
            case 26: return " INVASIONS DE MONTRE EN COURS !";
            case 27: return " ( cliquer pour y aller )";
            case 28: return "Monstres Apparus";
            case 29: return "x ( Minimum";
            case 30: return "# de Complétions de Zone restantes";
            case 31: return "Temps Restant";
            case 32: return "Vous avez besoin de ";
            case 33: return " "; //only Japanese uses this one.
            case 34: return " pour rentrer dans ce donjon";
            case 35: return "Chance d'Apparition d'Équipement Unique";
            case 36: return "Atteindre # ";
            case 37: return " pour gagner 1 Point de Prestige de Zone";
            case 38: return "Meilleur Temps de Complétion";
            case 39: return "Meilleur Gain d'Or Total";
            case 40: return "Meilleur Gain d'EXP Total";

        }
        return "";
    }

    public override string EquipmentDictionaryUIString(int id)
    {
        switch (id)
        {
            case 0: return " dans le Magasin Épique";
            case 1: return "Auto Désassembler lors de la fabrication";
            case 2: return "<size=20>Auto Désassembler : ";
            case 3: return "<size=24>Amélioration de Dictionaire <size=20>( points : ";
            case 4: return "<size=20><u>Coût de Fabrication</u><size=18>";
            case 5: return "<color=orange> Désassembler";
            case 6: return "<color=yellow>Maj + C pour fabriquer</color>";
        }
        return "";
    }

    public override string EquipmentTalismanUIString(int id)
    {
        switch (id)
        {
            case 0: return "Auto Désassembler les Talismans";
            case 1: return "Type : Talisman";
            case 2: return "# Désassemblé";
            case 3: return "\n- Reste actif tant qu'équipé dans un Emplacement Utilitaire";
            case 4: return "\n- Gain de Fragments lors du désassemblage : ";
            case 5: return "<size=20><u>Effet Équipé par # de Pile</u><size=18>";
            case 6: return " Fragments";
            case 7: return "\n\n<color=yellow>Ce Talisman ne peut pas être désassemblé.</color>";
            case 8: return "<size=20><u>Effet Passif par # Désassemblé</u><size=18>";
            case 9: return "<size=20><u>Effet Passif Total Courant</u><size=18>";
        }
        return "";
    }

    public override string LabMenuUIString(int id)
    {
        switch (id)
        {
            case 0: return "Auto Étendre";
            case 1: return "Auto Désassembler";
        }
        return "";
    }

    public override string SaveManagerString(int id, string str1 = "", string str2 = "")
    {
        switch (id)
        {
            case 0: return "Échec de la Sauvegarde Cloud.\n<size=18>Veuillez vérifier si vous êtes connecté à Internet et réessayez plus tard.";
            case 1: return "Sauvergarde Cloud effectuée !";
            case 2: return "Êtes-vous sûr de vouloir importer la sauvegarde du Serveur Steam maintenant ?";
            case 3: return "\nLa dernière Sauvegarde Cloud était le ";
            case 4: return "\n<color=yellow>Veuillez relancer le jeu après une importation de sauvegarde pour stabiliser les performances du jeu.</color>";
            case 5: return "Exporter la sauvegarde courante sur votre ordinateur";
            case 6: return "Importer une sauvegarde locale depuis votre ordinateur";
            case 7: return "Pour stabiliser les performances du jeu, il est recommandé de relancer le jeu après avoir importé une sauvegarde.";
            case 8: return "Pour les Utilisateurs de Mac, vous devez mettre le fichier \"localsave.txt\" dans le dossier ";
            case 9: return "Importer un fichier de sauvegarde depuis le Serveur Steam";
            case 10: return "Pour stabiliser les performances du jeu, il est recommandé de relancer le jeu après avoir importé une sauvegarde.";
            case 11: return "\n\nTemps de la dernière Sauvegarde Cloud : ";
            case 12: return "<size=20>Exporter le fichier de sauvegarde courante vers le Serveur Steam.";
            case 13: return "\n<color=green>- Téléchargez la sauvegarde pour gagner <sprite=\"epiccoin\" index=0> " + str1 + " Pièces Épiques tout de suite !</color>";
            case 14: return "\n<color=yellow>- Vous pouvez gagner <sprite=\"epiccoin\" index=0> " + str1 + " Pièces Épiques dans " + str2 + " de Temps de Jeu Réel</color>";
        }
        return "";
    }

    public override string SettingMenuUIString(int id)
    {
        switch (id)
        {
            case 0: return "Ignorer le Multiplicateur en Haut à Gauche avec x1 pour les améliorations ci-dessous";
            case 1: return "ou le Mode \"Vite, ton patron arrive !\"";
            case 2: return "Rejoignez le serveur Discord pour recevoir les dernières mises à jour,\n rapporter tout bug que vous trouvez, recevoir des conseims sur le jeu,\n et peut-être même trouver une épouse si vous n'en avez pas !";
            case 3: return "Le site Internet de l'équipe de développement Hapiwaku.";
            case 4: return "Êtes-vous sûr de vouloir réinitialiser le jeu ?\n\n<size=20><color=yellow>Vous allez TOUT perdre.\nAprès une Réinitialisation complète, veuillez relancer le jeu pour stabiliser les performances. Vous pouvez restaurer les achats en jeu dans le Magasin Épique.";
            case 5: return "Si votre jeu plante souvent, désactivez ceci\net effectuez une sauvegarde en cache juste avant de quitter le jeu.";
        }
        return "";
    }

    public override string BonusCodeUIString(int id)
    {
        switch (id)
        {
            case 0: return "<color=red>Désolé, mais le code entré n'existe pas.</color>";
            case 1: return "<color=red>Ce code n'existe pas, voyons !</color>";
            case 2: return "<color=red>Ce n'est pas un code pour ce jeu... nous ne avons pas si c'est un code pour N'IMPORTE quel jeu à vrai dire.</color>";
            case 3: return "<color=red>Désolé mon gars, mais j'ai bien peur que je ne peux pas accepter ce code.</color>";
            case 4: return "<color=red>Est-ce que ton chat vient de marcher sur ton clavier ou quoi ?</color>";
            case 5: return "<color=red>Tu sais bien que tu ne peux pas deviner le code, n'est-ce pas ?</color>";
            case 6: return "<color=red>Ce code est incorrect.</color>";
            case 7: return "<color=red>Vous avez déjà utilisé ce code bonus.</color>";
            case 8: return "Merci beaucoup pour votre support continu !";
            case 9: return "<color=red>Ce code est incorrect.</color>";
            case 10: return "Vous avez reçu :\n<color=green>";
            case 11: return "Erreur.\nVeuillez vérifier que vous avez participé au béta-test de IEH2 AVANT le 10 Juin.\n Ou, veuillez vérifier ici :\nProfil Steam > Éditer le Profil > Options Privées > Détails du Jeu : [Publique]";
        }
        return "";
    }

    public override string BlessingString(int id)
    {
        switch (id)
        {
            case 0: return "Bénédiction de PV";
            case 1: return "Multiplication des PV par ";
            case 2: return "Régénèration de PV + ";
            case 3: return " / sec";
            case 4: return "Bénédiction d'ATQ";
            case 5: return "Multiplication de l'ATQ par ";
            case 6: return "Bénédiction de MATQ";
            case 7: return "Multiplication de la MATQ par ";
            case 8: return "Bénédiction de Vitesse";
            case 9: return "Multiplication de la Vitesse par ";
            case 10: return "Bénédiction de Maîtrise de Capacité";
            case 11: return "Multiplication de la Maîtrise de Capacité par ";
            case 12: return "Bénédiction de Maîtrise d'Équipement";
            case 13: return "Multiplication de la Maîtrise d'Équipement par ";
            case 14: return "Bénédiction de Gain d'Or";
            case 15: return "Multiplication des Gains d'Or par ";
            case 16: return "Bénédiction de Gain d'EXP";
            case 17: return "Multiplication des Gains d'EXP par ";
        }
        return "";
    }

    public override string PlaytestBonusDeadlineString(int id)
    {
        switch (id)
        {
            case 0: return "<color=yellow>Limite de temps pour le reçu : 22 Août</color>";
        }
        return "";
    }
    public override string AchievementString(int id, double value = 0, string valueString = "")
    {
        switch (id)
        {
            case 0: return "Complète toutes les quêtes de tutoriel";
            case 1: return "Débloque la Mage";
            case 2: return "Débloque l'Ange";
            case 3: return "Débloque le Voleur";
            case 4: return "Débloque l'Archer";
            case 5: return "Débloque la Dompteuse";
            case 6: return "Utilise " + tDigit(value) + " Nitro en tout";
            case 7: return "Capture " + tDigit(value) + " monstres en tout";
            case 8: return "Ouvre " + tDigit(value) + " Coffre(s) au Trésor";
            case 9: return "Vaincre " + tDigit(value) + " Mimique(s)";
            case 10: return "Vaincre " + tDigit(value) + " invasion(s)";
            case 11: return "Marche autour du monde [" + valueString + " mètres]";
            case 12: return "Marche autour du monde 2 fois [" + valueString + " mètres]";
            case 13: return "Marche autour du monde 3 fois [" + valueString + " mètres]";
            case 14: return "Marche autour du monde 5 fois [" + valueString + " mètres]";
            case 15: return "Marche vers la Lune [" + valueString + " mètres]";
            case 16: return "Marche vers la Lune aller-retour [" + valueString + " mètres]";
            case 17: return "Marche vers le Soleil [" + valueString + " mètres]";
            case 18: return "Dépense " + tDigit(value) + " Pièces Épiques";
            case 19: return "Débloque " + valueString;
            case 20: return "Gagne tous les Équipements Uniques de la Collection " + valueString;
            case 21: return "Gagne " + valueString + " Or en tout";
            case 22: return "Gagne " + valueString + " Pierres en tout";
            case 23: return "Gagne " + valueString + " Cristaux en tout";
            case 24: return "Gagne " + valueString + " Feuilles en tout";
            case 25: return "Atteindre le Niveau de Guilde " + tDigit(value);
            case 26: return "Vaincre le Boss de Raid [" + valueString + "]";
            case 27: return "Atteindre le Niveau de Potion total " + tDigit(value);
            case 28: return "Gagne " + valueString + " Points d'Alchimie en tout";
            case 29: return "Gagne " + tDigit(value) + " Équipement en tout";
            case 30: return "Aie " + tDigit(value) + " Emplacements d'Arme pour le héros " + valueString;
            case 31: return "Aie " + tDigit(value) + " Emplacements d'Armure pour le héros " + valueString;
            case 32: return "Aie " + tDigit(value) + " Emplacements de Bijou pour le héros " + valueString;
            case 33: return "Aie " + tDigit(value) + " Emplacements d'Utilitaire pour le héros " + valueString;
            case 34: return "Aie " + tDigit(value) + " Emplacements de Capacité de Classe pour le héros " + valueString;
            case 35: return "Aie 8 Emplacements de Capacité Global";
            case 36: return "Effectue " + tDigit(value) + " Réincarnation " + valueString;
            case 37: return "Effectue " + tDigit(value) + " Ascension Monde";
            case 38: return "Joue à IEH pendant " + tDigit(value) + " jour(s) de temps de jeu";
            case 39: return "Joue à IEH pendant " + tDigit(value) + " semaine(s) de temps de jeu";
            case 40: return "Joue à IEH pendant " + tDigit(value) + " mois(s) de temps de jeu";
            case 41: return "Joue à IEH pendant " + tDigit(value) + " année(s) de temps de jeu";
        }
        return "";
    }

    public override string AreaTableUIString(int id)
    {
        switch (id)
        {
            case 0: return "Simulation en Cours...";
            case 1: return "Vous pouvez simuler les résultats des combats dans chaque zone en même temps.\n<size=18>Raccourci : Maj + S";
            case 2: return "Étes-vous sûr de voulir rentrer dans ce donjon ?\nCela coûtera";
            case 3: return "\n- Vous avez besoin de ";
            case 4: return " pour rentrer dans ce donjon";
            case 5: return " Mat. Ville";
        }
        return "";
    }

    public override string AscensionMenuUIString(int id, WorldAscension wa = null)
    {
        switch (id)
        {
            case 0: return "Êtes vous sûr de vouloir effectuer une Ascension Monde de Classe " + tDigit(wa.tier + 1) + " maintenant ?\n";
            case 1: return "Vous allez gagner <color=green>" + tDigit(wa.PointGain()) + " Points d'Ascension Monde</color> de Classe " + tDigit(wa.tier + 1) + " si vous le faites maintenant !";
            case 2: return "Ascension Monde de Classe " + tDigit(wa.tier + 1) + " : Nv de Palier Total ";
            case 3: return "Comp. #";
            case 4: return "Améliorations d'Ascension Monde de Classe " + tDigit(wa.tier + 1) + " <size=18>( points : ";
            case 5: return "<size=20>Ascension Monde de Classe 1<size=18>";
            case 6: return "\n\n<u>Qu'est-ce qui est débloqué après une Ascension Monde de Classe 1</u>";
            case 7: return "\n- Prestige de Zone / Donjon";
            case 8: return "\n- Nouvelles Capacités de Guilde";
            case 9: return "\n\n<u>Ce qui est RÉINITIALISÉ après une Ascension Monde de Classe 1</u>";
            case 10: return "\n- # de Complétions de Zone et les Améliorations de Prestige de Zone";
            case 11: return "\n- L'Or, les Pièces Slime, les Ressources, le Niveau de Héros et l'EXP";
            case 12: return "\n- Les Quêtes Générales sauf leur Effet de Maîtrise";
            case 13: return "\n- Le Rang, Niveau et la Maîtrise des Capacités";
            case 14: return "\n- Le Niveau d'Amélioration dans l'onglet d'Amélioration";
            case 15: return "\n- Les objets dans l'Inventaire d'Enchantements, le Niveau et la Maîtrise des Équipements et les Améliorations de Dictionnaire";
            case 16: return "\n- Les équipements sans emplacement d'enchantement dans l'inventaire et les emplacements d'équipement";
            case 17: return "\n- Les Expansions d'Eau Mystérieuse et les Catalystes";
            case 18: return "\n- Le Niveau, l'EXP et les Capacités de Guilde";
            case 19: return "\n- Le Rang et Niveau des Bâtiments de Ville et les Matériaux de Ville";
            case 20: return "\n- Le progrès des Réincarnations et des Défis";
            case 21: return "\n- Le progrès des Équipes d'Expédition";
            case 22: return "\n\n<u>Ce qui n'est PAS réinitialisé après une Ascension Monde de Classe 1</u>";
            case 23: return "\n- Les Orbes de Portail, le # de Complétions de Donjon et les Améliorations de Prestige de Donjon";
            case 24: return "\n- Les Quêtes Globales, Journalières, de Titre et les Titres déjà acquis, la Maîtrise des Quêtes Globales";
            case 25: return "\n- L'Effet de Maîtrise des Équipements";
            case 26: return "\n- Les Équipements avec des effets d'enchantement, des emplacements d'enchantement ou des effets de forge dans l'inventaire";
            case 27: return "\n- Les objets dans l'Inventaire d'Utilitaires et ses emplacements équipés, le progrès des Talismans";
            case 28: return "\n- Les Essences et Matéruaix sauf les Matériaux de Ville";
            case 29: return "\n- Les Améliorations d'Alchimie et le Niveau des Potions";
            case 30: return "\n- Le progrès de la Recherche des Bâtiments de Ville";
            case 31: return "\n- Le progrès du Bestiaire";
            case 32: return "\n- Le Niveau et EXP des Expéditions";
            case 33: return "\n- Le Palier de Mission de Zone, la Nitro, les Pièces Épiques et les achats du Magasin Épique";
            case 34: return "\n\n<u>Attention</u>";
            case 35: return "\n- Chaque Ascension Monde augmente les requis de niveau de palier total pour faire une autre ascension par 1";
            case 36: return "\n- Les héros débloqués seront toujours débloqués après l'Ascension Monde";
            case 37: return "\n- Les Bâtiments de Ville débloqués seront toujours débloqués après l'Ascension Monde";
            case 38: return "\n- Les Quêtes Journalières et de Titres couremment acceptées devront être acceptées de nouveau après une Ascension Monde";
            case 39: return "\n- Les objets dans les emplacements d'inventaire étendu ne seront disponibles qu'après les avoir débloqués de nouveau";
            case 40: return "\n- Les Familiers actifs après le # de familiers activables seront automatiquement désactivés";
            case 41: return "\n- Vous pourrez recommencer les missions complétées mais vous ne recevrez pas de Pièces Épiques venant d'elles";
            case 42: return "Ascension Monde de Classe " + tDigit(wa.tier + 1);
        }
        return "";
    }

    public override string BattleStatusUIString(int id)
    {
        switch (id)
        {
            case 0: return "Emplacement de Capacité de Classe";
            case 1: return " capacités peuvent être mises ici.";
            case 2: return "Cliquez sur l'icône d'une capacité dans l'onglet de Capacité pour l'équiper.";
            case 3: return "Emplacement de Capacité Global";
            case 4: return " capacités de héros peuvent être mises ici.";
            case 5: return "Cliquez sur l'icône d'une capacité dans l'onglet de Capacité pour l'équiper.";
        }
        return "";
    }

    public override string BestiaryMenuUIString(int id, string str = "")
    {
        switch (id)
        {
            case 0: return "Cliquer pour arrêter l'invocation de ce familier.";
            case 1: return "Ce familier est invoqué par " + str + ".";
            case 2: return "Vous avez besoin d'un Emplacement d'Invocation de Familier libre.";
            case 3: return "Ce familier est couremmen dans une expédition.";
            case 4: return "Atteindre le Rang 1 pour invoquer ce monstre.";
            case 5: return "Cliquer pour invoquer ce familier.";
            case 6: return "Loyauté du Familier";
            case 7: return "Gain de Points de Loyauté par utilisation de capacité 'Ordre' de la Dompteuse";
            case 8: return "Multiplie l'Effet Passif du Familier par ";
            case 9: return "Multiplie les Stats du Familier";
            case 10: return "par"; //not used in Japanese and Chinese - leave as "" if N/A
            case 11: return "Vous devez utiliser";
            case 12: return "pour capturer ce monstre.";
            case 13: return "Le Niveau de Monstre Capturable augmente avec le Niveau du Héros par rapport au Titre [Étude de Monstre].";
            case 14: return "Ce familier ne peut pas être capturé pour le moment.\nÀ venir dans une mise à jour future !";
            case 15: return "Point de Domptage";
            case 16: return "Pour augmenter le Rang";
            case 17: return "Détails de Gains";
            case 18: return "Base";
            case 19: return "Stats du Héros";
            case 20: return "Ce monstre n'a pas de matériau laché";
            case 21: return "Effet de Familier Actif";
            case 22: return "Effet de Familier Passif";
            case 23: return "Stats du Familier";
        }
        return "";
    }


    public override string EquipmentSlotsString(int id, int slotAmt = 1)
    {
        switch (id)
        {
            case 0: return "Warrior's Emplacement d'Arme";
            case 1: return "Wizard's Emplacement d'Arme";
            case 2: return "Angel's Emplacement d'Arme";
            case 3: return "Thief's Emplacement d'Arme";
            case 4: return "Archer's Emplacement d'Arme";
            case 5: return "Tamer's Emplacement d'Arme";
            case 6: return "Warrior's Emplacement d'Armure";
            case 7: return "Wizard's Emplacement d'Armure";
            case 8: return "Angel's Emplacement d'Armure";
            case 9: return "Thief's Emplacement d'Armure";
            case 10: return "Archer's Emplacement d'Armure";
            case 11: return "Tamer's Emplacement d'Armure";
            case 12: return "Warrior's Emplcement de Bijou";
            case 13: return "Wizard's Emplcement de Bijou";
            case 14: return "Angel's Emplcement de Bijou";
            case 15: return "Thief's Emplcement de Bijou";
            case 16: return "Archer's Emplcement de Bijou";
            case 17: return "Tamer's Emplcement de Bijou";
            case 18: return "Emplacement d'Inventaire d'Équipement + " + slotAmt;
            case 19: return "Emplacement d'Inventaire d'Enchantement + " + slotAmt;
            case 20: return "Emplacement d'Inventaire d'Utilitaire + " + slotAmt;
        }
        return "";
    }

    public override string ClassSkillSlotString(int id, int slotAmt = 1)
    {
        switch (id)
        {
            case 0: return "Emplacement de Capacité de Classe du Guerrier + " + slotAmt;
            case 1: return "Emplacement de Capacité de Classe de la Mage + " + slotAmt;
            case 2: return "Emplacement de Capacité de Classe de l'Ange + " + slotAmt;
            case 3: return "Emplacement de Capacité de Classe du Voleur + " + slotAmt;
            case 4: return "Emplacement de Capacité de Classe de l'Archer + " + slotAmt;
            case 5: return "Emplacement de Capacité de Classe de la Dompteuse + " + slotAmt;
            case 6: return "Emplacement de Capacité Global + " + slotAmt;
        }
        return "";
    }

    public override string ChallengeClearConditionsDefeatString(string text)
    {
        return "Vaincre " + text;
    }

    public override string ChallengeString(int id)
    {
        switch (id)
        {
            case 0: return "Récompense de Première Complétion";
            case 1: return "Récompense pour Chaque Complétion";
            case 2: return "Boss de Raid";
            case 3: return "Participant";
            case 4: return "Tous les héros couremment actifs vont rejoindre le combat !";
        }
        return "";
    }

    public override string BuildingString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Rang " + text + " de la Statue des Héros";
            case 1: return "Nv " + text + " de ce bâtiment";
            case 2: return "Statue des Héros";
            case 3: return "Gain d'EXP";
            case 4: return "Niveau de Guilde " + text;
            case 5: return "Rang Max de tous les autres bâtiments à " + text;
            case 6: return "Gain d'EXP de Guilde + " + text + "%";
            case 7: return "Gain de Maîtrise de Capacité depuis un Emplacement Global + " + text + "%";
            case 8: return "Limite d'Or + " + text + "%";
            case 9: return "Gain de Matériaux de Ville + " + text + "%";
            case 10: return "Débloque une nouvelle Quête Journalière de Pièce Épique";
            case 11: return "Gain de Maîtrise de Capacité depuis un Emplacement Global + " + text + "%";
            case 12: return "Gain de Ressource ";
            case 13: return "Limite d'Or ";
            case 14: return "Réduit le coût de tous les bâtiments par ";
            case 15: return "Cartographeur";
            case 16: return "Gain d'Or ";
            case 17: return "Complète " + text;
            case 18: return "À venir dans une mise à jour future !";
            case 19: return "Débloque une nouvelle Quête Journalière de Cartographeur";
            case 20: return "Débloque une nouvelle région et des matériaux dans le Magasin";
            case 21: return "Gain d'Orbes de Portail à travers les Quêtes Journalières + " + text;
            case 22: return "Limite de Temps des Donjons ";
            case 23: return "Réduit l'Effet des Débuffs de Terrain par";
            case 24: return "Gain de Matériaux de Ville à travers la complétion de zone ";
            case 25: return "Hutte de l'Alchimiste";
            case 26: return "# de Stock Max de Matériaux du Magasin ";
            case 27: return "Étendre la Limite d'Eau Mystérieuse par " + text;
            case 28: return "Débloque un nouveau Catalyste";
            case 29: return "Gain d'Eau Mystérieuse + " + text;
            case 30: return "Limite d'Eau Mystérieuse Max + " + text;
            case 31: return "Emplacement d'Inventaire d'Utilitaire + " + text;
            case 32: return "Augmente le Prix de Vente dans le Magasin";
            case 33: return "Niveau Max de la Purification + " + text;
            case 34: return "Niveau Max de la Préservation d'Eau + " + text;
            case 35: return "Débloque le Fluide de Monstre dans le Magasin";
            case 36: return "Débloque les Matériaux Rare dans le Magasin";
            case 37: return "Gain d'Eau Mystérieuse ";
            case 38: return "Taux de Converstion d'Essence ";
            case 39: return "Limite Max d'Eau Mystérieuse ";
            case 40: return "Forge";
            case 41: return "MUltiplie l'Effet des Équipements par ";
            case 42: return "Points de Dictionnaire Gagnés : " + text;
            case 43: return "Débloque la [Fabrication] dans l'onglet Lab";
            case 44: return "Débloque la fabrication de nouveaux Parchemins";
            case 45: return "Débloque une nouvelle Amélioration de Dictionnaire";
            case 46: return "Emplacement d'Inventaire d'Équipement + " + text;
            case 47: return "Emplacement d'Auto Désassemblage d'Équipement + " + text;
            case 48: return "Emplacement d'Inventaire d'Enchantement + " + text;
            case 49: return "Permet de fabriquer des Équipements Communs dans le Dictionnaire";
            case 50: return "Permet de fabriquer des Équipements Peu Communs dans le Dictionnaire";
            case 51: return "Permet de fabriquer des Équipements Rares dans le Dictionnaire";
            case 52: return "Permet de fabriquer des Équipements Super Rares dans le Dictionnaire";
            case 53: return "Permet de fabriquer des Équipements Épiques dans le Dictionnaire";
            case 54: return "Emplacement d'Auto Désassemblage d'Équipement ";
            case 55: return "Gain de Matériau lors du Désassemblage d'un Équipement ";
            case 56: return "Réduit le coût de fabrication par " + text;
            case 57: return "Temple";
            case 58: return "Gain de Point de Réincarnation ";
            case 59: return "# Total de Réincarnations de Classe 1 : " + text;
            case 60: return "# Total de Réincarnations de Classe 2 : " + text;
            case 61: return "# Total de Réincarnations de Classe 3 : " + text;
            case 62: return "# Total de Réincarnations de Classe 4 : " + text;
            case 63: return "# Total de Réincarnations de Classe 5 : " + text;
            case 64: return "Débloque la Réincarnation de Classe 2";
            case 65: return "Débloque la Réincarnation de Classe 3";
            case 66: return "Débloque la Réincarnation de Classe 4";
            case 67: return "Débloque la Réincarnation de Classe 5";
            case 68: return "Débloque la Réincarnation de Classe 6";
            case 69: return "Débloque une nouvelle Bénédiction dans le Magasin";
            case 70: return "# de Bénédictions Disponibles + " + text;
            case 71: return "Multiplie l'Effet des Bénédictions par ";
            case 72: return "Durée des Bénédictions ";
            case 73: return "Niveau requips pour une Réincarnation ";
            case 74: return "Minimum";
            case 75: return "Trappeur";
            case 76: return "Nv Max de Monstre Capturable : " + text;
            case 77: return "Battre tout monstre : ";
            case 78: return "Débloque un nouveau Piège dans le Magasin";
            case 79: return "Gain de Point de Domptage + " + text + "%";
            case 80: return "# de Stock Max de Pièges dans le Magasin + " + text;
            case 81: return "Emplacement de Familier Actif + " + text;
            case 82: return "Réduit le temps de recharge des Pièges par " + text + " sec";
            case 83: return "Chance d'Apparition de Matériau Rare ";
            case 84: return "Quantité de réapprovision de pièges dans le Magasin ";
            case 85: return "Multiplie les Gains de Point de Domptage par";
            case 86: return "Banque Slime";
            case 87: return "Gain de Pièces Slime ";
            case 88: return "Slimes capturés : ";
            case 89: return "Débloque la Banque Slime dans l'onglet Amélioration";
            case 90: return "Débloque de nouvelles Améliorations de Banque Slime";
            case 91: return "Efficacité des Pièces Slime" + text + "%";
            case 92: return "Gain d'Or + " + text + "%";
            case 93: return "Octroie de l'intérêt sur les Pièces Slime en votre possession toutes les 10 minutes : ";
            case 94: return "Quantité de réapprovisionnement de matériaux dans le Magasin ";
            case 95: return "Multiplie la Limite de Pièces Slime par ";
            case 96: return "Arène Mystique";
            case 97: return "Dégâts aux Boss de Défi ";
            case 98: return "Complétion de Défi de Raid " + text;
            case 99: return "Débloque les Défis avec Handicap";
            case 100: return "Débloque les Défis Super Donjon";
            case 101: return "Débloque l'Handicap [Arène Mystique " + text + "]";
            case 102: return "Débloque le Défi de Boss de Nv +" + text;
            case 103: return "Emplacement d'Inventaire d'Équipement ";
            case 104: return "Multiplie les Récompenses de Stats des Défis avec Handicap par ";
            case 105: return "Gain de Point d'Alchimie ";
            case 106: return "Chercheur Arcanique";
            case 107: return "Multiplie le Pouvoir de Recherche par";
            case 108: return "# de Recherches + " + text;
            case 109: return "Permet la conversion de Matériaux de Ville dans le Magasin";
            case 110: return "Gain de Matériaux de Ville Convertis + " + text;
            case 111: return "Débloque de nouvelles conversions de Matériaux de Ville";
            case 112: return "Pouvoir de Recherche Rocheuse ";
            case 113: return "Pouvoir de Recherche Cristallique ";
            case 114: return "Pouvoir de Recherche Végétale ";
            case 115: return "Taverne";
            case 116: return "Dojo";
            case 117: return "Équipe d'Aventuriers";
            case 118: return "Multiplie la Vitesse des Expéditions par";
            case 119: return "Temps d'Expédition Total : " + text + " jours";
            case 120: return "Débloque le 2ème Emplacement de Familier d'Expédition";
            case 121: return "Débloque le 3ème Emplacement de Familier d'Expédition";
            case 122: return "Montant de Récompense d'Expédition ";
            case 123: return "Gain d'EXP d'Expédition ";
            case 124: return "Gain d'EXP de Familier d'Expédition ";
            case 125: return "Améliore l'effet des améliorations de Gain de Ressources";
            case 126: return "";
            case 127: return "";
            case 128: return "";
            case 129: return "";
            case 130: return "";
        }

        return "";
    }

    public override string ChallengeBossDescriptionString(int id)
    {
        switch (id)
        {
            case 0: return "<size=17>Gardien Kor était originellement construit pour garder le Coffre Royal du royaume des nains. Cependat, personne n'a vu ou même entendu parler des nains depuis plus d'un siècle. Leurs cités sont des ruines abandonnées, et leurs créations sont en décomposition, laissées à la rouille. Cependant, ce gardien fidèle, à travers l'utilsation d'une horrible magie et de merveilles de technologie, reste aussi capable que toujours. La coffre qu'il gardait s'est effondré, tous ses trésors perdus dans une coulée de lave profonde, mais il garde toujours son entrée tel qu'il l'a toujours fait et personne ne l'empêchera de le faire.</size>";
            case 1: return "<size=17>Florzporbe, le Roi des Slimes, était une fois un roi humain qui régnait sur ce qui est maintenant le Village des Slimes et la Cité des Slimes Magiques. Ce n'est qu'une rumeur, car tous les écrits ont été détruits, mais il est dit que son orgueil démesuré contre les dieux est ce qui a apporté cette terrible malédiction sur ses terres. Vous devez faire très attention lordque vous vous approchez de lui, car il commande toujours la capacité d'invoquer une variété de slimes à ses côtés pour le défendre de quiconque voudrait l'assassiner.</size>";
            case 2: return "<size=17>Aranetta, la Reine Veuve, est une créature monstrueuse apparue soudainement il y a plus d'une décennie. Ses laquais sans nombre ont envahis le Domaine de Tressel et tous ses nombreux vergers et villages. Personne n'a survécu son occupation. Elle a fait du labyrinthe de haies derrière le Manoir du Domaine de Tressel sa zone de reproduction. Tout aventurier essayant de l'exterminer doivent être conscient que son poison est sans doute le plus puissant du monde, et qu'elle a transformé tous les grands héros envoyés pour la tuer en repas.</size>";
            case 3: return "<size=17>Nostro, la Chauve-Souris Vampire, est apparu dans les légendes depuis des centaines d'années, cependant elle n'a jamais été apperçue directement. Il est dit que cette monstrosité maléfique absorbe la vie de ses victimes, ne laissant aucun survivant, et seules les âmes les plus chanceuses qui l'ont aperçue se sont échappées vivantes. Vivant dans les tréfonds des Cavernes Cramoisies, aussi connue comme la Grotte des Chauve-Souris, elle se tient en embuscade pour toute âme malchanceuse qui s'approche trop près de son domaine. Attention, car toute personne qui cherche à en faire sa proie a de grandes chances de devenir la proie.</size>";
            case 4: return "<size=17>Dame Emelda, la Sorcière Fée, a gouverné pendant longtemps sur les Fées de Glainn Caillte, depuis que la Reine des Fées a succombé à une malédiction qui l'a transformé en pierre de façon permanente. Intervenant pour prendre la place de la souveraine pétrifiée, la haine de Dame Emelda envers toute créature non féerique a influencé les Fées de Glainn Caillte à devenir tordues et hostile. Sa maîtrise de la magie de feu est bien connue, et il est dit que dès qu'elle voit quelqu'un qui n'appartient pas à son espèce, elle l'incinère immédiatement. Il est dit que l'assassinat de cette bête pourrait restaurer la gentillesse des Fées qu'elles avaient il y a des siècles, mais il est aussi possible que leur corruption soit complète et qu'elles ne puissentplus être telles qu'elles étaient avant la mort de la Reine des Fées. Dans tous les cas, le danger envers le monde qu'est Dame Emelda reste, et beaucoup souhaiterait voir son règne se terminer.</size>";
            case 5: return "<size=17>Nari Sune, le Renard aux Neuf Queues, a beaucoup de rumeurs circulant autour d'elle. En tant que farceur connu, Nari Sune peut se transformer en plein de créatures différentes et peut même contrôler tout pouvoir natif que cette créature peut posséder. Généralement isolée et content d'ignorer l'état du monde, Nari Sune a récemment été découverte en train d'interférer avec les affaires politiques de différents royaumes, se transformant en leaders variés pour implanter conflit et discontentement. Les intentions de Nari Sune sont inconnues, mais ses actions ont donné lieu à des guerres, des coups d'état, et à la mort de milliers de personne dans le chaos qu'il s'en suit. Attention à tous ceux à sa recherche, car elle est ancienne est rusée, ce qui lui a permis de survivre depuis si longtemps.</size>";
            case 6: return "";
            case 7: return "";
            case 8: return "";
            case 9: return "";
            case 10: return "";
            case 11: return "";
            case 12: return "";
            case 13: return "";
            case 14: return "";
            case 15: return "";
            case 16: return "";
            case 17: return "";
            case 18: return "";
            case 19: return "";
            case 20: return "";
            case 21: return "";
            case 22: return "";
            case 23: return "";

        }
        return "";
    }


    public override string EpicStoreMenuString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Êtes-cous sûr de vouloir acheter ceci ?";
            case 1: return "GRATUIT la première fois !";
            case 2: return " (Achat Unique)";
            case 3: return " (# de Limite d'Achat : " + text + ")";
            case 4: return "Ceci coûte normalement " + text + ", mais il est GRATUIT la première fois !";
            case 5: return "Le prix augmentera après l'achat.";
            default: return "" + text;
        }
    }
    public override string ChallengeHandicappedString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Combat avec Handicap";
            case 1: return text + " avec handicaps";
            case 2: return "Niveau de Monstre";
            case 3: return "Handicaps";
            case 4: return "Récompense de Première Complétion";
            case 5: return "Récompense pour Toute Complétion";
            case 6: return "Arène Mystique " + text + "F";
            default: return "" + text;
        }
    }
    public override string EquipMenuString(int id, string text = "")
    {
        string tempStr;
        switch (id)
        {
            case 0:
                tempStr = "<size=20>Boîte de Désassemblage<size=18>";
                tempStr += "\n- Glissez et posez un objet ici pour le désassembler.";
                tempStr += "\n\nRaccourcis : ";
                tempStr += "\n- <color=orange>Maj+D</color> et un <color=orange>Clic</color> sur un <color=orange>OBJET</color> : Désassemble un Équipement/objet Utilitaire.";
                tempStr += "\n- <color=orange>Maj+D</color> et un <color=orange>Double Clic</color> <color=orange>ICI</color> : Désassemble tous les Équipements dans l'inventaire sauf les objets verrouillés.";
                tempStr += "\n- <color=orange>L</color> sur un objet : Verrouille / Déverrouille un objet.";
                tempStr += "\n- <color=orange>Maj</color> et un <color=orange>Clic</color> sur un <color=orange>Bouton de Tri</color> : Inverser l'ordre du tri.";
                tempStr += "\n- <color=orange>Maj</color> maintenu et le glisser déposer d'un Parchemin de Maîtrise ou d'une Enclume : Combiner les mêmes types d'effet.";
                tempStr += "\n- <color=orange>Maj</color> maintenu et le glisser déposer d'un Parchemin de Maîtrise sur un Emplacement vide : Séparation (de la valeur) en secondes du Parchemin.";
                tempStr += "\n- <color=orange>Maj</color> maintenu et le glisser déposer d'une Enclume sur un Emplacement vide : Séparation (de la valeur) de l'effet de l'Enclume, mesuré en nombre entiers.";
                tempStr += "\n- <color=orange>Maj</color> maintenu et le glisser déposer d'un objet Utilitaire : Sépare son # de Pile basé sur le multiplicateur sélectionné en haut à gauche.";
                return tempStr;
            case 1: return "Reste actif tant qu'équipé dans un Empacement d'Utilitaire";
            case 2: return "Temps de Recharge";
            case 3: return "Effet Équipé";
            case 4: return "Niveau de Monstre Capturable" + text + " ou moins";
            case 5: return "Il augmente avec le Niveau du Héros et le Titre [Étude de Monstre].";
            case 6: return "Vous ne pouvez pas capturer des monstres de type 'colorés' avec cet objet.";
            case 7: return "Ce Talisman ne peut pas être désassemblé.";
            case 8: return "Effet Passif obtenu après désassemblage";
            default: return "" + text;
        }
    }
    public override string ExpeditionCtrlString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Niveaux d'Expédition";
            case 1: return "Paliers d'Expédition";
            case 2: return "Nv total";
            case 3: return "Êtes-cous sûr de voulie annuler cette expédition?";
            case 4: return "Nous ne recevrez pas de récompense.";
            case 5: return "Équipe";
            case 6: return "Récompense de Complétion";
            case 7: return "Commencer";
            case 8: return "Annuler";
            default: return "" + text;
        }
    }

    public override (string name, string description, string effect) SlimeBankUpgradeString(SLIMEBANK_UPGRADE upgrade, bool isNextValue = false)
    {
        string name = "";
        string description = "";
        string effect = "";
        switch (upgrade.slimebankKind)
        {
            case SlimeBankUpgradeKind.SlimeCoinCap:
                name = "Meilleur Compte Slime";
                description = "Augmente la Limite de Pièces Slime";
                break;

            case SlimeBankUpgradeKind.SlimeCoinEfficiency:
                name = "Échanges Fiscaux";
                description = "Augmente le Gain de Pièces Slime pour chaque Or après la limite ";
                break;

            case SlimeBankUpgradeKind.UpgradeCostReduction:
                name = "Carte de Membre";
                description = "Réduit le Coût des Améliorations Générales";
                effect = "par " + percent(upgrade.EffectValue(isNextValue));
                break;

            case SlimeBankUpgradeKind.ResourceBooster:
                name = "Collecteur Slime";
                description = "Augmente l'Effet des Améliorations de Ressources";
                break;

            case SlimeBankUpgradeKind.StatsBooster:
                name = "Entraîneur Slime";
                description = "Augmente l'Effet des Améliorations de Stats";
                break;

            case SlimeBankUpgradeKind.GoldCapBooster:
                name = "Bourse Slime";
                description = "Multiplie l'Effet des Améliorations de Limite d'Or";
                effect = "par " + percent(1 + upgrade.EffectValue(isNextValue));
                break;

            case SlimeBankUpgradeKind.MysteriousWaterGain:
                name = "Alchimiste Slime";
                description = "Augmente le Gain d'Eau Mystérieuse";
                break;

            case SlimeBankUpgradeKind.GoldGain:
                name = "\"Gagner de l'Or pour les Nuls\"";
                description = "Multiplie le Gain d'Or";
                effect = "par " + percent(1 + upgrade.EffectValue(isNextValue));
                break;

            case SlimeBankUpgradeKind.MaterialFinder:
                name = "Chance Slime";
                description = "Multiplie la Chance d'Apparition de Matériau Communs";
                effect = "par " + percent(1 + upgrade.EffectValue(isNextValue));
                break;

            case SlimeBankUpgradeKind.ShopTimer:
                name = "Réapprovisionnement Efficace";
                description = "Réduit le Temps de Réaprrovisionnement du Magasin";
                effect = "par " + tDigit(upgrade.EffectValue(isNextValue)) + " sec";
                break;

            case SlimeBankUpgradeKind.ResearchPower:
                name = "Chercheur Slime";
                description = "Multiplie la Puissance de Recherche de Ville ";
                effect = "par " + percent(1 + upgrade.EffectValue(isNextValue));
                break;

            case SlimeBankUpgradeKind.SPD:
                description = "Augmente la VIT ";
                break;

            case SlimeBankUpgradeKind.FireRes:
                description = "Augmente la Résistance au Feu ";
                break;

            case SlimeBankUpgradeKind.IceRes:
                description = "Augmente la Résistance à la Glace ";
                break;

            case SlimeBankUpgradeKind.ThunderRes:
                description = "Augmente la Résistance à l'Électricité ";
                break;

            case SlimeBankUpgradeKind.LightRes:
                description = "Augmente la Résistance à la Lumière ";
                break;

            case SlimeBankUpgradeKind.DarkRes:
                description = "Augmente la Résistance aux Ténèbres ";
                break;

            case SlimeBankUpgradeKind.DebuffRes:
                description = "Augmente la Résistance aux Débuffs ";
                break;

            case SlimeBankUpgradeKind.SkillProf:
                description = "Augmente le Gain de Maîtrise de Capacité ";
                break;

            case SlimeBankUpgradeKind.EquipmentProf:
                description = "Augmente le Gain de Maîtrise d'Équipement ";
                break;

            case SlimeBankUpgradeKind.CritDamage:
                name = "Instructeur de Chasse Slime";
                description = "Augmente les Dégâts Critiques par ";
                effect = percent(upgrade.EffectValue(isNextValue)) + " des dégâts normaux";
                break;
            default:
                break;
        }
        return (name, description, effect);
    }
    public override string GuildMenuString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "En combat dans" + text;
            case 1: return "en attente dans " + text;
            case 2: return "EXP";
            case 3: return "EXP gagnés dans la dernière minute";
            case 4: return "Points d'Abilité disponibles";
            case 5: return " Héros sont couremment actifs";
            case 6: return " Héro est couremment actif";
            case 7:
                return optStrL
                + "\n- En plus du héros couremmen en jeu, vous pouvez activer les autres héros en arrière-plan " +
                "\naprès avoir reçu la Quête de Titre [Preuve de Reinc.]."
                + "\n- " + text + " héros peuvent être activés en même temps." +
                "\n- Vous pouvez augmenter cette limite à travers une amélioration d'Ascension Monde.";
            case 8: return "Ce héros est couremment actif.";
            case 9: return "Ce héros est couremment actif en arrière-plan.\nEfficacité des Gains en Arrière-Plan : ";
            case 10: return "vous pouvez activer ce héros en arrière-plan.\nEfficacité des Gains en Arrière-Plan : ";
            case 11: return "Finissez la Quête de Titre [Preuve de Reinc.] pour permettre l'Activation en Arrière-Plan.";
            case 12: return "Vous jouez couremment le héros " + text;
            case 13: return "Jouer le héros " + text;
            default: return "" + text;
        }
    }
    public override string MissionString(MISSION mission, string text = "")
    {
        switch (mission.kind)
        {
            case MissionKind.Clear:
                return "Compléter cette Zone";
            case MissionKind.SaveHp:
                return "Compléter cette Zone avec vos PV azu dessus de " + text;
            case MissionKind.WithinTime:
                return "Compléter cette Zone en " + text + " sec";
            case MissionKind.Gold:
                return "Gagner " + text + " Or en une seule complétion";
            case MissionKind.Exp:
                return "Gagner " + text + " EXP en une seule complétion";
            case MissionKind.NoEQ:
                return "Compléter cette Zone sans aucun Équipement";
            case MissionKind.OnlyBase:
                return "Compléter cette Zone en n'ayant que l'Attaque de Base équipée";
            default: return "";
        }
    }
    public override string OfflineBounusString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "BONUS DE DÉCONNEXION";
            case 1: return "Vous êtes partis pendant";
            case 2: return "Sélectionnez un bonus de déconnexion parmi les suivants :";
            case 3: return "Bonus de Nitro";
            case 4: return "Vous gagnerez <color=green>" + text + " Nitro</color>.";
            case 5: return "Vous êtes couremment à vote max de Nitro.";
            case 6: return "1 Nitro est gagné toutes les 2 secondes de déconnexion.";
            case 7: return "Le Temps de Jeu n'augmentera pas.";
            case 8: return "Bonus de Temps de Jeu Passif";
            case 9: return "Vous gagnerez les suivants :";
            case 10: return "Temps de Jeu";
            case 11: return "Progrès de Recherche de Ville";
            case 12: return "Temps de Réapprovisionnement de Magasin";
            case 13: return "Progrès d'Expédition";
            case 14: return "Maîtrise d'Équipement";
            case 15: return "Progrès du Héros Actif";
            case 16: return "# de Complétions";
            default: return "" + text;
        }
    }
    public override string SwarmString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "L'invasion a été éradiquée !";
            case 1: return "Invasion Normale";
            case 2: return "Grosse Invasion";
            case 3: return "Invasion Épique";
            case 4: return "Invasion";
            case 5: return "Récompense d'éradication";
            case 6: return "Talisman";
            case 7: return "Vous avez besoin d'un Emplacement d'Utilitaire vide";
            case 8: return "Récompenses de Score";
            case 9: return "Score courant";
            case 10: return "Bénédiction de Gain d'EXP (Durée de 15 mins)";
            case 11: return "5 Fragments de Talisman";
            case 12: return "Bénédiction de Gain d'Or (Durée de 15 mins)";
            case 13: return "1 Orbe de Portail";
            case 14: return "1 ";
            case 15: return "Talisman (Peu Commun) [" + text + "]";
            case 16: return "Talisman (Rare) [" + text + "]";
            case 17: return "Talisman (Super Rare) [" + text + "]";
            case 18: return "Critères de Score";
            case 19: return "Par Complétion de Zone";
            case 20: return "Pour chaque Mutant Vaincu";
            case 21: return "Chance d'Apparition";
            case 22: return "Pour l'éradication de l'Invasion";
            case 23: return "Temps Restant (minute)";
            case 24: return "Plus la Difficulté de Zone est haute, plus le Gain de Score est haut";
            case 25: return "L'" + text + " a été éradiquée !";
            case 26: return "Temps";
            case 27: return "Vous recevez :";
            case 28: return " x" + text;
            default: return "" + text;
        }
    }

    public override string FieldCurseString(AREA area)
    {
        string tempStr = "";
        bool isCurse = false;
        if (area.curseAbilityMul < 1)
        {
            if (isCurse) tempStr += ", ";
            tempStr += "Réduit les Points d'Abilité à " + percent(area.curseAbilityMul);
            isCurse = true;
        }
        if (area.cursePetBasicStatsMul < 1)
        {
            if (isCurse) tempStr += ", ";
            tempStr += "Réduit les Stats des Familiers à " + percent(area.cursePetBasicStatsMul);
            isCurse = true;
        }
        return tempStr;
    }

    public override string ExpeditionMenuString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Sélectionne des familiers pour les envoyer dans une expédition";
            case 1: return "Coût pour Commencer";
            case 2: return "Annuler cette expédition";
            case 3: return "Vous ne recevrez aucune récompense.";
            case 4: return "Réclamer pour recevoir ceci";
            case 5: return "Expédition courante";
            case 6: return "EXP de l'Expédition";
            case 7: return "Vitesse de l'Expédition";
            case 8: return "Niveau de l'Équipe";
            case 9: return "Gain d'EXP du Familier";
            case 10: return "Niveau de l'Expédition";
            case 11: return "Gain d'EXP de l'Expédition";
            case 12: return "# de Membres de l'Équipe";
            case 13: return "Le montant augmente basé sur le rang de l'équipe, le niveau de l'expédition et le temps.";
            case 14: return "Progrès";
            case 15: return "Temps Restant";
            case 16: return "Distance PArcourue au Total";
            case 17: return "Quête Globale [ Tutoriel 12 : les Expéditions ]";
            case 18: return "Palier d'Expédition";
            case 19: return "ou le Mégasin Épique";
            case 20: return "Complété";
            case 21: return text + " restant";
            case 22: return "Sélectionnez un Familier";
            default: return "" + text;
        }
    }
    public override string QuestString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Récompense d'EXP";
            case 1: return "Gain de Point de Réincarnation de cette quête";
            case 2: return "Divise le coût d'emplacement d'acceptation par deux";
            case 3: return "Élimine le cout d'emplacement d'acceptation";
            default: return "" + text;
        }
    }
    public override string RebirthMenuString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return " Réincarnation de Classe " + text;
            case 1: return "Niveau du Héros";
            case 2: return "Vous ne pouvez pas vous réincarner si vous êtes dans un Défi.";
            case 3: return "Vous ne pouvez pas vous réincarner si vous êtes dans un Donjon.";
            case 4: return "Compléter une zone au moins une fois";
            case 5: return "La Réincarnation est une fonctionnalité de prestige pour chaque héros qui remet à zéro quels progrès mais permet de gagner des Points de Réincarnation utilisés pour des Améliorations de Réincarnation, qui vous permettent d'atteindre un Niveau de Héros plus haut et plus rapidement !";
            case 6: return "La Réincarnation de Classe 2 remet à zéro tous les Niveaux de Capacité et les Maîtrises de Capacité en plus de ce que celle de Classe 1 remet à zéro. Cependant, les Améliorations de Réincarnation de Classe 2 booste les Améliorations de Classe 1 et le Gain de Maîtrise de Capacité !";
            case 7: return "La Réincarnation de Classe 3 remet à zéro le Niveau des Équipements et leur Maîtrise du héros couremment actif hero en plus de ce que celle de Classe 1 remet à zéro, ce qui veut dire que vous pouvez gagner des Points de Dictionnaire à nouveau. Les Améliorations de Réincarnation de Classe 3 booste les améliorations des Classes inférieures et permet d'augmenter le Niveau de Héros et le Niveau des Équipements plus haut et plus rapidement !";
            case 8: return "La Réincarnation de Classe " + text + " remet à zéro :";
            case 9: return "Le Niveau du Héros et son EXP";
            case 10: return "Les Quêtes Générales";
            case 11: return "Le Niveau et la Maîtrise des Capacités";
            case 12: return "Le Rang reste";
            case 13: return "Le Niveau et la Maîtrise des Équipements";
            case 14: return "Les Points de Dictionnaire et les Effets de Maîtrise restent";
            case 15: return "Effet Bonus de Réincarnation de Classe " + text;
            case 16: return "Points d'Abilité Additionnels : [Niveau Max de Héros Atteint en Classe 1 (au plus";
            case 17: return "Après une Réincarnation, gagnez ([Niveau Max de Héros Atteint en Classe 2 (au plus";
            case 18: return ") Points d'Abilité tous les 25ème Niveaux de Héros";
            case 19: return "Effet Bonus de Réincarnation de Classe 1";
            case 20: return "# de Réincarnations de Classe 2";
            case 21: return "Niveau Initial de la Capacité de l'Attaque de Base";
            case 22: return "Niveau Max du Héros Atteint en Classe 3 (au plus";
            case 23: return "Effet Bonus de Réincarnation de Classe 2";
            case 24: return "# de Réincarnations de Classe 3";
            case 25: return "Temps Joué avant une Réincarnation de Classe " + text;
            default: return "" + text;
        }
    }
    public override string ResourceCtrlString(int id, string text = "", string text2 = "")
    {
        switch (id)
        {
            case 0: return "Boosteur de Nitro";
            case 1: return "Temps de Jeu x" + text;
            case 2: return "Vous gagnez du Nitro en étant hors-ligne";
            case 3: return "Vous avez couremment";
            case 4: return "L'Objet du MAgasin Épique [Chargeur de Nitro Max] peut donner du Nitro après la Limite de Nitro.";
            case 5: return "Cliquer pour Activer/Désactiver";
            case 6: return "Tant que le Boosteur de Nitro est Activé, la Vitesse du Jeu est";
            case 7: return "x" + text;
            case 8: return "lors de la consommation de " + text;
            case 9: return "Nitro par sec" + text;
            case 10: return " + Flèche Haut/Bas pour augmenter/réduite la vitesse.";
            case 11: return "Pièce de Slime";
            case 12: return "Gagné lorsque l'Or dépasse la Limite d'Or";
            case 13: return "Utilisé pour les Améliorations de Banque Slime, qui sont débloquées par la Banque Slime au Niveau de Guilde 35";
            case 14: return "Vous avez couremment";
            case 15: return "Gagné dans les 10 dernières minutes";
            case 16: return "Efficacité de Gain : ";
            case 17: return " d'or dépassant la limite";
            case 18: return "Détails de l'Efficacité des Gains";
            case 19: return "Base à travers les Améliorations";
            case 20: return "Ville";
            case 21: return "Gagné lors de la défaite d'un monstre";
            case 22: return "Vous avez couremment";
            case 23: return "Gagné pendant la dernière minute";
            case 24: return "Or Gagné au Total";
            case 25: return "Détails de la Limite D'Or";
            case 26: return "Vous avez couremment";
            case 27: return "Gagné pendant la dernière minute";
            case 28: return "Tout monstre lache " + text + text2 + " lors qu'ils sont vaincus par le héros ";
            case 29: return " ou le héros ";
            case 30: return "";
            case 31: return "Détails des Gains";
            case 32: return "EXP";
            case 33: return "Gagné pendant la dernière minute";
            case 34: return text + "Gain d'EXP de Guilde à chaque montée de niveau";
            case 35: return "Détails des Gains d'EXP de Guilde";
            case 36: return "Multiplicateur";
            case 37: return "Vous pouvez utiliser ceci pour acheter ou améliorer " + text + "x";
            case 38: return " fois " + text + " en même temps";
            case 39: return "Clic Gauche ou la touche \"+\" pour augmenter le montant";
            case 40: return "Clic Droit ou la touche \"-\" pour réduire le montant";
            case 41: return "Maj + Clic Gauche pour rentrer un montant personnalisé ou pour réinitialiser le montant courant";
            case 42: return "Laj + F pour montrer les coûts entiers (Max x100)";
            default: return "" + text;
        }
    }

    public override string TitleSceneString(int id, string text = "", string text2 = "")
    {
        switch (id)
        {
            case 0: return "Bienvenue dans le monde de Incremental Epic Hero 2!";
            case 1: return "Vous commencerez en tant que le " + text + "Guerrier" + text2 + ".";
            case 2: return "Une fois arrivé, acceptez la permière " + text + "Quête Globale" + text2 + " pour commencer votre aventure !";
            case 3: return "";
            default: return "" + text;
        }
    }
    public override string LabMenuString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Reeste actif quand équipé dans un Emplacement d'Utilitaire";
            case 1: return "Temps de Recharge";
            case 2: return "Vous gagnez " + text + " Points d'Alchimie pour chaque alchimie";
            case 3: return "Cet effet est boosté par la potion de classe inférieure";
            case 4: return "vous avez besoin d'un Emplacement d'Utilitaire";
            case 5: return "Niveau Max";
            case 6: return "File Disponible";
            default: return "" + text;
        }
    }
    public override string SettingMenuString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Si vous avez joué à IEH1, vous pouvez gagner des Talisman Épiques ";
            case 1: return "[ Preuve d'Ascension de IEH1 ]" + text + " basé sur le # de Succès Steam que vous avez reçus.";
            case 2: return "Le montant est limité par la progression dans IEH2.";
            case 3: return "(Depuis le début : 5, Après une Réincarnation de Classe 1 : 10, Après une Classe 2 : 15, Après une Classe 3 : 20)";
            case 4: return "Vous avez reçu";
            case 5: return "# de Succès";
            case 6: return "Si vous avez acheté le CLD de IEH1 [Lot de Support de IEH2], vous pouvez aussi gagner les suivants :";
            case 7: return "Pièce Épique, Limite de Quêtes Acceptées";
            default: return "" + text;
        }
    }
    public override string UpgradeMenuString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "File d'Améliorations";
            case 1: return "La File d'Améliorations va automatiquement acheter une amélioration lorsque vous avez l'Or requis.";
            case 2: return "Clic Droit sur une amélioration pour l'assigner dans la file tandis que Maj + Clic Droit l'enlève de la file.";
            case 3: return "Vous pouvez augmenter votre File d'Améliorations à travers les Quêtes Globales, les effets de Familiers et des achats du Magasin Épique.";
            case 4: return "Gain de Ressources";
            case 5: return "Effet Courant : + " + text + " par défaite ";
            case 6: return "Prochain Effet : + " + text + " per défaite ";
            case 7: return "Incrémentation de l'Effet par Coût d'Or";
            case 8: return "Effet Courant";
            case 9: return "Prochain Effet";
            default: return "" + text;
        }
    }
    public override string WorldAscensionMissionString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Récompense de Point d'AM " + text;
            default: return "" + text;
        }
    }
    public override string WorldMapString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Vous avez " + text + " " + Basic(BasicWord.PortalOrb);
            default: return "" + text;
        }
    }

    public override (string name, string effect) EpicStoreCtrlString(EPIC_STORE item)
    {
        string name = "";
        string effect = "";
        string tempStr = "";
        switch (item.kind)
        {
            case EpicStoreKind.AdditionalEpicCoinDailyQuest:
                name = "Quête Journalière de Pièce Épique Additionnelle";
                effect = "Débloque une nouvelle Quête Journalière de Pièce Épique.";
                break;
            case EpicStoreKind.ImprovingMinimumDailyQuestRarity:
                name = "Amélioration de la Rareté Minimale des Quêtes Journalières";
                tempStr = "Améliore les chances de rareté des Quêtes Journalières : ";
                if (item.IsPurchased(1))
                {
                    tempStr += "\nCommun ( déjà enlevé )";
                    tempStr += ",  Peu Commun ( " + percent(Parameter.dailyQuestRarityChance1[1], 0) + " à être <color=green>Enlevé</color> )";
                    tempStr += ",  Rare ( " + percent(Parameter.dailyQuestRarityChance1[2], 0) + " devient <color=green>" + percent(Parameter.dailyQuestRarityChance2[2], 0) + "</color> )";
                    tempStr += ",  Super Rare ( " + percent(Parameter.dailyQuestRarityChance1[3], 0) + " devient <color=green>" + percent(Parameter.dailyQuestRarityChance2[3], 0) + "</color> )";
                    tempStr += ",  Épique ( " + percent(Parameter.dailyQuestRarityChance1[4], 0) + " devient <color=green>" + percent(Parameter.dailyQuestRarityChance2[4], 0) + "</color> )";
                }
                else//一度も購入してない
                {
                    tempStr += "\nCommun ( de " + percent(Parameter.dailyQuestRarityChance0[0], 0) + " à être <color=green>Enlevé</color> )";
                    tempStr += ",  Peu Commun ( " + percent(Parameter.dailyQuestRarityChance0[1], 0) + " devient <color=green>" + percent(Parameter.dailyQuestRarityChance1[1], 0) + "</color> )";
                    tempStr += ",  Rare ( " + percent(Parameter.dailyQuestRarityChance0[2], 0) + " devient <color=green>" + percent(Parameter.dailyQuestRarityChance1[2], 0) + "</color> )";
                    tempStr += ",  Super Rare ( " + percent(Parameter.dailyQuestRarityChance0[3], 0) + " devient <color=green>" + percent(Parameter.dailyQuestRarityChance1[3], 0) + "</color> )";
                    tempStr += ",  Épique ( " + percent(Parameter.dailyQuestRarityChance0[4], 0) + " devient <color=green>" + percent(Parameter.dailyQuestRarityChance1[4], 0) + "</color> )";
                }
                tempStr += "\nCet effet prend effet dès le lendemain.";
                effect = tempStr;
                break;
            case EpicStoreKind.NitroMaxCharger:
                name = "Chargeur Max de Nitro";
                tempStr = optStrL + "Vous gagnerez instantanément du Nitro égal à la Limite de Nitro. Le montant de Nitro au dessus de la Limite de Nitro est aussi gardé. \nGain courant par achat : <color=green>" + tDigit(game.nitroCtrl.nitroCap.Value()) + " Nitro</color>";
                if (game.nitroCtrl.nitro.IsMaxed()) tempStr += "\n<color=yellow>Vous ne pouvez pas acheter ceci tant que le Nitro n'est pas en dessous de sa limite.</color>";
                effect = tempStr;
                break;
            case EpicStoreKind.AbilityReset:
                name = "Réinitialisation d'Abilité";
                effect = "Réinitialise les Abilités et redonne les Points d'Abilité du Héros couremment en jeu.";
                break;
            case EpicStoreKind.GuildAbilityReset:
                name = "Réinitialisation d'Abilité de Guilde";
                effect = "Réinitialise les Abilités de Guilde et récupère les Points d'Abilité de Guilds dépensés." +
            " Gardez à l'esprit que les objets dans les emplacements d'inventaire étendus seront indisponibles jusqu'à qu'ils soient de nouveau débloqués." +
            " Il est aussi possible qu'il faille réallouer l'Eau Mystérieuse dans les catalystes une nouvelle fois.";
                break;
            case EpicStoreKind.DictionaryUpgradeReset:
                name = "Réinitialisation d'Améliorations de Dictionnaire";
                effect = "Permet de réinitialiser les Améliorations de Dictionnaire de façon permanente. Il sera possible de les réinitialiser et de récupérer ses points à tout moment.";
                break;
            case EpicStoreKind.AdvancedAutoDisassemblingEquipment:
                name = "Auto Désassemblage d'Equipement Avancé";
                effect = "Débloque une option dans le Dictionnaire d'Equipement qui permet d'éviter de désassembler les équipements enchantés.";
                break;
            case EpicStoreKind.AdvancedAutoDisassemblePotion:
                name = "Auto Désassemblage de Potion Avancé";
                effect = "Permet d'ignorer la taille de l'inventaire de potion lors de l'auto désassemblage de potion venant de familiers. (Le bon familier doit être activé pour que cela marche.)";
                break;
            case EpicStoreKind.SuperQueue:
                name = "Super File";
                effect = "Permet d'appuyer sur la touche \"Q\" sur une amélioration pour l'assigner à la Super File qui l'achète continuellement en échangeant 10 emplacements de file, tandis que les touches Maj + \"Q\" l'enlève.";
                break;
            case EpicStoreKind.SuperQueueForAlchemy:
                name = "Super File pour l'Alchimie";
                effect = "Permet d'appuyer sur la touche \"Q\" sur une potion pour l'assigner à la Super File qui l'alchimise jusqu'à remplir un Emplacement d'Inventaire Utilitaire avec cette potion en échangeant 10 emplacements de file d'alchimie, tandis que les touches Maj + \"Q\" l'enlève.";
                break;
            case EpicStoreKind.ClassSkillSlot1:
                name = "Emplacement de Capacité de Classe + 1";
                effect = "Débloque 1 Emplacement de Capacité de Classe pour tous les héros.";
                break;
            case EpicStoreKind.GlobalSkillSlot1:
                name = "Emplacement de Capacité Global + 1";
                effect = "Débloque 1 Emplacement de Capacité Global pour tous les héros.";
                break;
            case EpicStoreKind.EquipmentInventorySlot10:
                name = "Emplacement d'Inventaire d'Equipement + 10";
                effect = "Débloque 10 Emplacements d'Inventaire d'Equipement.";
                break;
            case EpicStoreKind.EquipmentWeaponSlot1:
                name = "Emplacement d'Inventaire d'Arme + 1";
                effect = "Débloque 1 Emplacement d'Inventaire d'Arme pour tous les héros.";
                break;
            case EpicStoreKind.EquipmentArmorSlot1:
                name = "Emplacement d'Inventaire d'Armure + 1";
                effect = "Débloque 1 Emplacement d'Inventaire d'Armure pour tous les héros.";
                break;
            case EpicStoreKind.EquipmentJewelrySlot1:
                name = "Emplacement de Bijou d'Arme + 1";
                effect = "Débloque 1 Emplacement d'Inventaire de Bijou pour tous les héros.";
                break;
            case EpicStoreKind.SkillTenacity:
                name = "Tenacité de Capacité";
                effect = "Débloque une option dans l'onglet Capacité qui permet d'autoriser le lancer d'une capacité aussi tôt que son Temps de Recharge est écoulé peu importe sa Consommation de PM, avec une réduction proportionnelle de l'effet et du gain de maîtrise si la Consommation de PM n'est pas atteinte de ([PM courant du héros] / [Consommation de PM de la capacité])%, avec un minimum de 10%";
                break;
            case EpicStoreKind.EquipmentTenacity:
                name = "Tenacité d'Equipement";
                effect = "Permet d'équiper un équipement pour lequel les requis ne sont pas remplis, avec une réduction proportionnelle de son effet de ([Niveau du Héros et ses Abilités] / [Abilités requises de l'Equipement])%, avec un minimum de 10%. Il permet aussi d'utiliser les enchantements sur les objets équipés.";
                break;
            case EpicStoreKind.AdvancedAutoRebirthTiming:
                name = "Auto Réincarnation Avancée [ Temps ]";
                effect = "Permet de changer le Niveau du Héros et le nombre de Points de Réincarnation auquels effectuer une Auto Réincarnation. (Le bon familier doit être activé pour activer l'auto réincarnation.)";
                break;
            case EpicStoreKind.AdvancedAutoRebirthFavoriteArea:
                name = "Auto Réincarnation Avancée [ Zone Favorite ]";
                effect = "Permet de changer la Zone Favorite dans laquelle vous commencerez juste après une réincarnation. (Le bon familier doit être activé pour activer l'auto réincarnation.)";
                break;
            case EpicStoreKind.AdvancedAutoRebirthTravelingBestExpArea:
                name = "Auto Réincarnation Avancée [ Meilleur Gain d'EXP ]";
                effect = "Débloque une option qui permet d'automatiquement aller dans la zone ayant le meilleur gain d'EXP/sec tous les 25 Niveaux de Héros. Cette fonctionnalité n'est disponible que pour le héros courant.  (Le bon familier doit être activé pour activer l'auto réincarnation.)";
                break;
            case EpicStoreKind.AdvancedAutoAbilityPointAdder:
                name = "Auto Ajouteur de Points d'Abilité Avancé";
                effect = "Permet de donner le nombre maximum de Points d'Abilité à assigner pour chaque Abilité dans l'onglet d'Auto Ajouteur de Points d'Abilité.  (Vous devez d'abord débloquer l'Auto Ajouteur de Points d'Abilité à travers la quête tutoriel)";
                break;
            case EpicStoreKind.UpgradeQueue5:
                name = "File d'Amélioration + 5";
                effect = "Augmente la taille de la File d'Amélioration par 5. Cette file est aussi disponible pour les améliorations de Banque Slime. Effectuez un Clic Droit sur une amélioration pour l'assigner à la File, et Maj + Clic Droit pour l'enlever de la File.";
                break;
            case EpicStoreKind.AlchemyQueue10:
                name = "File d'Alchimie + 10";
                effect = "Augmente la taille de la File d'Alchimie par 10. Effectuez un Clic Droit sur une potion pour l'assigner à la File, et Maj + Clic Droit pour l'enlever de la File.";
                break;
            case EpicStoreKind.AutoDisassembleEquipmentSlot5:
                name = "Emplacement d'Auto Désassemblage d'Equipement + 5";
                effect = "Augmente le nombre d'Emplacements d'Auto Désassemblage d'Equipement par 5. Cliquez sur un équipement dans le dictionnaire pour assigner/enlever l'auto désassemblage lorsqu'il est récolté.";
                break;
            case EpicStoreKind.Tier1RebirthUpgradeReset:
                name = "Réinitialisation d'Améliorations de Réincarnation de Classe 1";
                effect = "Réinitialise les Améliorations de Réincarnation de Classe 1 et rembourse les points du héros courant.";
                break;
            case EpicStoreKind.Tier2RebirthUpgradeReset:
                name = "Réinitialisation d'Améliorations de Réincarnation de Classe 2";
                effect = "Réinitialise les Améliorations de Réincarnation de Classe 2 et rembourse les points du héros courant.";
                break;
            case EpicStoreKind.Tier3RebirthUpgradeReset:
                name = "Réinitialisation d'Améliorations de Réincarnation de Classe 3";
                effect = "Réinitialise les Améliorations de Réincarnation de Classe 3 et rembourse les points du héros courant." +
            " Gardez en tête que les objets dans les emplacements d'équipement étendus ne seront plus disponibles tant qu'ils ne seront pas débloqués de nouveau.";
                break;
            case EpicStoreKind.RebirthTier4UpgradeReset:
                name = "Réinitialisation d'Améliorations de Réincarnation de Classe 4";
                effect = "Réinitialise les Améliorations de Réincarnation de Classe 4 et rembourse les points du héros courant.";
                break;
            case EpicStoreKind.RebirthTier5UpgradeReset:
                name = "Réinitialisation d'Améliorations de Réincarnation de Classe 5";
                effect = "Réinitialise les Améliorations de Réincarnation de Classe 5 et rembourse les points du héros courant.";
                break;
            case EpicStoreKind.RebirthTier6UpgradeReset:
                name = "Réinitialisation d'Améliorations de Réincarnation de Classe 6";
                effect = "Réinitialise les Améliorations de Réincarnation de Classe 6 et rembourse les points du héros courant.";
                break;
            case EpicStoreKind.ActivePetSlot5:
                name = "Emplacement de Familier Actif + 5";
                effect = "Augmente de nombre d'Emplacements de Familier Actif par 5.";
                break;
            case EpicStoreKind.EquipUtilitySlot1:
                name = "Emplacement d'Equipement d'Utilitaire + 1";
                effect = "Débloque 1 Emplacement d'Equipement d'Utilitaire pour tous les héros.";
                break;
            case EpicStoreKind.UtilityInventorySlot5:
                name = "Emplacement d'Inventaire Utilitaire + 5";
                effect = "Débloque 5 Emplacements d'Inventaire Utilitaire.";
                break;
            case EpicStoreKind.Tier1WorldAscensionUpgradeReset:
                name = "Réinitialisation d'Améliorations d'Ascension Monde Classe 1";
                effect = "Réinitialise les Améliorations d'Ascension Monde Classe 1 et rembourse les points associés. Effectue aussi une réinitialisation équivalente à une Ascension Monde Classe 1 sans gagner de points lié au progrès courant. Le meilleur moment pour utiliser ceci est juste après une Ascension Monde.";
                break;
            case EpicStoreKind.FavoriteQuest:
                name = "Quête Favorite";
                effect = "Permet d'assigner une Quête Générale en tant que favorite, ce qui permet de l'accepter et de la compléter automatiquement lorsque ses conditions sont complétées. Le nombre d'emplacement de Quêtes Favorites est le même que la limite de quêtes acceptables.";
                break;
            case EpicStoreKind.Multitrapper:
                name = "Multitrappeur";
                effect = "Permet d'équiper et d'utiliser plusieurs types de pièges pour capturer plusiers couleurs d'ennemis en même temps.";
                break;
            case EpicStoreKind.UtilityKeeper:
                name = "Garde d'Utilitaire";
                effect = "Permet de continuer à équipper des objets utilitaires même s'il n'y en a plus en stock. Cela permet à l'effet de Familier Actif du Slime Magique Normal derester actif.";
                break;
            case EpicStoreKind.Convene:
                name = "Convocation";
                effect = "Débloque un bouton sur l'écran de champ de bataille qui convoque tous les héros passifs en arrière-plan dans la zone où le héros courant se trouve. Acheter [Zone Favorite] déplace tous les héros dans leur zone favorite si vous effectuez un Maj + Click sur le bouton.";
                break;
            case EpicStoreKind.SwarmChaser:
                name = "Chasseur d'Invasion";
                effect = "Débloque un bouton dans l'onglet Options qui permet d'automatiquement aller à une Zone sous Invasion. Pendant une Invasion, [Auto-Réincarnation] et [Meilleur Gain d'EXP] sont désactivés. Déplace aussi tous les héros passifs si [Convocation] est acheté. Tous les héros iront dans leur zone favorite après l'Invasion si [Zone Favorite] est acheté.";
                break;
            case EpicStoreKind.EasyAccessEquipment:
                name = "Accès Facile [Equipement]";
                effect = "Débloque des boutons dans l'onglet Equipement qui permet d'accéder aux emplacements d'équipement des héros en arrière-plan sans avoir à changer de héros.";
                break;
            case EpicStoreKind.AdvancedAutoDisassembleCraftedEquipment:
                name = "Auto-Désassemblage des Equipement Fabriqués Avancé";
                effect = "Autorise la fonction d'Auto-Désassemblage des familiers à utiliser le Multiplicateur en haut à gauche lors du désassemblage d'équipement fabriqué. (Le bon familier doit être activé pour que l'effet marche.)";
                break;
            case EpicStoreKind.AdvancedAutoBuyTraps:
                name = "Auto-Achat de Piège Avancé";
                effect = "Débloque un bouton dans l'onglet Options qui modifie la capacité active des familiers [ Auto-Achat de Pièges dans le Magasin ] pour arrêter d'acheter des pièges après qu'au moins un emplacement d'inventaire d'Utilitaires sout rempli avec ce piège. Désactiver cette option permettra aux familiers achetant des pièges de remplir votre inventaire d'Utilitaires avec des pièges de nouveau.";
                break;
            case EpicStoreKind.AreaDungeonPrestigeReset:
                name = "Réinitialisation de Prestige de Zone/Donjon";
                effect = "Ceci vous permet de réinitialiser les Améliorations de Prestige de chaque zone une seule fois par Ascension Monde. Tout achat supplémentaire permet d'augmenter ce nombre par le nombre acheté.";
                break;
            case EpicStoreKind.ExpeditionTeamSlot1:
                name = "Emplacement d'Equipe d'Expédition + 1";
                effect = "Débloque 1 Emplacement d'Equipe d'Expédition.";
                break;
            case EpicStoreKind.BribesForIEH1:
                name = "Pot de Vin pour IEH1";
                effect = "Donne 1 succès Steam pour IEH1 factice qui permet de récolter un Bonus Joueur supplémentaire dans l'onglet Options > Bonus sans avoir à réellement recevoir le succès dans IEH1. Vous pouvez récolter jusqu'à 20 succès Steam pour IEH1 (réel + factice) en tout.";
                break;
            case EpicStoreKind.EquipmentLoadouts:
                name = "Collection d'Equipement";
                effect = "Débloque des boutons dans l'onglet Equipement qui permet d'avoir différentes collections d'équipement - Tout achat supplémentaire augmente le nombre d'emplacements de collections par le nombre acheté.";
                break;
            case EpicStoreKind.RegularDailyChest:
                name = "Coffre Journalier";
                effect = "Vous recevrez quelques récompenses ci-dessous de façon aléatoire chaque jour !\n- 0%/25%/50%/100% de la Limite de Nitro (peut dépasser la limite)\n- 0/1/2/4 heures de bénédiction d'EXP (seulement pour le héros courant)\n- 0/1/2/5 Orbes de Portail\n- <sprite=\"epiccoin\" index=0> 50/100/250 Pièces Epiques";
                break;
            case EpicStoreKind.SmartUseOfProficiencyScrolls:
                name = "Utilisation Intelligente de Parchemin de Maîtrise";
                effect = "Permet d'automatiquement empêcher le gaspillage de temps lors de l'utilisation d'un [Parchemin de Maîtrise]. Si vous avez un Parchemin de Maîtrise de 45 mins mais l'équipement n'a besoin que de 30 mins, un Parchemin de Maîtrise de 15 mins restera. Maintenir la touche Maj pendant l'utilisation utilise le parchemin jusqu'à ce que l'équipement atteigne son niveau de maîtrise (Nv 10) au lieu du niveau max de l'équipement.";
                break;
            case EpicStoreKind.EasyAccessSkill:
                name = "Accès Facile [Capacité]";
                effect = "Débloque des boutons dans l'onglet Capacité qui permettent d'accéder aux capacités équipées des héros en arrière-plan sans avoir à changer de héros.";
                break;
            case EpicStoreKind.Pause:
                name = "Pause";
                effect = "Débloque un bouton qui permet de mettre le jeu en pause dans l'onglet Options. Vous pouvez toujours intéragir avec le jeu pendant qu'il est mis en pause, pour changer les équipements et les capaciités, acheter des améliorations, ou changer de héros, sans que le Temps de Jeu n'avance. Cela pause aussi le temps des Accomplissements d'Ascension Monde.";
                break;
            case EpicStoreKind.PurpleFoxMastery:
                name = "Maîtrise du Renard Violet";
                effect = "Débloque une option dans l'onglet Options qui permet à la Capacité du Familier Renard Violet de se baser sur le niveau de maîtrise de l'équipement (Nv 10) au lieu du niveau maximum. (Le familier doit être activé pour que l'effet marche.)";
                break;
            case EpicStoreKind.EquipmentEnchantFilter:
                name = "<size=21>Filtres Avancés d'Auto Désassemblage d'Equimenets Enchantés";
                effect = "<size=19>Débloque un bouton [Personnaliser] dans le Dictionnaire qui permet l'utilisation d'un Filtre d'Enchantement, qui permet de spécifier quels enchantements (y compris leur niveau minimum) à exclure de l'option d'auto désassemblage. Vous devez d'abord acheter [Auto Désassemblage d'Equipement Avancé] pour que cela fonctionne.";
                break;
            case EpicStoreKind.EasyAccessQuest:
                name = "Accès Facile [Quête]";
                effect = "Débloque des boutons dans l'onglet Quête qui permet d'accéder aux quêtes des héros en arrière-plan sans avoir à changer de héros.";
                break;
            case EpicStoreKind.SkillLoadouts:
                name = "Collection de Capacité";
                effect = "Débloque des boutons dans l'onglet Capacité qui permet d'avoir de différentes collections de capacités. Tout achat supplémentaire permet d'augmenter ce nombre par le nombre acheté.";
                break;
            case EpicStoreKind.AdvancedAutoProficiencyScroll:
                name = "Utilisation Automatique Avancée de Parchemins de Maîtrise";
                effect = "<size=19>Permet de choisir un équipement sur lequel le Familier Tréant Vert utilise des Parchemins de Maîtrise automatiquement. Appuyez sur Maj et effectuez un clic gauche sur un équipement dans le Dictionnaire pour ajouter ou enlever l'objet de la liste de Parchemin de Maîtrise (dénoté par un P). (Le familier doit être activé pour que l'effet marche.)";
                break;
        }
        return (name, effect);
    }
    public override string HelpNameString(HelpKind kind)
    {
        switch (kind)
        {
            case HelpKind.Heroes: return "Héros";
            case HelpKind.Leveling: return "Montée de Niveau";
            case HelpKind.Hotkeys: return "Raccourcis";
            case HelpKind.WorldMap: return "Carte du Monde";
            case HelpKind.Battle: return "Combat";
            case HelpKind.Capture: return "Capture";
            case HelpKind.Blessing: return "Bénédiction";
            case HelpKind.Debuff: return "Débuff";
            case HelpKind.Ability: return "Abilité";
            case HelpKind.Title: return "Titre";
            case HelpKind.Quest: return "Quête";
            case HelpKind.Skill: return "Capacité";
            case HelpKind.Upgrade: return "Amélioration";
            case HelpKind.Equip: return "Équipement";
            case HelpKind.Lab: return "Lab";
            case HelpKind.Guild: return "Guilde";
            case HelpKind.Town: return "Ville";
            case HelpKind.Bestiary: return "Bestiaire";
            case HelpKind.Shop: return "Magasin";
            case HelpKind.Rebirth: return "Réincarnation";
            case HelpKind.Challenge: return "Défi";
            case HelpKind.Expedition: return "Expédition";
            case HelpKind.WorldAscension: return "Ascension Monde";
            case HelpKind.EpicStore: return "Magasin Épique";
            case HelpKind.S_General: return "Général";
            case HelpKind.S_GuildLevel: return "Guilde";
            case HelpKind.S_Town: return "Ville";
            case HelpKind.S_Rebirth: return "Réincarnation";
            case HelpKind.S_Challenge: return "Défi";
            case HelpKind.S_WorldAscension: return "Ascension Monde";
            case HelpKind.A_All: return "Tout";
            case HelpKind.A_General: return "Général";
            case HelpKind.A_Area: return "Zone";
            case HelpKind.A_Currency: return "Ressources";
            case HelpKind.A_Guild: return "Guilde";
            case HelpKind.A_Challenge: return "Défi";
            case HelpKind.A_Alchemy: return "Alchimie";
            case HelpKind.A_Equip: return "Équipement";
            case HelpKind.A_Skill: return "Capacité";
            case HelpKind.A_Rebirth: return "Réincarnation";
            case HelpKind.A_Playtime: return "Temps de Jeu";
        }
        return kind.ToString();
    }

    public override string HelpString(HelpKind kind)
    {
        string tempStr = optStr + "<size=20>" + HelpNameString(kind) + "<size=18>\n\n";
        switch (kind)
        {
            case HelpKind.Heroes:
                tempStr += "<u>Guerrier</u>";
                tempStr += "\n- Le Guerrier est un héros infligeant des <color=orange>Dégâts Physiques</color> qui se concentre sur l'abattage d'ennemis qui viennent à lui. Il aime utiliser des épées en tant que son arme principale. La majorité de ses capacités ont une portée faible ou ont une zone d'effet limitée. Il excelle au combat contre un seul monstre ou contre des boss. Le guerrier gagne des pierres lorsqu'il tue des monstres.";
                tempStr += "\n\n";
                tempStr += "<u>Mage</u>";
                tempStr += "\n- La mage est un héros infligeant des <color=orange>Dégâts Magiques</color> avec beaucoup de capacités avec effet de zone. Son arme principale est son bâton. Elle excelle au combat contre de gros groupes de monstres, cependant sa santé basse est son point faible. La Mage gagne des crystaux lorsqu'elle tue des monstres.";
                tempStr += "\n\n";
                tempStr += "<u>Ange</u>";
                tempStr += "\n- L'Ange est un héros de support infligeant des <color=orange>Dégâts Physiques</color> et des <color=orange>Dégâts de Lumière</color>, qui comporte aussi une collection de buffs. Son arme principale est ses ailes. Elle excelle au soin et à donner des buffs à elle-même et aux autres héros. Ses dégâts faibles est son point faible. L'Ange gagne des feuilles lorsqu'elle tue des monstres.";
                tempStr += "\n\n";
                tempStr += "<u>Voleur</u>";
                tempStr += "\n- Le Voleur est un héros furtif qui inflige des <color=orange>Dégâts Physiques</color> et des <color=orange>Dégâts de Ténèbres</color>. Il a un mix de capacités de mélée et à distance. Ses deux atouts sont sa Vitesse et son taux d'Apparition d'Equipement, ce qui en fait un excellent farmeur. Il a une santé et défense plus basse, ce qui est son point faible. Le Voleur gagne des pierres lorsqu'il tue des monstres.";
                tempStr += "\n\n";
                tempStr += "<u>Archer</u>";
                tempStr += "\n- L'Archer est un héros mobile infligeant un mix de <color=orange>Dégâts Physiques</color> et de <color=orange>Dégâts Magiques</color> tout en se concentrant sur une portée longue qui garde les ennemis loin de lui. Sa santé basse est son point faible. L'Archer gagne des crystaux lorsqu'il tue des monstres.";
                tempStr += "\n\n";
                tempStr += "<u>Dompteuse</u>";
                tempStr += "\n- La Dompteuse est un héros de support qui laisse ses Familiers infliger les dégâts pour elle. Les Familiers peuvent infliger des <color=orange>Dégâts Physiques</color> comme des <color=orange>Dégâts Magiques</color> – cela dépend des Familiers. Les dégâts faibles venant de la Dompteuse est son point faible car cela prend du temps de gagner la loyauté des Familiers pour qu'ils commencent à infliger des dégâts. La Dompteuse gagne des feuilles lorsqu'elle tue des monstres.";
                tempStr += "\n\n";
                break;
            case HelpKind.Leveling:
                tempStr += "Augmenter le niveau du héros est très important. Vous recevrez des <color=orange>Points de Capacité</color> et de l'<color=orange>EXP de Niveau de Guilde</color> à chaque fois que le héros monte de niveau.";
                tempStr += "\n\nVous pouvez gagner de l'EXP pour vos héros en tuant des monstres, en récupérant des récompenses de quêtes ou en complétant des donjons. A chaque fois que vous gagnez de l'EXP, le héros peut gagner jusqu'à <color=orange>30 niveaux à la fois</color>, les quêtes et donjons affichent un indicateur MAX si ses récompenses si cette limite est atteinte pour que vous ne perdez pas d'EXP.";
                tempStr += "\n\n";
                tempStr += "\n";
                tempStr += "<u>Astuces pour monter de niveau plus vite</u>";
                tempStr += "\n\n- Utilisez le bouton <color=orange>Simulation</color> pour chaque Zone sur la Carte Monde. Cela vous permet de voir le Temps de Complétion | Or/Sec | EXP/Sec pour chaque Zone débloquée. C'est un excellent moyen de déterminer où aller avec votre héros pour le monter de niveau.";
                tempStr += "\n\n- Augmenter le niveau du Bâtiment de Ville <color=orange>Statue de Héros</color> donne un bonus de gain d'EXP chaque fois que son niveau augmente.";
                tempStr += "\n\n- Faites en sorte de débloquer des <color=orange>Donjons</color> dans les différentes zones et vérifiez la partie <color=orange>Récompenses</color> sous l'onglet des détails du Donjon pour sa récompense d'EXP. Cela peut vastement booster le niveau du héros.";
                tempStr += "\n\n- Pendant un donjon, openez les <color=orange>Coffres au Trésor</color> car il y a une chance d'obtenir une <color=orange>Bénédiction d'EXP</color>, qui boostera vos gains d'EXP pendant un court moment. Cela augmente aussi la récompense d'EXP, si la bénédiction est toujours active lors de sa complétion.";
                tempStr += "\n\n- Quand vous atteignez la Réincarnation de Classe 1, faites en sorte d'amélirer le Multiplicateur d'EXP le plus possible.";
                tempStr += "\n\n- Atteindre la Rang 2 de la <color=orange>Hutte de l'Alchimiste</color> débloquera une potion d'EXP que les héros peuvent équiper dans un emplacement d'utilitaire pour augmenter ses gains d'EXP.";
                tempStr += "\n\n- Il y a aussi des objets uniques qui ont une augmentation des gains d'EXP en tant que l'un de leurs effets.";
                break;
            case HelpKind.WorldMap:
                tempStr += "Cliquer sur l'icône de Carte en haut à droite de l'écran vous emmènera sur la Carte Monde. C'est ici où vous pourrez voir le nombre d'Orbes Portail en votre possession, et mettre la souris sur le ruban montrera les Paliers de Missions.";
                tempStr += "\n\n";
                tempStr += "<u>Régions</u>";
                tempStr += "\n- Ily a au total 10 régions dans le monde. Chaque région a 8 zones et quelques donjons. Vous pouvez cliquer sur chaque région sur la carte pour accéder aux différentes zones et donjons.";
                tempStr += "\n- Chaque région de nombre impair augmente le Rang des Matériaux de Ville qui sont reçus en tant que récompense de complétion de zone. Par exemple, le Village des Slimes et la Cité des Slimes Magiques donne des Matériaux de Ville de Classe 1, tandis que le Labyrinthe des Araignées et la Grotte des Chauve-Souris donne des Matériaux de Ville de Classe 2.";
                tempStr += "\n\n";
                tempStr += "<u>Simulations</u>";
                tempStr += "\n- Cliquer sur le bouton Simulation ou utiliser le raccourci Maj + S simulera un essai de complétion de la Zone/du Donjon.";
                tempStr += "\n- La simulation donnera une estimation du Temps de complétion, du gain d'Or et du gain d'EXP par seconde que vous recevrez si vous venez à compléter la zone/le donjon.";
                tempStr += "\n\n";
                tempStr += "<u>Zones</u>";
                tempStr += "\n- Les Zones sont composées de 10 vagues de monstres par défaut. A chaque fois que vous complétez la zone, vous recevrez des Matériaux de Ville en tant que récompense.";
                tempStr += "\n- Pour débloquer de nouvelles zones dans les régions, regardez les requis et effectuez ce qui est écrit.";
                tempStr += "\n- Les récompenses de Matériaux de Ville vont dans un ordre cyclique. La 1ère Zone donnera des Briques, la 2nde des Buches, et la 3ème des Éclats. Ce cycle continue jusqu'à la 8ème Zone, qui donne un mix des 3 différents Matériaux de Ville.";
                tempStr += "\n- La prochaine région continue le cycle de la précédente en commençant par le prochain Matériau de Ville après celui de sa Zone 7.";
                tempStr += "\n\n";
                tempStr += "<u>Missions de Zone/u>";
                tempStr += "\n- Chaque Zone a deux missions au début, qui peuvent être complétées pour gagner des Pièces Epiques et qui comptent pour le compte des Paliers de Mission. Cela peut être amélioré à l'aide du Prestige de Zone détaillé ci-dessous.";
                tempStr += "\n\n";
                tempStr += "<u>Prestige de Zone</u>";
                tempStr += "\n- Vous devez effectuer une Ascension Monde pour que ce Prestige soit débloqué.";
                tempStr += "\n- Pour gagner des Points de Prestige de Zone, vous devez compléter la zone un certain nombre de fois. La fenêtre de détails de la zone vous dira le nombre de complétions requises pour gagner le prochain point.";
                tempStr += "\n- Il y a 6 différentes améliorations qui peuvent être choisies.";
                tempStr += "\n  - Prestige de Zone : Augmente la difficulté de la zone jusqu'à 10. Chaque nouvelle difficulté a les mêmes missions mais aussi des monstres plus forts et un plus grand nombre de vagues.";
                tempStr += "\n  - Bénédiction de l'Explorateur : Augmente le nombre de Complétions de 1 par complétion. ";
                tempStr += "\n  - Bonus d'EXP : Augmente les gains d'EXP par un pourcentage donné dans la région entière.";
                tempStr += "\n  - Challengeur de Mission : Ajoute une autre mission à chaque Zone, jusqu'à 5 missions par Zone.";
                tempStr += "\n  - Un Moment pour Respirer : Réduit le nombre de vagues par 5 pour chaque achat. Le nombre minimum de vagues est 10.";
                tempStr += "\n  - Bonus de Vitesse : Augmente la Vitesse de déplacement par un pourcentage donné dans la région entière.";
                tempStr += "\n\n";
                tempStr += "<u>Donjons</u>";
                tempStr += "\n- Chaque région a sa propre collection de donjons qui peuvent être débloqués.";
                tempStr += "\n- Chaque entrée dans un donjon a un coût d'Orbes de Portail dépendant du Donjon. ";
                tempStr += "\n- Vous avez un temps limité pour compéter le donjon, qui peut être augmenté à travers la Recherche de Ville, les Coffres au Trésor, et les améliorations de Prestige de Donjon.";
                tempStr += "\n- Les Donjons sont une bonne source d'Or, d'EXP, d'Eclats Enchantés et d'autres matériaux. Ils sont très utiles pour atteindre votre premier requis de niveau de réincarnation.";
                tempStr += "\n\n";
                tempStr += "<u>Prestige de Donjon</u>";
                tempStr += "\n- Vous devez effectuer une Ascension Monde pour que ce Prestige soit débloqué.";
                tempStr += "\n- Comme un Prestige de Zone, vous devez compléter un donjon un certain nombre de fois avant de gagner des Points de Prestige.";
                tempStr += "\n- Améliorations de Prestige de Donjon";
                tempStr += "\n  - Prestige de Zone : Augmente la difficulté de la zone jusqu'à 10. Chaque nouvelle difficulté a des monstres plus forts et un plus grand nombre de vagues. Elle permettent aussi d'augmenter les récompenses reçues après complétion.";
                tempStr += "\n  - Temps Additionnel : Augmente le temps de Complétion du Donjon par 60 secondes pour chaque achat.";
                tempStr += "\n  - Clé de Portail : Réduit le nombre d'Orbes utilisées pour entrer dans le donjon. Le coût d'Orbes Portail minimum est de 1.";
                tempStr += "\n  - Chasseur de Trésor : Augmente les chances de recevoir un coffre au trésor en tuant un monstre dans le donjon.";
                tempStr += "\n  - Chasseur de Métal : Augmente les chances d'apparition de Monstres Métalliques.";
                break;
            case HelpKind.Battle:
                tempStr += "<u>Système de Combat</u>";
                tempStr += "\n- Lorsque vous jouez en tant que l'un des six héros disponibles, le combat ne s'arrête jamais.";
                tempStr += "\n- Vous pouvez aussi activer les autres héros en arrière-plan une fois que le titre [Preuve de Reinc.] est acquis.";
                tempStr += " Une Réincarnation de Classe 1 doit être complétée pour acquérir le titre [Preuve de Reinc. 1], une Réincarnation de Classe 2 doit être complétée pour acquérir le titre [Preuve de Reinc. 2], et cetera.";
                tempStr += "\n- Les héros en arrière-plan gagnent la même chose que s'ils sont actifs, à un taux réduit. Ils sont notés comme Passifs dans l'onglet Guilde.";
                tempStr += "\n- L'obtention d'un titre [Preuve de Réinc.] supplémentaire augmente l'efficacité de ce héros tant qu'il est actif en arrière-plan et non pas le héros couremment en jeu.";
                tempStr += "\n\n";
                tempStr += "<u>Portée de Combat</u>";
                tempStr += "\n- La Portée de Combat est une valeur qui indique la distance minimale entre le héros et le monstre pour que l'attaque connecte en combat.";
                tempStr += "\n- Vous pouvez changer la portée de combat du héros actuel en cliquant le bouton en bas à gauche, au dessus de la barre de PV.";
                tempStr += "\n- La majorité des capacités des héros ont une portée, les héros doivent être à portée de l'ennemi avant de lancer leur capacité sur un monstre.";
                tempStr += "\n- Vous pouvez mettre votre souris sur une capacité pour voir sa portée sur le champ de bataille, que vous pouvez aussi désactiver dans l'onglet Options.";
                tempStr += "\n\n";
                tempStr += "<u>Montée de Niveau</u>";
                tempStr += "\n- Gagner tout type d'EXP permet de gagner jusqu'à 30 niveaux pour un héros en une seule fois. Cela inclut vaincre des monstres, récupérer des récompenses de quête, et les récompenses de donjon. Référez-vous à l'onglet d'aide sur la Montée de Niveau.";
                tempStr += "\n\n";
                tempStr += "<u>Dégâts Infligés</u>";
                tempStr += "\n- Tout d'abord, les dégâts d'une capacité sont calculés comme ceci : [ATQ/MATQ du Héros] * [Multiplicateur de Dégâts de la Capacité]";
                tempStr += "\n- ensuite, quand un monstre reçoit l'attaque de la capacité : les dégâts sont réduits par la DEF et le pourcentage de résistance élémentaire du monstre";
                tempStr += "\n- Après cela, les dégâts sont multipliés par [% de Dégâts Physiques/de Feu/de Glace/d'Electricité/de Lumière/de Ténèbres] et [% de Dégats spécifiques au monstre à travers les effects d'Equipements uniques]";
                tempStr += "\n\n";
                tempStr += "<u>Dégâts Reçus</u>";
                tempStr += "\n- Test du % de Nullification des Dégâts - Aucun dégât n'est reçu. Si ce test a échoué, ces prochains points arrivent dans l'ordre qu'ils sont donnés";
                tempStr += "\n- L'ATQ/MATQ réduite par la DEF/MDEF du Héros";
                tempStr += "\n- Les dégâts réduits par le [% de Résistance] (MAX : 90%) - Si le % de résistance est négatif, les dégâts reçus sont augmentés par [% de Resistance] (aucune limite)";
                tempStr += "\n- En troisième, les dégâts après l'application du [% de Résistance] arrivent. L'absorption soigne l'utilisateur par le % d'Absorption (MAX : 90%)";
                tempStr += "\n\n";
                tempStr += "\nExemple de dégâts reçus.";
                tempStr += "\nRésistance au Feu de 80%";
                tempStr += "\nAbsorption du Feu de 20%";
                tempStr += "\nChance de Nullification de Feu à 10%";
                tempStr += "\net si vous recevez 10000 dégâts de feu,";
                tempStr += "\nD'abord, vous avez 10% de chance de ne recevoir aucun dégât.";
                tempStr += "\nSi le nombre aléatoire choisit les 90% restants, alors";
                tempStr += "\nA travers la Résistance, 10000 * (1.00 - 0.80) = 2000 dégâts reçus.";
                tempStr += "\nEnsuite, à travers l'Absorption, 2000 * 0.20 = 400 PV restaurés.";
                break;
            case HelpKind.Capture:
                tempStr += "Êtes-vous fatigués de tuer toutes les créatures que vous rencontrez sans réfléchir ? Voudriez-vous essayer de coopérer avec elles en les enfermant dans un filet avant de les forcer à faire ce que vous voulez ?";
                tempStr += "\n\n";
                tempStr += "<u>Titres</u>";
                tempStr += "\n- Eh bien, il est impossible de capturer un monstre sans les comprendre. Votre héros a besoin du titre <color=orange>Etude de Monstre</color> ou tout essai de capture de monstre sera un échec.";
                tempStr += "\n\n";
                tempStr += "<u>Pièges</u>";
                tempStr += "\n- Vous aurez aussi besoin d'être équipé du bon type de <color=orange>Piège</color> pour le monstre que vous voulez capturer, que vous pouvez acheter dans l'onglet <color=orange>Magasin</color>. Les monstres de couleurs différentes ont différentes forces et faiblesses, donc seul le bon type de filet peut contenir un monstre avec succès.";
                tempStr += "\n\n";
                tempStr += "<u>Puissance</u>";
                tempStr += "\n- Même si vous savez comment capturer un monster, il n'y a aucun intérêt à moins d'être assez puissant pour contenir le monstre jusqu'à qu'il décide de faire ce que vous voulez. Le niveau et les connaissances sur les monstres du héros déterminent la puissance maximale que peut avoir un monstre qu'il peut capturer. Pendant votre progression en jeu, d'autres mécaniques peuvent améliorer votre technique pour vous adier à capturer des monstres plus forts.";
                tempStr += "\n\n";
                tempStr += "<u>Technique</u>";
                tempStr += "\n- Une fois que vous êtes équippés du bon piège et que vous avez le bon titre, effectuez un <color=orange>Clic Droit</color> sur le monstre dans l'aire de jeu avant que le héros ne le tue. S'il est de la bonne couleur et qu'il n'est pas trop fort, vous devriez réussir votre capture et les pièges entreront une période de recharge avant de pouvoir capturer un autre monstre. Attrappez assez de ce type spécifique de monstre et vous pourrez augmenter son rang en tant que familier, voir la section Bestiaire pour plus d'informations.";
                tempStr += "\n- Encore une fois, progresser dans le jeu peut mener à découvrir des techniques de captures de monstres plus efficaces, mais voici les bases que chaque héros doit savoir.";
                break;
            case HelpKind.Blessing:
                tempStr += "<u>Buffs ou Bénédictions</u>";
                tempStr += "\nCes buffs peuvent être achetés dans le Magasin; la Bénédiction de PV est la première bénédiction débloquée qui est achetable.";
                tempStr += " Toutes les autres sont débloquées à travers le bâtiment de ville Temple.";
                tempStr += " Vous pouvez aussi augmenter le % d'effet et la durée des bénédictions à travers la Recherche dans le bâtiment de ville Temple.";
                tempStr += " Ces bénédictions sont aussi obtenables en ouvrant des Coffres au Trésor dans les Donjons de manière aléatoire.";
                tempStr += "\n\nAPPLIQUER LE MEME BUFF NE FERA QUE L'APPLIQUER DE NOUVEAU - IL NE SONT PAS COMBINES";
                tempStr += "\n\n- Bénédiction de PV – Multiplie la statistique de PV max par un certain % pour une durée donnée.";
                tempStr += "\n- Bénédiction d'ATQ – Multiplie la statistique d'ATQ totale par un certain % pour une durée donnée.";
                tempStr += "\n- Bénédiction de MATQ – Multiplie la statistique de MATQ totale par un certain % pour une durée donnée.";
                tempStr += "\n- Bénédiction de Vitesse – Multiplie la statistique de Vitesse de Déplacement par un certain % pour une durée donnée.";
                tempStr += "\n- Bénédiction de Maîtrise de Capacité - Multiplie les gains de Maîtrise de Capacité par un certain % pour une durée donnée.";
                tempStr += "\n- Bénédiction de Maîtrise d'Équipement - Multiplie les gains de Maîtrise d'Equipement par un certain % pour une durée donnée.";
                tempStr += "\n- Bénédiction de Gain d'Or - Multiplie les Gains d'Or par un certain % pour une durée donnée.";
                tempStr += "\n- Bénédiction de Gain d'EP - Multiplie les Gains d'EXP par un certain % pour une durée donnée.";
                tempStr += "\n\n";
                break;
            case HelpKind.Debuff:
                tempStr += "<u>Débuffs</u>";
                tempStr += "\nLes héros et monstres peuvent tous deux appliquer des débuffs l'un sur l'autre.";
                tempStr += " Les héros devront utiliser certaines capacités pour appliquer les débuffs.";
                tempStr += " Il y a aussi des débuffs de terrain. Regarder l'onglet de détails de la carte montrera quels débuffs de terrain et leurs % seront appliqués une fois la Zone/le Donjon atteint.";
                tempStr += " Vous pouvez réduite les effets des débuffs de terrain à travers une Recherche du Cartographeur.";
                tempStr += " Il y a plusieurs potions et équipements qui peuvent aider avec la Résistance d'Element pour contrer les débuffs d'élement.";
                tempStr += "\n";
                tempStr += "\n- Réduction d'ATQ – Réduit l'ATQ de l'ennemi par 50% pour une durée donnée.";
                tempStr += "\n- Réduction de MATQ – Réduit la MATQ de l'ennemi par 50% pour une durée donnée.";
                tempStr += "\n- Réduction de DEF – Réduit la DEF de l'ennemi par 50% pour une durée donnée.";
                tempStr += "\n- Réduction de MDEF – Réduit la MDEF de l'ennemi par 50% pour une durée donnée.";
                tempStr += "\n- Réduction de VIT – Réduit la VIT et la Vitesse de Déplacement de l'ennemi par 50% pour une durée donnée.";
                tempStr += "\n- Gel – Les Attaques et le Déplacement de l'ennemi stoppe pendant 1 seconde.";
                tempStr += "\n- Electrifié – L'ennemi reçoit 10% de dégâts supplémentaires.";
                tempStr += "\n- Poison – Inflige des Dégâts à l'ennemi chaque seconde pour une certaine durée. (Le montant de Dégâts de Poison est basé sur la capacité qui donne le débuff)";
                tempStr += "\n- Mort Subite – Tue la cible instantanément. Les capacités qui ont ce débuff ont une chance mince qu'elle s'active.";
                tempStr += "\n- Poussée – L'ennemi est projeté en arrière et est étourdi pendant 0.5 seconde.";
                tempStr += "\n- Réduction de la Résistance au Feu – Réduit la statistique de Résistance au Feu par 100% pour une durée donnée.";
                tempStr += "\n- Réduction de la Résistance à la Glace – Réduit la statistique de Résistance à la Glace par 100% pour une durée donnée.";
                tempStr += "\n- Réduction de la Résistance à l'Electricité – Réduit la statistique de Résistance à l'Electricité par 100% pour une durée donnée.";
                tempStr += "\n- Réduction de la Résistance à la Lumière – Réduit la statistique de Résistance à la Lumière par 100% pour une durée donnée.";
                tempStr += "\n- Réduction de la Résistance aux Ténèbres – Réduit la statistique de Résistance aux Ténèbres par 100% pour une durée donnée.";
                tempStr += "\n- Gravité – Attire les ennemis vers le centre du champ de gravité.";
                break;
            case HelpKind.Hotkeys:
                tempStr += "<u>Général</u>";
                tempStr += "\n- <color=orange>+</color> / <color=orange>-</color> : Augmente / Réduit le coefficient d'achat";
                tempStr += "\n- <color=orange>W, A, S, D</color> ou les <color=orange>Flèches</color> : Déplacer le héros en jeu manuellement";
                tempStr += "\n- <color=orange>Tab</color> / <color=orange>Ctrl + Tab</color> : Ouvre le prochain onglet / l'onglet précédent";
                tempStr += "\n- <color=orange>T</color> ou </color=orange>Echap</color> : Enlève l'infobulle courante (utile si une infobulle est coincée)";
                tempStr += "\n- <color=orange>Maj + P</color> : Entrer/Sortir du Mode Performance";
                tempStr += "\n- <color=orange>Maj + F</color> : Montre le coût max (jusqu'au Niveau 100) pour certaines améliorations. Un bon exemple permet devoir combien de temps il vous prendra avant qu'un équipement aille du niveau 0 au niveau 10, ou même jusqu'au niveau 20 !";
                tempStr += "\n\n";
                tempStr += "<u>Onglet Quêtes</u>";
                tempStr += "\n- <color=orange>Maj + Clic Gauche</color> le bouton pour accepter : Accepter et se déplacer vers la quête instantanément"; //TOCHECK
                tempStr += "\n- <color=orange>Clic Droit</color> sur les boutons Global/Journalier : Accepter ou réclamer toutes les quêtes";
                tempStr += "\n- <color=orange>Clic Droit</color> sur un bouton de quête : Accepter ou réclamer la quête";
                tempStr += "\n- <color=orange>Maj + Clic Droit</color> sur un bouton de quête : Accepter et se déplacer vers la quête instantanément, ou juste réclamer la quête";
                tempStr += "\n\n";
                tempStr += "<u>Onglet Améliorations</u>";
                tempStr += "\n- <color=orange>Clic Droit</color> : Ajoute l'amélioration dans la file (Note : Cela requiert avoir des emplacements de file d'améliorations depuis un effet de Familier ou un achat dans le Magasin Epique)";
                tempStr += "\n- <color=orange>Maj + Clic Droit</color> : Enlève l'amélioration de la file";
                tempStr += "\n- <color=orange>Q</color> : Ajoute l'amélioration dans une Super File en utilisant 10 emplacements de file (Note: Ceci requiert un achat dans le Magasin Epique)";
                tempStr += "\n\n";
                tempStr += "<u>Onglet Equipements</u>";
                tempStr += "\n- <color=orange>Double Clic Gauche</color> : L'Equipement ou l'Utilitaire sera équipé/deséquipé, si un emplacement est libre.";
                tempStr += "\n- Effectuer un <color=orange>Clic Gauche</color> en maintenant <color=orange>Maj + D</color> sur un <color=orange>Objet</color> : l'Equipement/Utilitaire sera désassemblé.";
                tempStr += "\n- Effectuer un <color=orange>Double Clic Gauche</color> en maintenant <color=orange>Maj + D</color> sur le <color=orange>Bouton Désassembler</color> : Désassemble tous les objets dans l'Inventaire d'Equipement qui ne sont pas verrouillés.";
                tempStr += "\n- <color=orange>L</color> : Vérouille / Déverrouille un objet.";
                tempStr += "\n- Effectuer un <color=orange>Clic Gauche</color> en maintenant <color=orange>Maj</color> sur le <color=orange>Bouton de Tri</color> : Effectue le tri en ordre inverse.";
                tempStr += "\n- Glisser-déposer des Parchemins de Maîtrise ou des Enclumes ensemble en maintenant <color=orange>Maj</color> : Combine le même type d'effet.";
                tempStr += "\n- Glisser-déposer un Parchemin de Maîtrise sur un emplacement vide en maintenant <color=orange>Maj</color> : Sépare (valeur du multiplicateur) secondes du parchemin.";
                tempStr += "\n- Glisser-déposer une Enclume sur un emplacement vide en maintenant <color=orange>Maj</color> : Sépare (valeur du multiplicateur) de l'effet de l'enclume, mesuré en nombre entier.";
                tempStr += "\n- Glisser-déposer un objet Utilitaire dans un emplacement vide en maintenant <color=orange>Maj</color> : Sépare son # de pile basé sur le multiplicateur sélectionné en haut à gauche.";
                tempStr += "\n- <color=orange>Clic Gauche</color> sur un équipement dans le dictionnaire : Ajoute l'équipement cliqué dans la liste d'Auto Désassemblage (noté par un D). Effectuez un autre Clic Gauche pour l'enlever de la liste. (Note : Requiert des améliorations de ville ou des effets de familier)";
                tempStr += "\n- <color=orange>Maj + C</color> un équipement dans le dictionnaire : Fabrique cet objet. (Note : Requiert une amélioration de ville)";
                tempStr += "\n\n";
                tempStr += "<u>Onglet Lab</u>";
                tempStr += "\n- <color=orange>Clic Gauche</color> sur une potion: Ajoute la potion dans la file d'alchimie (Note : Requiert une file d'alchimie récupérable à travers les effets de familier ou un achat dans le Magasin Epique)";
                tempStr += "\n- <color=orange>Maj + Clic Droit</color> : Enlève la potion de la file";
                tempStr += "\n- <color=orange>Q</color> : Ajoute la potion dans la Super File en échange de 10 emplacements de file d'alchimie (Note : Requiert un achat dans le Magasin Epique)";
                tempStr += "\n\n";
                break;
            case HelpKind.Ability:
                tempStr += "<u>Statistiques</u>";
                tempStr += "\n- VTL : Augmente les PV | la DEF | la MDEF";
                tempStr += "\n- FOR : Augmente l'ATQ | la DEF";
                tempStr += "\n- INT : Augmente les PM | la MATQ | la MDEF";
                tempStr += "\n- AGI : Augmente les PM | VIT | Vitesse de Déplacement";
                tempStr += "\n- CHA : Augmente la Chance de Coup Critique | la Chance d'Apparition d'Equipement";
                tempStr += "\n\n";
                tempStr += "Les statistiques sont calculées comme ci-dessous.";
                tempStr += "\n- PV = [BASE] + [INCREMENT] x VTL  :  <color=orange>" + localized.BasicStatsDescription(BasicStatsKind.HP) + "</color>";
                tempStr += "\n- PM = [BASE] + [INCREMENT] x (INT+AGI)/2  :  <color=orange>" + localized.BasicStatsDescription(BasicStatsKind.MP) + "</color>";
                tempStr += "\n- ATQ = [BASE] + [INCREMENT] x FOR  :  <color=orange>" + localized.BasicStatsDescription(BasicStatsKind.ATK) + "</color>";
                tempStr += "\n- MATQ = [BASE] + [INCREMENT] x INT  :  <color=orange>" + localized.BasicStatsDescription(BasicStatsKind.MATK) + "</color>";
                tempStr += "\n- DEF = [BASE] + [INCREMENT] x (VTL+FOR)/2  :  <color=orange>" + localized.BasicStatsDescription(BasicStatsKind.DEF) + "</color>";
                tempStr += "\n- MDEF = [BASE] + [INCREMENT] x (VTL+INT)/2  :  <color=orange>" + localized.BasicStatsDescription(BasicStatsKind.MDEF) + "</color>";
                tempStr += "\n- VIT = [BASE] + [INCREMENT] x AGI  :  <color=orange>" + localized.BasicStatsDescription(BasicStatsKind.SPD) + "</color>";
                tempStr += "\n- Chance de Coup Critique Physique = [BASE] + [INCREMENT] x CHA  :  <color=orange>Chance de multiplier les dégâts par 2.0x ou plus.</color>";
                tempStr += "\n- Chance de Coup Critique Physique = [BASE] + [INCREMENT] x CHA  :  <color=orange>Chance de multiplier les dégâts par 2.0x ou plus.</color>";
                tempStr += "\n- Chance d'Apparition d'Equipement = [BASE] + [INCREMENT] x CHA^(2/3)  :  <color=orange>Augmente la Chance d'Apparition d'Equipement ( N'inclut pas les Equipements Uniques )</color>";
                tempStr += "\n- Vitesse de Déplacement = [BASE] + [INCREMENT] x AGI^(2/3)  :  <color=orange>Augmente la vitesse de déplacement sur le champ de bataille</color>";
                tempStr += "\n\n";
                tempStr += "<u>[BASE] Statistiques Basiques</u>";
                for (int j = 0; j < Enums.heroKindLength; j++)
                {
                    int countJ = j;
                    tempStr += "\n- " + localized.Hero((HeroKind)countJ) + " : ";
                    for (int i = 0; i < Enums.basicStatsKindLength; i++)
                    {
                        int countI = i;
                        tempStr += localized.BasicStats((BasicStatsKind)countI) + " " + tDigit(Parameter.baseStats[countJ][countI], 1) + " | ";
                    }
                }
                tempStr += "\n\n";
                tempStr += "<u>[INCREMENT] Statistiques Basiques</u>";
                for (int j = 0; j < Enums.heroKindLength; j++)
                {
                    int countJ = j;
                    tempStr += "\n- " + localized.Hero((HeroKind)countJ) + " : ";
                    for (int i = 0; i < Enums.basicStatsKindLength; i++)
                    {
                        int countI = i;
                        tempStr += localized.BasicStats((BasicStatsKind)countI) + " " + tDigit(Parameter.stats[countJ][countI], 1) + " | ";
                    }
                }
                tempStr += "\n\n";
                tempStr += "<u>[BASE] Statistiques</u>";
                for (int j = 0; j < Enums.heroKindLength; j++)
                {
                    int countJ = j;
                    tempStr += "\n- " + localized.Hero((HeroKind)countJ) + " : ";
                    tempStr += "Chance Crit. Phy. " + percent(Parameter.baseStats[countJ][7], 3) + " | ";
                    tempStr += "Chance Crit. Mag. " + percent(Parameter.baseStats[countJ][8], 3) + " | ";
                    tempStr += "Chance Equip " + percent(Parameter.baseStats[countJ][10], 3) + " | ";
                    tempStr += localized.Stat(Stats.MoveSpeed) + " " + meter(Parameter.baseStats[countJ][11]) + " / sec";
                }
                tempStr += "\n\n";
                tempStr += "<u>[INCREMENT] Stats</u>";
                for (int j = 0; j < Enums.heroKindLength; j++)
                {
                    int countJ = j;
                    tempStr += "\n- " + localized.Hero((HeroKind)countJ) + " : ";
                    tempStr += "Chance Crit. Phy. " + percent(Parameter.stats[countJ][7], 3) + " | ";
                    tempStr += "Chance Crit. Mag. " + percent(Parameter.stats[countJ][8], 3) + " | ";
                    tempStr += "Chance Equip " + percent(Parameter.stats[countJ][10], 3) + " | ";
                    tempStr += localized.Stat(Stats.MoveSpeed) + " " + meter(Parameter.stats[countJ][11]) + " / sec";
                }
                tempStr += "\n\n";
                break;
            case HelpKind.Title:
                tempStr += "Les titres donnent des bonus uniques spécifiquement au héros qui l'a obtenu. Ils sont acquis à travers les <color=orange>Quêtes de Titre</color>. Sous l'onglet Capacité, vous pouvez cliquer sur Tire à droite pour voir les titres et bonus du héros.";
                tempStr += "\n\n";
                break;
            case HelpKind.Quest:
                tempStr += "<u>Quête Globale</u>";
                tempStr += "\n- Les quêtes globales forment le tutoriel du jeu, et sont requises pour débloquer de nouvelles fonctionnalités une fois que vous êtes prêts.";
                tempStr += "\n- Elles sont partagées entre tous les héros.";
                tempStr += "\n- Elles ne comptent pas pour la limite de Quêtes Acceptées.";
                tempStr += "\n- Elles ne sont jamais réinitialisées.";
                tempStr += "\n\n";
                tempStr += "<u>Quête Journalière</u>";
                tempStr += "\n- Les quêtes journalières sont une bonne source de Pièces Epiques et d'Orbes Portail.";
                tempStr += "\n- Elles sont partagées entre tous les héros.";
                tempStr += "\n- Elles ne comptent pas pour la limite de Quêtes Acceptées.";
                tempStr += "\n- Elles sont réinitialisées à minuit dans la tranche horaire définie pour votre compte Steam.";
                tempStr += "\n\n";
                tempStr += "<u>Quête de Titre</u>";
                tempStr += "\n- Les quêtes de titre donnent des bonus à chaque héros qui complète la quête. Regardez-les régulièrement pour voir si un de vos héros est éligible pour de nouveaux ou de meilleurs titres !";
                tempStr += "\n- Chaque héros doit compléter une quête de titre pour avoir accès au titre seulement pour eux.";
                tempStr += "\n- Elles COMPTENT pas pour la limite de Quêtes Acceptées.";
                tempStr += "\n- Elles ne sont réinitialisées qu'après une Ascension Monde de classe haute.";
                tempStr += "\n\n";
                tempStr += "<u>Quête Générale</u>";
                tempStr += "\n- Les quêtes générales donnent des tâches à faire à vos héros pour prouver à quel point ils sont héroiques, et donnent de l'expérience, de l'or ou des matériaux en tant que récompense. Mais surtout elles prouvent à quel point ils sont héroiques.";
                tempStr += "\n- Chaque héros doit compléter les quêtes générales par eux-mêmes. L'usurpation n'est pas acceptée !";
                tempStr += "\n- Elles COMPTENT pas pour la limite de Quêtes Acceptées.";
                tempStr += "\n- Elles sont réinitialisées après une Réincarnation er une Ascension Monde, mais certaines de ses récompenses peuvent persister.";
                tempStr += "\n\n";
                tempStr += "<u>Limite de Quêtes Acceptées</u>";
                tempStr += "\n- Chaque héros a une limite de quêtes générales et de titre (combinées) qu'il peut accepter à la fois.";
                tempStr += "\n- Une fois cette limite atteinte, vous devrez compléter ou annuler une des quêtes en cours pour en accepter une nouvelle.";
                tempStr += "\n- Il est possible d'augmenter cette limite à travers une amélioration de Réincarnation.";
                tempStr += "\n\n";
                tempStr += "<u>Quête Favorite (Achat du Magasin Epique)</u>";
                tempStr += "\n- Cela vous permet d'assigner des quêtes générales en tant que favorite ce qui comptera pour la Limite de Quêtes Acceptées. Les quêtes favorites seront automatiquement acceptées puis réclamées une fois leurs conditions remplies.";
                tempStr += "\n\n";
                break;
            case HelpKind.Skill:
                tempStr += "Chaque héros a 10 capacités différentes qui peuvent être utilisées en jeu en les plaçant sur les Emplacements de Capacité de Classe et les Emplacements de Capacité Global disponibles. Cependant, vous pouvez seulement utiliser les capacités des autres héros dans les Emplacements de Capacité Global." +
                    "\n\nPour commencer à utiliser les capacités, elles doivent d'abord atteindre le Rang 1. Pour augmenter leur rang, vous devez posséder les Ressources requises. Vous pouvez voir ce qui est requis en déplaçant votre souris sur l'icône de ressouce à côté de la capacité. " +
                    "Après avoir augmenté le rang de la capacité, cela augmentera le niveau maximum de la capacité associée par 5. " +
                    "\n\nPour augmenter le niveau de la capacité, vous devez utiliser la capacité en la mettant dans un Emplacement de Capacité de Classe. Vous pouvez augmenter la vitesse de la montée de niveau en augmentant les Gains de Maîtrise de Capacité. " +
                    "Chaque capacité a différents paliers liés au niveau courant de la capacité. Ces paliers offrent des bonus passifs au héros. Ces bonus ne sont appliqués qu'aux héros possédant cette capacité par défaut. Il est possible de partager ce bonus à travers une Amélioration de Réincarnation de Classe 2. " +
                    "\n\nDes Emplacements de Capacité de Classe et des Emplacements de Capacité Globales supplémentaires peuvent être débloqués au fil du jeu.";
                tempStr += "\n\n";
                break;
            case HelpKind.Upgrade:
                tempStr += "<u>Amélioration de Ressource</u>";
                tempStr += "\n- L'onglet Ressource vous permet d'augmenter le nombre de ressources lâchées par les monstres en les achetant avec de l'or. Certaines quêtes peuvent aussidébloquer de nouvelles améliorations de gain de ressources.";
                tempStr += "\n\n";
                tempStr += "<u>Améliorations de Statistiques</u>";
                tempStr += "\n- L'onglet Stats donne accès à des bonus lié à différentes statistiques pour tous les héros, pour un coût d'or et de ressources.";
                tempStr += "\n\n";
                tempStr += "<u>Améliorations de Limite d'Or</u>";
                tempStr += "\n- Les améliorations de limite d'or vous permettent d'augmenter la Limite d'Or contre des ressources. Chaque ressource a sa propre amélioration qui vous permet d'augmenter la Limite d'Or.";
                tempStr += "\n\n";
                tempStr += "<u>Améliorations de Banque Slime</u>";
                tempStr += "\n- Débloqué après avoir atteint le Niveau de Guilde 35, la Banque Slime offre de nouvelles améliorations contre des Pièces Slime, qui permettent d'améliorer différents aspects du jeu.";
                tempStr += "\n\n";
                tempStr += "<u>Pièce Slime</u>";
                tempStr += "\n- Les Pièces Slime sont acquises lorsque la Limite d'Or est atteinte. Tout or supplémentaire est transformé en Pièces Slime. Vous pouvez aussi lancer une recherche sur la Banque Slime qui permet de gagner des intérêts sur vos Pièces Slime.";
                tempStr += "\n\n";
                break;
            case HelpKind.Equip:
                tempStr += "<u>Equipement</u>";
                tempStr += "\n- L'onglet Equipement est là où vous trouverez tous les équipements que vous avez ramassés sur le champ de bataille. Pour ramasser un équipement, effectuez un clic gauche sur celui-ci.";
                tempStr += "\n- Pour l'équiper, effectuez un clic gauche et glissez-déposez l'équipement depuis l'Inventaire d'Equipement vers un emplacement vide pour le bon type d'équipement.";
                tempStr += "\n- Tant que l'objet est équipé, il gagnera de la Maîtrise d'Equipement qui peut augmenter le niveau de l'objet, ce qui augmentera son pouvoir. Après avoir atteint le Niveau 10 (Maîtrise) avec ce héros, vous gagnerez un bonus passif. Tous les héros qui portent cet objet gagneront ce bonus passif.";
                tempStr += "\n- Si vous n'avez plus de place dans votre inventaire d'équipement, vous pouvez glisser-déposer un objet dans la bar de désassemblage pour récupérer des matériaux de ville.";
                tempStr += "\n- Il existe aussi un Inventaire d'Enchantements et un Inventaire d'utilitaires dans l'onglet Equipement - Référez-vous à la section d'aide du Laboratoire pour plus d'infos sur les Enchantements et les Utilitaires.";
                tempStr += "\n- Une fois qu'un équipement atteint le niveau 60, il débloquera son premier emplacement de forge. Les emplacements de forge sont débloqués au niveaux 60, 80, 100 et 120 pour chaque équipement.";
                tempStr += "\n- Vous pouvez récupérer les Enclumes requises pour forger l'équipement en complétant des expéditions, à travers des défis de boss, et à travers des donjons loin dans le jeu. Une fois qu'une enclume est obtenue, glissez-déposez la sur votre équipement de niveau 60 ou supérieur lors qu'il se trouve dans l'inventaire.";
                tempStr += "\n\n";
                tempStr += "<u>Dictionnaire</u>";
                tempStr += "\n- L'onglet Dictionnaire dans l'Equipement montre tous les équipements trouvés en jeu jusqu'à présent.";
                tempStr += "\n- A chaque fois qu'un équipement atteint le niveau 10 (pour chaque héros), vous gagnerez des points de dictionnaire qui peuvent être utilisés pour augmenter les Gain de Maîtrise d'Equipement d'un héros donne ou Chasseur d'Equipement qui augmente les chances de trouver des objets sur le champ de bataille.";
                tempStr += "\n- La rareté d'un équipement jour sur les gains de Points de Dictionnaire donnés. Commun : 1, Peu Commun : 2, Rare : 3, Super Rare : 4, et Epique : 5.";
                tempStr += "\n- Dans le Dictionnaire, vous pouvez donner des équipements à auto-désassembler une fois que vous avez la bonne amélioration en cliquant sur l'objet. Vous verrez un D en bas à gauche de l'icône de l'objet, qui indique Désassemblage. L'auto-désassemblage s'effectue lorsqu'un objet est cliqué sur le champ de bataille avec au moins un emplacement d'inventaire vide.";
                tempStr += "\n- À l'aide d'une amélioration de ville, il vous sera aussi possible de fabriquer des équipements.";
                tempStr += "\n\n";
                tempStr += "<u>Talisman</u>";
                tempStr += "\n- Les talismans sont des objets uniques qui donnent des bonus aux héros. Ils peuvent être équipés et ne seront jamais supprimés. Il est possible d'augmenter leurs bonus en ajoutant plusieurs talismans du même type, ce qui créée une pile. Le nombre maximum de la pile est basé sur l'Amélioration d'Alchimie [Capacité Accrue]";
                tempStr += "\n\n";
                break;
            case HelpKind.Lab:
                tempStr += "<u>Alchimie</u>";
                tempStr += "\n\nEau Mystérieuse par Seconde";
                tempStr += "\n- Ceci est la vitesse à laquelle la barre se remplit. Plus le nombre est haut, plus la barre se remplit vite.";
                tempStr += "\n\nEtendre la Limite";
                tempStr += "\n- Cliquez sur ce bouton pour étendre la limite d'Eau Mystérieuse.";
                tempStr += "\n- Vous ne pouvez étendre la limite que lorsque la barre est complètement remplie. Par exemple, quand elle affiche 3 / 3.";
                tempStr += "\n- La Limite d'Eau Mystérieuse est le nombre maximum d'Eau Mystérieuse que vous pouvez posséder.";
                tempStr += "\n- Déplacez votre souris sur le barre pour voir le maximum courant de la limite.";
                tempStr += "\n- Il y a plusieurs moyens de l'augmenter à travers des bâtiments de ville.";
                tempStr += "\n\nCatalystes";
                tempStr += "\n- Les catalystes sont débloqués après avoir dépensé les Matériaux et l'Eau Mystérieuse requise en cliquant sur le signe +.";
                tempStr += "\n- Pour équiper un catalyste après l'avoir débloqué, il faut juste cliquer dessus. Vous verrez une ligne à double épaissure autour de celui-ci, et deux Essences apparaitront plus bas.";
                tempStr += "\n- Les catalystes ont aussi une chance d'effectuer un effet critique, qui procurera un objet d'Alchimie spécial qui peut être utilisé pour des améliorations dans la Ville.";
                tempStr += "\n\nEssence";
                tempStr += "\n- Chaque Catalyste débloqué ont deux Essences attachées à ceux-ci.";
                tempStr += "\n- Chaque Conversion vous procurera un objet de cette Essence, qui est utilisé pour mixer des potions.";
                tempStr += "\n\nConversion";
                tempStr += "\n- Une Conversion arrive lorsque la barre de l'essence est pleine.";
                tempStr += "\n- Pour réduire le temps requis pour remplir la barre de l'essence, ajoutez plus d'Eau Mystérieuse / sec en appuyant sur la flèche ^.";
                tempStr += "\n- Vous avez besoin d'au moins 0.1 Eau Mystérieuse / sec pour l'appliquer à l'Essence.";
                tempStr += "\n\nMixer des Potions";
                tempStr += "\n- C'est ici que vous dépenserez vos essences pour fabriquer des potions.";
                tempStr += "\n\nPoints d'Alchimie";
                tempStr += "\n- Vous recevez des points en mixant des potions que vous pouvez utiliser pour améliorer le niveau des potions, ou sur d'autres améliorations d'alchimie dans le sous-onglet Améliorations, à côté de Mixer des Potions.";
                tempStr += "\n\n";
                tempStr += "\n\n";
                tempStr += "<u>Onglet de Fabrication</u>";
                tempStr += "\nLa “monnaie” principale pour fabriquer des parchemins d'enchantement sont les Eclats Enchantés que vous pouvez récupérer en complétant des donjons. Il est possible de réduire le coût de fabrication à travers le bâtiment de ville Forge (Niveau de Guilde 25) à travers une de ses recherches. ";
                tempStr += "\n\nParchemins";
                tempStr += "\n- Ces parchemins permettent de changer les équipements d'équipements déjà enchantés. Plus de parchemins peuvent être débloqués en améliorant la Forge.";
                tempStr += "\n\nParchemins d'Enchantement";
                tempStr += "\n- Ceux-ci peuvent améliorer votre équipement s'ils ont un emplacement d'enchantement. Ils coûtent des matériaux colorés et des éclats enchantés. Plus de parchemins peuvent être débloqués en améliorant la Forge.";
                tempStr += "\n- Pour utiliser un parchemin d'enchantement, glissez-déposez un Parchemin d'Enchantement depuis l'Inventaire d'Enchantements sur une pièce d'équipement dans l'Inventaire qui a un Emplacement d'Enchantement vide.";
                break;
            case HelpKind.Guild:
                tempStr += "C'est ici que vous pouvez voir votre niveau de Guilde courant, tous les membres de la guilde, et les améliorations de guilde. ";
                tempStr += "\n\n";
                tempStr += "<u>Niveau de Guilde</u>";
                tempStr += "\n- Les niveaux de guilde débloquent des bâtiments de ville et peuvent être un requis pour augmenter le Rang de certains bâtiments de ville.";
                tempStr += "\n- Pour gagner de l'EXP de Guilde, vous devez augmeter le niveau de vos héros. Chaque montée de niveau d'un héros octroie de l'EXP de Guilde. ( MATH: Gain d'EXP de Guilde = [200 + 5 * niveauHéros] * multiplier % )";
                tempStr += "\n\n";
                tempStr += "<u>Membres</u>";
                tempStr += "\n- Ici, vous pouvez voir que ce font les différents membres de la guilde.";
                tempStr += "\n- Vous pouvez activer jusqu'à 3 héros au début du jeu. Seul un héros peut être actif, qui est votre héros couremment en jeu. Les autres héros actifs sont en mode Passif. Ils continuent de faire tout comme s'ils sont actifs, mais avec un taux de gains réduit. ";
                tempStr += "\n- Vous pouvez déplacer votre souris sur le bouton Passif/Actif/Inactif pour déterminer le % d'Efficacité en Arrière-Plan. Cette valeur peut être améliorée en complétant les quêtes de titres pour les titres PReuve de Réincarnation 1/2/3/4/5/6, que vous débloquerez après avoir atteint le Niveau de Héros 100.";
                tempStr += "\n- Vous pouvez déplacer votre souris sur chaque héros pour voir où ils sont ainsi que leur gains d'EXP dans la dernière minute.";
                tempStr += "\n\n";
                tempStr += "<u>Abilité de Guilde</u>";
                tempStr += "\n- A chaque fois que la guilde monte de niveau, vous recevrez un point d'abilité qui vous permet d'améliorer la guilde.";
                tempStr += "\n- Déplacez votre souris sur chaque amélioration débloquée pour voir ce qu'elles font pour toute votre guilde. ";
                tempStr += "\n- Vous pouvez débloquer plus d'Abilités de Guilde à travers différentes classes d'Ascension Monde. ";
                break;
            case HelpKind.Town:
                tempStr += "La Ville a 12 bâtiments différents que vous pouvez monter de rang et de niveau. Beaucoup d'améliorations et de contenu sont débloqués à travers la Ville. ";
                tempStr += "\n\n";
                tempStr += "<u>Matériaux de Ville</u>";
                tempStr += "\n- Il existe 5 classes de Matériaux de Ville. Vous récupérez des matériaux de ville en complétant uen Zone dans n'importe quelle Région.";
                tempStr += "\n- Chaque classe de matériaux est partagée dans 2 régions chacunes. en commençant avec la Classe 1 dans le Ville des Slimes et la Cité des Slimes Magiques. ";
                tempStr += "\n- Vous avez besoin de ces Matériaux de Ville pour monter le niveau de chaque bâtiment de la ville. ";
                tempStr += "\n\n";
                tempStr += "<u>Bâtiments de Ville</u>";
                tempStr += "\n- Les Bâtiments de Ville sont débloqués en atteignant le Niveau de Guilde associé.";
                tempStr += "\n- Pour commencer à augmenter le niveau des bâtiments, il faut tout d'abord qu'ils atteignent le Rang 1. Déplacez votre souris sur le bouton Rang + pour voir les requis pour augmenter le rang de chaque bâtiment de ville.";
                tempStr += "\n- Une fois qu'il a atteint le rang 1, vous pouvez augmenter son niveau jusqu'au niveua 20 avant de devoir augmenter le rang du bâtiment de nouveau.";
                tempStr += "\n- Chaque bâtiment a un Effet, des Effets Recherchables, ainsi que des Paliers de Rang et de Niveau.";
                tempStr += "\n\n";
                tempStr += "<u>Effet de Ville</u>";
                tempStr += "\n- L'Effet de Ville est un bonus gagné à chaque fois que le bâtiment monte de niveau. ";
                tempStr += "\n\n";
                tempStr += "<u>Recherche de Ville</u>";
                tempStr += "\n- Chaque bâtiment a 3 Recherches différentes à choisir, basées sur les 3 types de ressources principales.";
                tempStr += "\n- Au début du jeu, seule une recherche peut être choisie à la fois pour toute la ville.";
                tempStr += "\n- Le bâtiment doit au moins être au Niveau 1 avant de pouvoir cliquer sur l'un de ses icônes de Ressource, ce qui commence la recherche associée.";
                tempStr += "\n- Pour augmenter la Vitesse de Recherche, vous devez pugmenter le nombre de Ressources en votre possession.";
                tempStr += "\n- Puissance de Recherche (EXP/sec) MATH: Log10([Montant de la Ressource Courant])";
                tempStr += "\n\n";
                tempStr += "<u>Paliers de Rang de Ville</u>";
                tempStr += "\n- Chaque palier de Rang de ville débloque de contenu additionnel basé sur le bâtiment lui-même.";
                tempStr += "\n- Déplacez votre souris sur le bouton Rang + pour voir les requis pour augmenter le rang du bâtiment. ";
                tempStr += "\n- Monter le rang du bâtiment augmentera aussi le coût de montée de niveau du bâtiment.";
                tempStr += "\n\n";
                tempStr += "<u>Paliers de Niveau de Ville</u>";
                tempStr += "\n- Chaque bâtiment comprend aussi des paliers de niveau qui améliorent des facettes autout de la fonctionnalité principale du bâtimet de ville. Monter le niveau du bâtiment coûte des ressources.";
                tempStr += "\n- La première colonne de bâtiments nécessite des Briques, la deuxième colonne nécessite des Buches, et la dernière colonne nécessite des Eclats pour monter de niveau. ";
                tempStr += "\n\n";
                break;
            case HelpKind.Bestiary:
                tempStr += "Le Bestiaire est là où vous pourrez voir tous les monstres rencontrés jusqu'à présent. Vous pourrez aussi voir combien de monstres d'un certain type vous avez tués ou capturés. ";
                tempStr += "\n\n";
                tempStr += "C'est aussi un bon moyen de voir ce que chaque monstre lâche ainsi que leur taux d'apparition.  ";
                tempStr += "\n\n";
                tempStr += "Il est aussi possible de voir l'Effet Actif de chaque monstre. Pour l'activer, le monstre doit au moins être au Rang de Familier 1, qui peut être atteint en capturant le monstre avec le bon piège.";
                tempStr += "\n\n";
                tempStr += "L'effet Passif du Familier demande aussi à ce que le Familier atteigne le Rang 1 au minimum. Chaque rang supplémentaire augmente l'effet passif.";
                tempStr += "\n\n";
                tempStr += "Déplacer la souris sur le Rang du Familier montrera une infobulle qui décrit les détails de Gains de Dressage. Augmenter le nombre de morts de ce type de montre augmente la partie Vaincu du calcul.";
                tempStr += "\n\n";
                tempStr += "La montée de niveau d'un Familier s'effectue à travers la Dompteuse, qui invoque des familiers pour se battre à sa place. Envoyer des familiers dans une Expédition Lointaine peut aussi augmenter leur niveau. Référez-vous à la page d'aide sur les Expéditions pour plus d'infos.";
                tempStr += "\n\n";
                tempStr += "Les statistiques des familiers peuvent être augmentés en augmentant le niveau des familiers ainsi qu'à travers les multiplicateurs des statistiques des héros depuis n'importe quelle source, y compris: Les capacités de buffs, les capacités passives du héros, les effets des équipements, les enchantements des équipements, les potions et les bénédictions. Par exemple, avoir un bonus de % de PV augmentera la Statistique de PV du familier invoqué pour ce héros par le même montant.";
                break;
            case HelpKind.Shop:
                tempStr += "Tout ce qui est dans l'Onglet Magasin est réapprovisionné en même temps toutes les 10 minutes. ";
                tempStr += "\n\n";
                tempStr += "<u>Onglet Matériau</u>";
                tempStr += "\n- Vous pouvez acheter des Matériaux lâchés par des Monstres ici. Vous pouvez aussi les vendre contre de l'or.";
                tempStr += "\n- Certains familiers permettent d'automatiquement acheter les matériaux lorsqu'ils sont activés. ";
                tempStr += "\n- Vous pouvez augmenter le nombre de matériaux réapprovisionnés en même temps à travers une Recherche de ville sous le Bâtiment de Ville Banque Slime.";
                tempStr += "\n\n";
                tempStr += "<u>Onglet Piège</u>";
                tempStr += "\n- L'onglet piège permet d'acheter des pièges pour capturer des monstres. [Aide > Capture]";
                tempStr += "\n- Pour avoir accès à de nouveaux pièges, vous devez augmenter le rang du Bâtiment de Ville [Trappeur]. ";
                tempStr += "\n- Vous pouvez aussi augmenter le nombre de pièges réapprovisionnés en même temps à travers la Recherche de ville sous le Bâtiment de Ville Trappeur.";
                tempStr += "\n\n";
                tempStr += "<u>Onglet Bénédiction</u>";
                tempStr += "\n- Vous pouvez acheter des bénédictions ici. Ces bénédictions peuvent augmenter certaines statistiques par 150% (base) pendant 3 minutes (base).";
                tempStr += "\n- vous pouvez augmenter le nombre de bénédictions par réapprovisionnement à travers le Bâtiment de Ville [Temple] en atteignant certains paliers de niveau.";
                tempStr += "\n- Vous pouvez augmenter l'effet des bénédictions à travers une Recherche de ville sous le Bâtiment de Ville Temple.";
                tempStr += "\n- Vous pouvez aussi augmenter la durée des bénédictions à travers une Recherche de ville sous le Bâtiment de Ville Temple. ";
                tempStr += "\n- Vous pouvez acheter 1 Bénédiction par répprovisionnement par défaut.";
                tempStr += "\n\n";
                tempStr += "<u>Onglet de Matériau de Ville</u>";
                tempStr += "\n- Débloqué à travers le Bâtiment de Ville [Chercheur Arcanique]. ";
                tempStr += "\n- Vous pouvez transformer des matériaux de ville en matériaux de ville de classe supérieure ici. ";
                tempStr += "\n- Le ratio de base est 10:1. Ce ratio peut être amélioré à travers les Paliers de Niveau du Bâtiment de Ville Chercheur Arcanique. ";
                tempStr += "\n\n";
                break;
            case HelpKind.Rebirth:
                tempStr += "La réincarnation est comme une mini-réinitialisation seulement appliquée au héros courant. Il vous sera possible d'augmenter le pouvoir à travers des améliorations. Chaque classe de Réincarnation réinitialisera des choses différentes, et des améliorations seront disponibles sur à peu près ce qui a été réinitialisé.";
                tempStr += "\n\n";
                tempStr += "<u>Classe 1</u>";
                tempStr += "\n- Vous devez atteindre le niveau 100 sur le héros courant pour être éligible à la Réincarnation de Classe 1. Référez-vous à l'Onglet Réincarnation pour voir ce qui est réinitialisé et quelles améliorations sont disponibles.";
                tempStr += "\n- Vous gagnez des Points de Réincarnation basé sur le Niveau du Héros au lancement de la Réincarnation, à travers la complétion de différentes Quêtes Générales, et sur la distance parcourue depuis la dernière réincarnation.";
                tempStr += "\n- Bonus : Vous gagnez des Points d'Abilité supplémentaires basés sur le niveau du héros maximal atteint lors d'une Réincarnation de Classe 1, jusqu'au niveau 200 moins 100. Par exemple, si vous effectuez une réincarnation au Niveau 150, vous gagnerez 50 Points d'Abilité supplémentaires après la réincarnation.";
                tempStr += "\n\n";
                tempStr += "<u>Classe 2</u>";
                tempStr += "\n- Vous devez atteindre le niveau 200 sur le héros courant pour être éligible à la Réincarnation de Classe 2. Le Bâtiment de Ville [Temple] doit être à un Rang minimum pour effectuer une Réincarnation de Classe 2. ";
                tempStr += "\n- Vous gagnez des Points de Réincarnation basés sur le niveau des Capacités du Héros, sur le Niveau du Héros à partir du niveau 200, à travers la complétion de différentes Quêtes Générales, et sur la distance parcourue depuis la dernière réincarnation.";
                tempStr += "\n- Bonus : Vous gagnez des Points d'Abilité supplémentaires basés sur le niveau du héros maximal atteint lors d'une Réincarnation de Classe 2, jusqu'au niveau 300 moins 200 tous les 25 niveaux. Par exemple, si vous effectuez une réincarnation au Niveau 250, vous gagnerez alors 50 PA au niveau 25, 50, 75, etc. vous augmenterez aussi le Bonus de Réincarnation de Classe 1 (AP bonus) par un certain %. La formule est +10 x [# Réincarnation de Classe 2]^(2/3) %";
                tempStr += "\n\n";
                tempStr += "<u>Classe 3</u>";
                tempStr += "\n- Vous devez atteindre le niveau 300 sur le héros courant pour être éligible à la Réincarnation de Classe 3. Le Bâtiment de Ville [Temple] doit être à un Rang minimum pour effectuer une Réincarnation de Classe 3. ";
                tempStr += "\n- Vous gagnez des Points de Réincarnation basés sur le niveau des Equipements du Héros, sur le Niveau des Capacités du Héros à partir de 100, sur le Niveau du Héros à partir du niveau 300, à travers la complétion de différentes Quêtes Générales, et sur la distance parcourue depuis la dernière réincarnation.";
                tempStr += "\n- Bonus : Vous gagnez des niveaux pour la Capacité d'Attaque de Base basés sur le niveau du héros maximal atteint lors d'une Réincarnation de Classe 3, jusqu'au niveau 500 moins 300. Par exemple, si vous effectuez une réincarnation au Niveau 350, vous gagnerez 50 Nv pour la Capacité d'Attaque de Base pour ce héros. Vous augmenterez aussi le bonus de Réincarnation de Classe 2 (AP supplémentaire tous les 25 niveaux, et les AP de Classe 1) par un certain %. La formule est +10 x [# Réincarnation de Classe 3]^(2/3) %";
                tempStr += "\n\n";
                break;
            case HelpKind.Challenge:
                tempStr += "Challenges are where you can test your might of your team, or solo hero against tough boss monsters. ";
                tempStr += "\nThese Challenges will only reward you one competition per World Ascension.  You can still enter the challenge fight at any point, but you won’t be rewarded if you’ve already claimed the reward that World Ascension.";
                tempStr += "\n\n";
                tempStr += "<u>Raid Boss Battles</u>";
                tempStr += "\n- Raid Boss battles will use your entire team that are in the Active/Passive mode.";
                tempStr += "\n- Inactive heroes will not be joining you in this fight. ";
                tempStr += "\n\n";
                tempStr += "<u>Solo Boss Battles</u>";
                tempStr += "\n- Solo Boss battles will only use your Active hero.";
                tempStr += "\n- All skills/Global skills are available to be used during this fight.";
                tempStr += "\n- You must first beat the Raid Boss to unlock the Solo Boss.";
                tempStr += "\n\n";
                tempStr += "<u>Handicapped Battles</u>";
                tempStr += "\n- These battles have limitations to the fight. Such as no Global skills, no equipment, or a select number of skill slots.";
                tempStr += "\n- You must first beat the Solo Boss Battles to unlock the Handicap Boss battles.";
                tempStr += "\n\n";
                tempStr += "The Town building [Mystic Arena] is associated with these Challenges. You can unlock new floors and boss levels through this town building. ";
                break;
            case HelpKind.Expedition:
                tempStr += "Expeditions are where you can send your pets (achieved by getting the pets to rank 1 through capturing them) out on different types of adventures.";
                tempStr += "\n\n";
                tempStr += "To start an expedition, click on an open pet slot on a team. (Click the grey + button under Team) Select the pet you would like to send. (Be mindful that this pet can not be used again, until you end the Expedition). Select which Expedition you would like to send the Team on, by the dropdown menu. You can then adjust the length of the Expedition. Longer the expedition, the more gold it will cost to send. Once everything is set, click Start and wait the length of the time. Click Claim to receive the rewards.";
                tempStr += "\n\n";
                tempStr += "Each pet species will have different rewards regarding the Expeditions you send them on. You can increase the rewards by changing the length of Expeditions, increasing the Team Rank, and the Type of Expedition level. As you send the pets on expeditions, they will also gain Pet levels and meters walked which will count towards your total meters walked for World Ascension.";
                tempStr += "\n\n";
                tempStr += "You first start out with 3 different Distant Expeditions. Manufacturing Bricks, Logging Trees, and Gathering Shards. The rewards that you can receive are the Town materials, Bricks, Logs, and Shards.";
                tempStr += "\n\n";
                tempStr += "Leveling up the expeditions will increase your total expeditions levels, which can unlock new expeditions and increase their passives.";
                tempStr += "\n\n";
                tempStr += "There is a town building [Adventuring Party] that helps Expeditions, such as unlocking new Teams, pet slots, and Town Research for Expeditions.";
                break;
            case HelpKind.WorldAscension:
                tempStr += "World Ascension is where the entire world resets, and you start back over. This time, even stronger than the previous world. ";
                tempStr += "\n\n";
                tempStr += "The full list of what is reset, and what isn’t reset is in the Ascension tab, at the top left (I) icon. There you can see all of what will be reset, kept, and words of caution. In the Top Right, you can change the Tiers of World Ascension when they are unlocked. There is only currently Tier 1 in game.";
                tempStr += "\n\n\n";
                tempStr += "<u>World Ascension Tier 1</u>";
                tempStr += "\n";
                tempStr += "You have 8 different milestones that you can advance. You will need to reach a certain number of Milestones to be able to ascend the world. The first time you ascend the requirement will be 5 total Milestone levels. This cost will increase by 1, every time you World Ascend. ";
                tempStr += "\n\n";
                tempStr += "The 8 Milestones are";
                tempStr += "\n- Raise the Town – This is directly tied to the total # of levels of your town buildings.";
                tempStr += "\n- Very Resourceful - Tied to the total # of levels of your General 1 tab, the Resource Gain upgrades.";
                tempStr += "\n- Polished Equipper - This focuses on the amount of dictionary points you’ve gained.";
                tempStr += "\n- Rebirther 1 – Total number of Rebirth Tier 1 Points that all heroes have gained this World Ascension. ";
                tempStr += "\n- Map Milestoner – Total number of Area Mission Milestones that were achieved this World Ascension.";
                tempStr += "\n- Walk the World – How far your heroes and pets have walked this Ascension.";
                tempStr += "\n- Pro Disassembler – Total number of Town Materials gained by Disassembling them.";
                tempStr += "\n- Rebirther 2 - Total number of Rebirth Tier 2 points that all of the heroes have gained this World Ascension.";
                tempStr += "\n\n";
                tempStr += "With the Milestones, each level you earn will award you with World Ascension Points. Not to be confused with the Milestone levels. Hover over each Milestone to see the amount of World Ascension points they will give, and how close you are to achieving the next level of that milestone. ";
                tempStr += "\n\n\n";
                tempStr += "Accomplishments are like tasks that you can complete for extra World Ascension points. These are timed, that starts at the beginning of that World Ascension. You can see your total time played in the Ascension tab, use this as a clock for accomplishments.";
                tempStr += "\n\n";
                tempStr += "For each accomplishment you clear, you'll gain 1 total clear count, you'll also be awarded extra World Ascension points. There are rewards for achieving high clears in Accomplishments. Such as at 5 Accomplishments completed, you will be able to carry all uniques regardless of Enchantments/Enchant Slots through World Ascending. ";
                tempStr += "\n\n";
                tempStr += "The World Ascension Points awarded for completing accomplishments are awarded straight away to be used. ";
                tempStr += "\n\n\n";
                tempStr += "World Ascension Upgrades ";
                tempStr += "\n- Guild Exp Booster – This Multiplies your Guild EXP % for heroes.";
                tempStr += "\n- Active Hero Slot Expansion – Allows you to have 1 extra passive hero working in the background.";
                tempStr += "\n- Pre Rebirther 1 – This One-time(per WA) upgrade gives you Rebirth Tier 1 Points to spend.";
                tempStr += "\n- Rebirth Tier 1 Bonus Expansion – This expands the[Max Hero Level Reached] for Rebirth Tier 1 Additional Ability Points.";
                tempStr += "\n- WA Milestone Point Efficiency – Increases the Points you gain each time you level a Milestone.";
                tempStr += "\n- Area Booster – Increases the Clear Count and Reward per Clear from Areas per upgrade.";
                tempStr += "\n- Skill Proficiency Boost – Multiplies your skill proficiency gain % for heroes.";
                tempStr += "\n- Pre - Rebirther Tier 2 – This One - Time(per - wa) upgrade gives you Rebirth Tier 2 points to spend, when you have the required Temple Building Rank.";
                tempStr += "\n- Rebirth Tier 2 Bonus Expansion – This expands the[Max Hero Level Reached] for Rebirth Tier 2 , Ability Point every 25th Hero Level. ";
                break;
            case HelpKind.EpicStore:
                tempStr += "The Epic Store is where you can purchase some premium upgrades/unlocks such as more Equipment slots, upgrades to Auto Rebirthing, Super Queues in Upgrades and Alchemy. To purchase these upgrades you need to gain <color=orange>Epic Coins (EC)</color>.";
                tempStr += "\nThere are multiple ways to gain Epic Coins. <color=orange>Epic Coin Daily Quests</color>, <color=orange>Area Mission Completions</color>, <color=orange>Achievements</color>, and with Real life Money.";
                tempStr += "\n\n";
                tempStr += "You currently can have up to 4 Daily EC quests each day. They reset at your local computer time of Midnight. You start with 1 EC daily quest, 1 from the Statue of Heroes town building level 25 Milestone, and the last 2 EC quests are from the Epic store.";
                tempStr += "\n\n";
                tempStr += "Completing Missions for each Area will also give Epic Coins. You only get Epic Coins on once per mission, per save. Each Area difficulty increases the EC Reward. Each Area has 10 total difficulties, and a max of 5 missions each. 50 Total Missions that can give a one-time reward of EC, per Area. There are 8 Areas per Region, and 10 Regions in the game.";
                tempStr += "\n\n";
                tempStr += "There are achievements within the game, that will reward Epic Coins. Feel free to look at which ones do by going to Help > Achievements.";
                tempStr += "\n\n";
                tempStr += "Lastly, you can purchase Epic Coins directly from the Epic Store using real life money.";
                tempStr += "\n\n";
                tempStr += "Within the game currently, it is possible to gain <color=orange>over 250,000 Epic Coins</color> just by completing Missions and the Achievements.";
                break;
            case HelpKind.S_General:
                tempStr += GeneralString();
                break;
            case HelpKind.S_GuildLevel:
                tempStr += GuildLevelString();
                break;
            case HelpKind.S_Town:
                tempStr += TownString();
                break;
            case HelpKind.S_Rebirth:
                tempStr += RebirthString();
                break;
            case HelpKind.S_Challenge:
                tempStr += ChallengeString();
                break;
            case HelpKind.S_WorldAscension:
                tempStr += WorldAscensionString();
                break;
            case HelpKind.A_All: return AchievementString(kind);
            case HelpKind.A_General: return AchievementString(kind);
            case HelpKind.A_Area: return AchievementString(kind);
            case HelpKind.A_Currency: return AchievementString(kind);
            case HelpKind.A_Guild: return AchievementString(kind);
            case HelpKind.A_Challenge: return AchievementString(kind);
            case HelpKind.A_Alchemy: return AchievementString(kind);
            case HelpKind.A_Equip: return AchievementString(kind);
            case HelpKind.A_Skill: return AchievementString(kind);
            case HelpKind.A_Rebirth: return AchievementString(kind);
            case HelpKind.A_Playtime: return AchievementString(kind);
        }
        return tempStr;
    }
    public override string GeneralString()
    {
        string tempStr = optStr;
        double tempValue;
        tempStr += "<size=20><u>Playtime</u><size=18>";
        for (int i = 0; i < Enum.GetNames(typeof(HeroKind)).Length; i++)
        {
            int count = i;
            if (main.S.playtimes[count] > 0)
            {
                tempStr += "\n" + Hero((HeroKind)count);
                tempStr += "\n- In-Game Playtime : " + DoubleTimeToDate(main.S.playtimes[count]);
                if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                    tempStr += "  ( This World Ascension : " + DoubleTimeToDate(main.SR.playtimes[count]) + " )";
                tempStr += "\n- Real-time Active Playtime : " + DoubleTimeToDate(main.S.playtimesRealTime[count]);
                if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                    tempStr += "  ( This World Ascension : " + DoubleTimeToDate(main.SR.playtimesRealTime[count]) + " )";
            }
        }
        tempStr += "\nTotal";
        tempStr += "\n- In-Game Playtime : " + DoubleTimeToDate(main.allTime);
        tempStr += "\n- Real-time Active Played : " + DoubleTimeToDate(main.allTimeRealtime);
        tempStr += "\n\n";
        tempStr += "<size=20><u>Total Currency Gained</u><size=18>";
        tempStr += "\n- Gold : " + tDigit(main.S.totalGold);
        tempStr += "\n- Stone : " + tDigit(main.S.totalStone);
        tempStr += "\n- Crystal : " + tDigit(main.S.totalCrystal);
        tempStr += "\n- Leaf : " + tDigit(main.S.totalLeaf);
        tempStr += "\n- Slime Coin : " + tDigit(main.S.totalSlimeCoin);
        tempStr += "\n\n";
        tempStr += "<size=20><u>Max Hero Level Reached</u><size=18>";
        for (int i = 0; i < Enum.GetNames(typeof(HeroKind)).Length; i++)
        {
            int count = i;
            tempStr += "\n- " + localized.Hero((HeroKind)count) + " : Lv " + tDigit(main.S.maxHeroLevelReached[count]);
        }
        tempStr += "\n\n";
        tempStr += "<size=20><u>Total Walked Distance</u><size=18>";
        for (int i = 0; i < Enum.GetNames(typeof(HeroKind)).Length; i++)
        {
            int count = i;
            tempStr += "\n- " + localized.Hero((HeroKind)count) + " : " + meter(main.S.movedDistance[count]) + " | This Ascension " + meter(main.S.totalMovedDistance[count]) + " | This Rebirth " + meter(main.SR.movedDistance[count]);
        }
        tempStr += "\n- Pet : " + meter(main.S.movedDistancePet) + " | This Ascension " + meter(main.S.totalMovedDistancePet);// + " | This Rebirth " + meter(main.SR.movedDistancePet);
        tempStr += "\nTotal : " + meter(game.statsCtrl.TotalMovedDistance(false)) + " | This Ascension " + meter(game.statsCtrl.TotalMovedDistance(true));
        tempStr += "\n\n";
        tempStr += "<size=20><u>Swarm</u><size=18>";
        tempStr += "\n- Total Swarms Vanquished : " + tDigit(main.S.swarmClearedNum);
        tempStr += "\n- Best Swarm Score (Regular) : " + tDigit(main.S.swarmBestScores[0]);
        tempStr += "\n- Best Swarm Score (Large) : " + tDigit(main.S.swarmBestScores[1]);
        tempStr += "\n- Best Swarm Score (Epic) : " + tDigit(main.S.swarmBestScores[2]);
        tempStr += "\n\n";
        tempStr += "<size=20><u>Others</u><size=18>";
        tempStr += "\n- Total Treasure Chest Opened # : " + tDigit(main.S.openedChestNum);
        tempStr += "\n- Total Equipment Gained : " + tDigit(main.S.totalEquipmentGained);
        tempValue = 0;
        for (int i = 0; i < main.S.disassembledEquipmentNums.Length; i++)
        {
            tempValue += main.S.disassembledEquipmentNums[i];
        }
        tempStr += "\n- Total Equipment Disassembled : " + tDigit(tempValue);
        tempStr += "\n- Total Alchemy Point Gained : " + tDigit(main.S.totalAlchemyPointGained);
        tempStr += "\n- Total Captured Monsters # : " + tDigit(game.monsterCtrl.CapturedNum());
        tempStr += "\n\n";
        return tempStr;
    }
    public override string GuildLevelString()
    {
        string tempStr = optStr;
        tempStr += "Max Guild Level Reached : Lv " + tDigit(main.S.maxGuildLevel);
        tempStr += "\n\n";
        tempStr += "<size=20><u>Accomplished Playtime of Guild Level</u><size=18>";
        for (int i = 0; i < game.guildCtrl.accomplishGuildLevels.Length; i++)
        {
            if (game.guildCtrl.accomplishGuildLevels[i].accomplishedBestTime > 0)
            {
                tempStr += "\n- Lv " + tDigit(i) + " : ";
                if (game.guildCtrl.accomplishGuildLevels[i].accomplishedTime > 0)
                    tempStr += DoubleTimeToDate(game.guildCtrl.accomplishGuildLevels[i].accomplishedTime);
                if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                {
                    tempStr += " | Best : " + DoubleTimeToDate(game.guildCtrl.accomplishGuildLevels[i].accomplishedBestTime);
                    tempStr += " | First : " + DoubleTimeToDate(game.guildCtrl.accomplishGuildLevels[i].accomplishedFirstTime);
                }
            }
        }
        return tempStr;
    }
    public override string TownString()
    {
        string tempStr = optStr;
        tempStr += "<size=20><u>Town Material Gain Breakdowns</u><size=18>";
        tempStr += optStr + "\n" + game.townCtrl.townMaterialGainMultiplier[(int)game.currentHero].BreakdownString(true);
        tempStr += "\n\n";
        tempStr += "<size=20><u>Town Material Gain from Disassembling Equipment Breakdowns</u><size=18>";
        tempStr += optStr + "\n" + game.equipmentCtrl.disassembleMultiplier.BreakdownString(true);
        tempStr += "\n\n";
        tempStr += optStr + "<size=20><u>Accomplished Playtime of Building Rank</u><size=18>";
        for (int i = 0; i < game.townCtrl.buildings.Length; i++)
        {
            BUILDING building = game.townCtrl.buildings[i];
            if (building.accomplish[0].accomplishedBestTime > 0)
            {
                tempStr += "\n" + building.NameString();
                for (int j = 0; j < building.accomplish.Length; j++)
                {
                    int countJ = j;
                    if (building.accomplish[countJ].accomplishedBestTime > 0)
                    {
                        tempStr += "\n- Rank " + tDigit(j + 1) + " : ";
                        if (building.accomplish[countJ].accomplishedTime > 0)
                            tempStr += DoubleTimeToDate(building.accomplish[countJ].accomplishedTime);
                        if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                        {
                            tempStr += " | Best : " + DoubleTimeToDate(building.accomplish[countJ].accomplishedBestTime);
                            tempStr += " | First : " + DoubleTimeToDate(building.accomplish[countJ].accomplishedFirstTime);
                        }
                    }

                }
            }
        }
        return tempStr;
    }
    public override string ChallengeString()
    {
        string tempStr;
        tempStr = optStr + "<size=20><u>Accomplished Playtime of Challenge</u><size=18>";
        for (int i = 0; i < game.challengeCtrl.challengeList.Count; i++)
        {
            CHALLENGE challenge = game.challengeCtrl.challengeList[i];
            if (challenge.accomplish.accomplishedBestTime > 0)
            {
                tempStr += "\n- " + challenge.TitleUIString() + " : ";
                tempStr += DoubleTimeToDate(challenge.accomplish.accomplishedTime);
                if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                {
                    tempStr += " | Best : " + DoubleTimeToDate(challenge.accomplish.accomplishedBestTime);
                    tempStr += " | First : " + DoubleTimeToDate(challenge.accomplish.accomplishedFirstTime);
                }
            }
        }
        return tempStr;
    }
    public override string RebirthString()
    {
        string tempStr;
        tempStr = optStr + "<size=20><u>Total Rebirth #</u><size=18>";
        for (int i = 0; i < Enum.GetNames(typeof(HeroKind)).Length; i++)
        {
            int count = i;
            if (game.rebirthCtrl.Rebirth((HeroKind)count, 0).totalRebirthNum > 0)
            {
                tempStr += "\n" + localized.Hero((HeroKind)count);
                for (int j = 0; j < game.rebirthCtrl.rebirth[count].Length; j++)
                {
                    int countJ = j;
                    Rebirth rebirth = game.rebirthCtrl.Rebirth((HeroKind)count, countJ);
                    if (rebirth.totalRebirthNum > 0)
                    {
                        tempStr += "\n- Tier " + tDigit(countJ + 1) + " : " + tDigit(rebirth.rebirthNum);
                        if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                        {
                            tempStr += " | Total : " + tDigit(rebirth.totalRebirthNum);
                        }
                    }
                }
            }
        }
        tempStr += "\n\n";
        tempStr += optStr + "<size=20><u>Best Rebirth Time</u><size=18>";
        for (int i = 0; i < Enum.GetNames(typeof(HeroKind)).Length; i++)
        {
            int count = i;
            if (game.rebirthCtrl.Rebirth((HeroKind)count, 0).totalRebirthNum > 0)
            {
                tempStr += "\n" + localized.Hero((HeroKind)count);
                for (int j = 0; j < game.rebirthCtrl.rebirth[count].Length; j++)
                {
                    int countJ = j;
                    Rebirth rebirth = game.rebirthCtrl.Rebirth((HeroKind)count, countJ);
                    if (rebirth.totalRebirthNum > 0)
                        tempStr += "\n- Tier " + tDigit(countJ + 1) + " : " + DoubleTimeToDate(rebirth.bestRebirthPlayTime);
                }
            }
        }
        tempStr += "\n\n";
        tempStr += "<size=20><u>Accomplished Playtime of Rebirth</u><size=18>";
        for (int i = 0; i < Enum.GetNames(typeof(HeroKind)).Length; i++)
        {
            int count = i;
            Rebirth rebirth = game.rebirthCtrl.Rebirth((HeroKind)count, 0);
            if (rebirth.accomplish.accomplishedBestTime > 0)
            {
                tempStr += "\n" + localized.Hero((HeroKind)count);
                for (int j = 0; j < game.rebirthCtrl.rebirth[count].Length; j++)
                {
                    int countJ = j;
                    rebirth = game.rebirthCtrl.Rebirth((HeroKind)count, countJ);
                    if (rebirth.totalRebirthNum > 0)
                    {
                        tempStr += "\n- Tier " + tDigit(countJ + 1) + " : ";
                        if (rebirth.accomplish.accomplishedTime > 0)
                            tempStr += DoubleTimeToDate(rebirth.accomplish.accomplishedTime);
                        if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                        {
                            tempStr += " | Best : " + DoubleTimeToDate(rebirth.accomplish.accomplishedBestTime);
                            tempStr += " | First : " + DoubleTimeToDate(rebirth.accomplish.accomplishedFirstTime);
                        }
                    }
                }
            }
        }
        return tempStr;
    }

    public override string WorldAscensionString()
    {
        string tempStr;
        tempStr = optStr + "<size=20><u>Accomplished Playtime of World Ascension</u><size=18>";
        tempStr += "\n- Tier 1 : " + DoubleTimeToDate(game.ascensionCtrl.worldAscensions[0].accomplish.accomplishedTime);
        return tempStr;
    }
    public override string AchievementString(HelpKind helpKind)
    {
        StringBuilder tempStringBuilder = new StringBuilder(4096);
        tempStringBuilder.Clear();
        tempStringBuilder.Append(optStr + "<size=20>TOTAL CLEARED # <color=green>" + tDigit(game.achievementCtrl.TotalClearNum()) + "</color> / " + tDigit(game.achievementCtrl.achievementList.Count));
        tempStringBuilder.Append(optStr + "\nTotal Clear Bonus : Gold Gain <color=green>+ " + percent(game.achievementCtrl.GoldGainBonus(), 0) + "</color> ( + 1% / clear )");
        tempStringBuilder.Append("\n\n<u>Achievements</u><size=18>");
        switch (helpKind)
        {
            case HelpKind.A_All:
                for (int i = 0; i < game.achievementCtrl.achievementList.Count; i++)
                {
                    tempStringBuilder.Append(optStr + "\n" + game.achievementCtrl.achievementList[i].NameString());
                }
                break;
            case HelpKind.A_General:
                for (int i = 0; i < game.achievementCtrl.achievementListGeneral.Count; i++)
                {
                    tempStringBuilder.Append(optStr + "\n" + game.achievementCtrl.achievementListGeneral[i].NameString());
                }
                break;
            case HelpKind.A_Area:
                for (int i = 0; i < game.achievementCtrl.achievementListArea.Count; i++)
                {
                    tempStringBuilder.Append("\n");
                    tempStringBuilder.Append(game.achievementCtrl.achievementListArea[i].NameString());
                }
                break;
            case HelpKind.A_Currency:
                for (int i = 0; i < game.achievementCtrl.achievementListCurrency.Count; i++)
                {
                    tempStringBuilder.Append("\n");
                    tempStringBuilder.Append(game.achievementCtrl.achievementListCurrency[i].NameString());
                }
                break;
            case HelpKind.A_Guild:
                for (int i = 0; i < game.achievementCtrl.achievementListGuild.Count; i++)
                {
                    tempStringBuilder.Append("\n");
                    tempStringBuilder.Append(game.achievementCtrl.achievementListGuild[i].NameString());
                }
                break;
            case HelpKind.A_Challenge:
                for (int i = 0; i < game.achievementCtrl.achievementListChallenge.Count; i++)
                {
                    tempStringBuilder.Append("\n");
                    tempStringBuilder.Append(game.achievementCtrl.achievementListChallenge[i].NameString());
                }
                break;
            case HelpKind.A_Alchemy:
                for (int i = 0; i < game.achievementCtrl.achievementListAlchemy.Count; i++)
                {
                    tempStringBuilder.Append("\n");
                    tempStringBuilder.Append(game.achievementCtrl.achievementListAlchemy[i].NameString());
                }
                break;
            case HelpKind.A_Equip:
                for (int i = 0; i < game.achievementCtrl.achievementListEquip.Count; i++)
                {
                    tempStringBuilder.Append("\n");
                    tempStringBuilder.Append(game.achievementCtrl.achievementListEquip[i].NameString());
                }
                break;
            case HelpKind.A_Skill:
                for (int i = 0; i < game.achievementCtrl.achievementListSkill.Count; i++)
                {
                    tempStringBuilder.Append("\n");
                    tempStringBuilder.Append(game.achievementCtrl.achievementListSkill[i].NameString());
                }
                break;
            case HelpKind.A_Rebirth:
                for (int i = 0; i < game.achievementCtrl.achievementListRebirth.Count; i++)
                {
                    tempStringBuilder.Append("\n");
                    tempStringBuilder.Append(game.achievementCtrl.achievementListRebirth[i].NameString());
                }
                break;
            case HelpKind.A_Playtime:
                for (int i = 0; i < game.achievementCtrl.achievementListPlaytime.Count; i++)
                {
                    tempStringBuilder.Append("\n");
                    tempStringBuilder.Append(game.achievementCtrl.achievementListPlaytime[i].NameString());
                }
                break;
        }
        return tempStringBuilder.ToString();
    }
    public override string QuestMenuString(int id, string text = "", string text2 = "")
    {
        switch (id)
        {
            case 0: return "Click to go to ";
            case 1: return "You need " + text + " Portal Orb to enter this area(You have " + text2 + ")";
            case 2: return "Go to see Titles that you acquired.";
            case 3: return "Remove the Favorite";
            case 4: return "Assign the Favorite";
            case 5: return " [Favorite Quest] in Epic Store";
            case 6:
                return "Title Quests and General Quests are limited to number of Accepted Quests." +
"\nYou can increase the limit through a Rebirth upgrade.";
            case 7: return "Walk";
            case 8: return "Physical Attack #";
            case 9: return "Fire Attack #";
            case 10: return "Ice Attack #";
            case 11: return "Thunder Attack #";
            case 12: return "Light Attack #";
            case 13: return "Dark Attack #";
            case 14: return "General Quest Cleared #";
            case 15: return "Defeat any " + text + " ";
            case 16: return "Defeat " + text + " ";
            case 17: return "Capture any " + text + " ";
            case 18: return "Capture " + text + " ";
            case 19: return "Clear #";
            case 20: return "Guild EXP";
            case 21: return "(Make sure you have enough slots before claim)";
            case 22: return "Last Reset Time";
            case 23: return "Next Reset Time";
            case 24: return "This quest won't reset while active";
            case 25: return "Quest Mastery";
            case 26: return "Current Rank";
            case 27: return "Total Cleared #";
            case 28: return "Max Reached #";
            default: return "" + text;
        }
    }

    public override (string name, string effect, string passive, string reward) ExpeditionGlobalInformationString(ExpeditionGlobalInformation expedition, string text = "")
    {
        string name = "";
        string effect = "";
        string passive = "";
        string reward = "";

        switch (expedition.kind)
        {
            case ExpeditionKind.Brick:
                name = "Manufacturing Bricks";
                effect = "Bricks Gain : <color=green>" + percent(Math.Pow(1.1d, expedition.level.value)) + "</color>  ( x1.1 per Level )";
                passive = optStr + "Town Brick Buildings' level effect <color=green>+ " + percent(expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Lv )";
                break;
            case ExpeditionKind.Log:
                name = "Logging Trees";
                effect = "Logs Gain : <color=green>" + percent(Math.Pow(1.1d, expedition.level.value)) + "</color>  ( x1.1 per Level )";
                passive = optStr + "Town Log Buildings' level effect <color=green>+ " + percent(expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Lv )";
                break;
            case ExpeditionKind.Shard:
                name = "Gathering Shards";
                effect = "Shards Gain : <color=green>" + percent(Math.Pow(1.1d, expedition.level.value)) + "</color>  ( x1.1 per Level )";
                passive = optStr + "Town Shard Buildings' level effect <color=green>+ " + percent(expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Lv )";
                break;
            case ExpeditionKind.PetRank:
                name = "Capturing Monsters";
                effect = "Taming Point : <color=green>" + percent(Math.Pow(1.1d, expedition.level.value)) + "</color>  ( x1.1 per Level )";
                passive = optStr + "Multiply Taming Point Gain by <color=green>" + percent(1 + expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Lv )";
                reward = text + "'s Taming Point";
                break;
            case ExpeditionKind.Equipment:
                name = "Training Equipment";
                effect = "Proficiency Scroll's Time : <color=green>" + percent(1 + 0.10d * expedition.level.value) + "</color>  ( + " + percent(0.10d) + " per Level )";
                passive = optStr + "Multiply Equipment Proficiency Gain by <color=green>" + percent(1 + expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Lv )";
                break;
            case ExpeditionKind.PetExp:
                name = "Field Training";
                effect = "Pet EXP Gain : <color=green>" + percent(Math.Pow(1.2d, expedition.level.value)) + "</color>  ( x1.2 per Level )";
                passive = optStr + "Multiply Pet EXP Gain from any expeditions by <color=green>" + percent(1 + expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Lv )";
                reward = text + "'s Pet EXP";
                break;
            case ExpeditionKind.WalkDistance:
                name = "Marathon Race";
                effect = "Walked Distance : <color=green>" + percent(Math.Pow(1.2d, expedition.level.value)) + "</color>  ( x1.2 per Level )";
                passive = optStr + "Walked Distance Gain from expeditions <color=green>+ " + percent(expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Lv )";
                reward = text + " Walked Distance";
                break;
        }

        return (name, effect, passive, reward);
    }

    public override string ExpeditionString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Expedition Effect";
            case 1: return "Complete Reward";
            case 2: return "Pet EXP Gain";
            case 3: return "Information";
            case 4: return "Total Completed #";
            case 5: return "Total Time";
            default: return "" + text;
        }
    }
    public override string InAppPurchaseString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Get " + text + "Epic Coin right now!";
            case 1: return "Only the first purchase doubles Epic Coin!";
            default: return "" + text;
        }
    }
    public override string MonsterNameString(ChallengeMonsterKind kind)
    {
        switch (kind)
        {
            case ChallengeMonsterKind.Florzporb:
                return "Florzporb, Le Roi Slime";
            case ChallengeMonsterKind.Arachnetta:
                return "Arachnetta, La Veuve Noire";
            case ChallengeMonsterKind.GuardianKor:
                return "Guardian Kor, Le Géant de Pierre";
            case ChallengeMonsterKind.Nostro:
                return "Nostro, la Chauve-Souris Vampire";
            case ChallengeMonsterKind.LadyEmelda:
                return "Lady Emelda, la Fée Sorcière";
            case ChallengeMonsterKind.NariSune:
                return "Nari Sune, le Renard aux Neuf Queues";
            case ChallengeMonsterKind.Octobaddie:
                return "Octobaddie, Terreur des Profondeurs";
            case ChallengeMonsterKind.Bananoon:
                return "Bananoon, le Bananattaqueur";
            case ChallengeMonsterKind.Glorbliorbus:
                return "Glorbliorbus, le Slime Archimage";
            case ChallengeMonsterKind.DistortionSlime:
                return "Gankyū, le Slime Distordu";
        }
        return kind.ToString();
    }
    public override string MonsterShortNameString(ChallengeMonsterKind kind)
    {
        switch (kind)
        {
            case ChallengeMonsterKind.Florzporb:
                return "Florzporb";
            case ChallengeMonsterKind.Arachnetta:
                return "Arachnetta";
            case ChallengeMonsterKind.GuardianKor:
                return "Guardian Kor";
            case ChallengeMonsterKind.Nostro:
                return "Nostro";
            case ChallengeMonsterKind.LadyEmelda:
                return "Lady Emelda";
            case ChallengeMonsterKind.NariSune:
                return "Nari Sune";
            case ChallengeMonsterKind.Octobaddie:
                return "Octobaddie";
            case ChallengeMonsterKind.Bananoon:
                return "Bananoon";
            case ChallengeMonsterKind.Glorbliorbus:
                return "Glorbliorbus";
            case ChallengeMonsterKind.DistortionSlime:
                return "Gankyū";
        }
        return kind.ToString();
    }

    public override string MonsterPetPassiveEffectStreing(MonsterPet pet)
    {
        switch (pet.passiveEffectKind)
        {
            case PetPassiveEffectKind.ResourceGain:
                return "Gain de Ressources <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.OilOfSlimeDropChance:
                return Material(MaterialKind.OilOfSlime) + " Chance d'Apparition <color=green>+ " + percent(pet.effectValue, 3) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
            case PetPassiveEffectKind.EnchantedClothDropChance:
                return Material(MaterialKind.EnchantedCloth) + " Chance d'Apparition <color=green>+ " + percent(pet.effectValue, 3) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
            case PetPassiveEffectKind.SpiderSilkDropChance:
                return Material(MaterialKind.SpiderSilk) + " Chance d'Apparition <color=green>+ " + percent(pet.effectValue, 3) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
            case PetPassiveEffectKind.BatWingDropChance:
                return Material(MaterialKind.BatWing) + " Chance d'Apparition <color=green>+ " + percent(pet.effectValue, 3) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
            case PetPassiveEffectKind.FairyDustDropChance:
                return Material(MaterialKind.FairyDust) + " Chance d'Apparition <color=green>+ " + percent(pet.effectValue, 3) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
            case PetPassiveEffectKind.FoxTailDropChance:
                return Material(MaterialKind.FoxTail) + " Chance d'Apparition <color=green>+ " + percent(pet.effectValue, 3) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
            case PetPassiveEffectKind.FishScalesDropChance:
                return Material(MaterialKind.FishScales) + " Chance d'Apparition <color=green>+ " + percent(pet.effectValue, 3) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
            case PetPassiveEffectKind.CarvedBranchDropChance:
                return Material(MaterialKind.CarvedBranch) + " Chance d'Apparition <color=green>+ " + percent(pet.effectValue, 3) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
            case PetPassiveEffectKind.ThickFurDropChance:
                return Material(MaterialKind.ThickFur) + " Chance d'Apparition <color=green>+ " + percent(pet.effectValue, 3) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
            case PetPassiveEffectKind.UnicornHornDropChance:
                return Material(MaterialKind.UnicornHorn) + " Chance d'Apparition <color=green>+ " + percent(pet.effectValue, 3) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
            case PetPassiveEffectKind.PotionEffect:
                return "Effet des Potions + <color=green>" + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue, 3) + " / Rang )";
            case PetPassiveEffectKind.TamingPointGain:
                return "Gain de Points de Domptage + <color=green>" + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.GoldCap:
                return "Multiplie le Maximum d'Or par <color=green>" + percent(1 + pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue, 3) + " / Rang )";
            case PetPassiveEffectKind.GoldGain:
                return "Gain d'Or+ <color=green>" + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue, 3) + " / Rang )";
            case PetPassiveEffectKind.ExpGain:
                return "Gain d'EXP + <color=green>" + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.DoubleMaterialChance:
                return "Chance de Doubler le Gain de Matériaux : <color=green>" + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
            case PetPassiveEffectKind.GoldGainOnDisassemblePotion:
                return "Gain d'Or en Désassemblant les Potions <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.DisassembleTownMatGain:
                return "Gain de Matériel de Ville en Désassemblant de l'Équipement <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.TownMatGainFromDungeonReward:
                return "Gain de Matériel de Ville des Récompenses de Dongeons <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.EquipProfGain:
                return "Gain en Maîtrise d'Équipement <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.MysteriousWaterGain:
                return "Gain d'Eau Mystérieuse <color=green>+ " + tDigit(pet.effectValue, 3) + " / sec</color> ( + " + tDigit(pet.effectIncrementValue, 3) + " / Rang )";
            case PetPassiveEffectKind.ChestPortalOrbChance:
                return "Chance de Trouver une Orbe de Portail dans un Coffre : <color=green>" + percent(pet.effectValue, 4) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
            case PetPassiveEffectKind.SkillProfGain:
                return "Gain en Maîtrise de Capacité <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.TownMatGain:
                return "Multiplicateur de Gain de Matériaux de Ville <color=green>" + percent(1 + pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.ResearchPowerStone:
                return "Puissance de Recherche de Pierre <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue, 3) + " / Rang )";
            case PetPassiveEffectKind.ResearchPowerCrystal:
                return "Puissance de Recherche de Crystal <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue, 3) + " / Rang )";
            case PetPassiveEffectKind.ResearchPowerLeaf:
                return "Puissance de Recherche de Feuille <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue, 3) + " / Rang )";
            case PetPassiveEffectKind.Nothing:
                return "Restez à l'affut de futures mises à jour!";
            case PetPassiveEffectKind.CatalystCriticalChance:
                return "Multiplies la Chance de Succès Critique du Catalyst par <color=green>" + percent(1 + pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.MysteriousWaterCap:
                return "Mazimum d'Eau Mystérieuse <color=green>+ " + tDigit(pet.effectValue) + "</color> ( + " + tDigit(pet.effectIncrementValue, 2) + " / Rang )";
            case PetPassiveEffectKind.BlessingEffect:
                return "Effet des Bénédictions <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.LoyaltyPointGain:
                return "Gain de Points de Loyauté <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.PetExpGain:
                return "Gain D'EXP des Familiers <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
        }
        return "";
    }
    public override string TownMaterialNameString(TownMaterialKind kind)
    {
        switch (kind)
        {
            case TownMaterialKind.MudBrick:
                return "Brique de Boue";
            case TownMaterialKind.LimestoneBrick:
                return "Brique de Chaux";
            case TownMaterialKind.MarbleBrick:
                return "Brique de Marbre";
            case TownMaterialKind.GraniteBrick:
                return "Brique de Granite";
            case TownMaterialKind.BasaltBrick:
                return "Brique de Basalte";
            case TownMaterialKind.PineLog:
                return "Billot de Pin";
            case TownMaterialKind.MapleLog:
                return "Billot d'Érable";
            case TownMaterialKind.AshLog:
                return "Billot de Frêne";
            case TownMaterialKind.MahoganyLog:
                return "Billot d'Acajou";
            case TownMaterialKind.RosewoodLog:
                return "Billot de Bois de Rose";
            case TownMaterialKind.JasperShard:
                return "Éclat de Jaspe";
            case TownMaterialKind.OpalShard:
                return "Éclat d'Opale";
            case TownMaterialKind.OnyxShard:
                return "Éclat d'Onyx";
            case TownMaterialKind.JadeShard:
                return "Éclat de Jade";
            case TownMaterialKind.SapphireShard:
                return "Éclat de Sapphire";
        }
        return kind.ToString();
    }

    public override (string name, string description, string passive) WorldAscensionMilestoneString(WorldAscensionMilestone milestone, double currentValue = 0, double nextValue = 0)
    {
        string name = "";
        string description = "";
        string passive = "";

        switch (milestone.kind)
        {
            case WorldAscensionMiletoneKind.TownBuldingLevel:
                name = "Construisez la Ville";
                description = "Niveau Total des Bâtiments de la Ville";
                passive = "Effet du Niveau des Bâtiments de la Ville + " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
            case WorldAscensionMiletoneKind.MissionClearNum:
                name = "Émissaire de la Carte";
                description = "Missions de Zone complétées cette ascension #";
                passive = "Récompense en Matériaux de Ville par Difficulté de Zone + " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
            case WorldAscensionMiletoneKind.UpgradeLevel:
                name = "Très Ressourcé";
                description = "Niveau Total des Améliorations de Ressources";
                passive = "Gain en Ressources + " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
            case WorldAscensionMiletoneKind.MoveDistance:
                name = "Parcours le Monde";
                description = "Distance Marchée Totale (mètres)";
                passive = "Vitesse + " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
            case WorldAscensionMiletoneKind.DictionaryPoint:
                name = "Équipeur Poli";
                description = "Total des points de Dictionnaire";
                passive = "Amélioration des effets du Dictionnaire + " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
            case WorldAscensionMiletoneKind.DisassembleEquipment:
                name = "Désassembleur professionnel";
                description = "Total des Matériaux de Ville Acquis en désassemblant";
                passive = "Gain en Maîtrise d'Équipement+ " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
            case WorldAscensionMiletoneKind.RebirthPointGainTier1:
                name = "Réincarnateur 1";
                description = "Total des Points de Réincarnation Classe 1 gagnés";
                passive = "Gain de Points de Réincarnation Classe 1 + " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
            case WorldAscensionMiletoneKind.RebirthPointGainTier2:
                name = "Réincarnateur 2";
                description = "Total des Points de Réincarnation Classe 2 gagnés";
                passive = "Gain de Points de Réincarnation Classe 2 + " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
        }
        return (name, description, passive);
    }
    public override string WorldAscensionString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Niveau Maximum Atteint";
            case 1: return "Effet Passif";
            case 2: return "Point d'Ascension Monde";
            case 3: return "Nécessite Temple Rang 1 pour accéder aux Améliorations de Réincarnation Classe 2";
            default: return "" + text;
        }
    }
    public override (string name, string effect) WorldAscensionUpgradeString(WorldAscensionUpgrade upgrade, double value = 0)
    {
        string name = "";
        string effect = "";
        switch (upgrade.kind)
        {
            case AscensionUpgradeKind.GuildExpGain:
                name = "Booster d'EXP de Guilde";
                effect = "Multiplies le gain d'EXP de Guilde par " + percent(1 + value);
                break;
            case AscensionUpgradeKind.AreaClearCount:
                name = "Booster de Zone";
                effect = "Augmente le nombre de Complétion de Zone et la Récompense de Complétion par " + tDigit(value);
                break;
            case AscensionUpgradeKind.ActiveHero:
                name = "Expansion d'Emplacement de Héro Actif";
                effect = "Augmente le nombre d'Emplacements de Héros activables par " + tDigit(value);
                break;
            case AscensionUpgradeKind.SkillProfGain:
                name = "Boost de Maîtrise de Capacité";
                effect = "Augmente la Maîtrise de Capacité par " + percent(value);
                break;
            case AscensionUpgradeKind.PreRebirthTier1:
                name = "Points de Pré-Réincarnation Classe 1";
                effect = "Ajoute des points de Réincarnation Classe 1 gratuits + " + tDigit(value) + " au début d'une nouvelle AM";
                break;
            case AscensionUpgradeKind.PreRebirthTier2:
                name = "Points de Pré-Réincarnation Classe 2";
                effect = "Ajoute des points de Réincarnation Classe 2 gratuits + " + tDigit(value) + " au début d'une nouvelle AM";
                break;
            case AscensionUpgradeKind.RebirthTier1BonusCap:
                name = "Expansion du Bonus de Réincarnation Classe 1";
                effect = "Augmente le niveau maximal des Points d'Abilité Bonus Classe 1 par Niv " + tDigit(value);
                break;
            case AscensionUpgradeKind.RebirthTier2BonusCap:
                name = "Expansion du Bonus de Réincarnation Classe 2";
                effect = "Augmente le niveau maximal des Points d'Abilité Bonus Classe 2 par Niv " + tDigit(value);
                break;
            case AscensionUpgradeKind.PointGainBonus:
                name = "Efficacité des points d'AM par palier";
                effect = "Augmente le nombre de points gagnés par niveau de palier d'AM par " + tDigit(value);
                break;
        }

        return (name, effect);
    }
    public override string IEH1PlayerBonusString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Cette fonctionnalité n'est disponible que sur Steam.";
            case 1: return "Échec.";
            case 2: return "Les données se font acquérir...";
            case 3: return "Le serveur Steam ne fonctionne présentement pas. Veuillez redémarrer le jeu et essayer à nouveau.";
            case 4: return "Échec du Succès Steam.\nVeuillez vérifier la configuration suivante:\nProfile Steam > Modifier le Profile > Options de confidentialité > Visibilité sur mes jeux : [tout le monde]\n\n";
            case 5: return "Limite de Quêtes Acceptées + 1";
            case 6: return "Il vous faut " + text + " emplacements d'inventaire d'utilitaire!";
            case 7: return "Vous avez déjà reçu tous les bonus courrants.";
            default: return "" + text;
        }
    }

    public override string TresureChestString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Le coffre était un Mimic!!!";
            case 1: return "Bénédiction!";
            case 2: return "Temps Limite + 30 sec!";
            case 3: return "1 Orbe Portail!";
            case 4: return "Talisman!";
            default: return "" + text;
        }
    }
}
