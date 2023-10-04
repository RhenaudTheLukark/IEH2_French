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
            case BasicWord.Trigger:
                return "lancement";
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
                return "Incrément d'Abilité Requis";
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
                return "Pièce Épique";
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
                return "Bâtiment";
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
                return "Actif";
            case BasicWord.Off:
                return "Inactif";
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
                return "PV Restauré";
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
                return "Potions";
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
            case BasicWord.Ascend:
                return "Ascension";
            case BasicWord.QuestCancelText:
                return "Êtes-vous sûr de vouloir annuler cette quête ?";
            case BasicWord.AreaMissionMilestone:
                return "Palier de Mission de Zone";
            case BasicWord.TalismanFragments:
                return "Fragments de Talisman";
            case BasicWord.Equipment:
                return "Équipement";
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
            case BasicWord.EnchantScroll:
                return "Parchemin d'Enchantement";
            case BasicWord.Trap:
                return "Piège";
            case BasicWord.Blessing:
                return "Bénédiction";
            case BasicWord.TownMat:
                return "Mat. de Ville";
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
                return "MAGASIN Épique";
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
                return "Déplacement Auto";
            case BasicWord.ManualMove:
                return "Déplacement Manuel";
            case BasicWord.ManualMoveText:
                return "WASD ou les flèches pour se déplacer manuellement";
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
                return "Pile";
            case BasicWord.Unique:
                return "Unique";
            case BasicWord.Accepted:
                return "Accepté";
            case BasicWord.Questing:
                return "Se déplacer";
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
            case BasicWord.To:
                return "en";
            case BasicWord.AvailableBlessing:
                return "Disponible";
            case BasicWord.StackNum:
                return "Pile #";
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
            case BasicWord.AreaPrestigeLockText:
                return "< PRESTIGE DE ZONE >\n" + "<sprite=\"locks\" index=0> Faire une Ascension Monde Classe 1 une fois (ça vaut le coup)";
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
            case BasicWord.ClearPlaytime:
                return "Temps de Complétion";
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
            case BasicWord.CacheSave:
                return "Sauvegarde Rapide";
            case BasicWord.SetToTheCurrentArea:
                return "Sélectionne la zone courante en tant que Zone Favorite\n(Maj + Clic Droit pour l'assigner à tous les héros.)";
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
                return "Quand un équipement avec l'effet d'enchantement coché d'un niveau donné ou supérieur est récupéré, l'exclure de l'Auto Désassemblage. \nSi le [# d'Emplacements d'Enchantement incluant l'effet] est coché et est mis à 2 ou 3, alors il désassemblera tout ce qui ne suit pas son prérequis donné, peu importe les autres enchantements cochés. Le Nv entre parenthèses représente le niveau de monstre le plus bas qui peut lâcher un objet ayant cet enchantement.";
            case BasicWord.OrMore:
                return "ou plus";
            case BasicWord.EnchantSlotNumber:
                return "# d'Emplacements d'Enchantement incluant l'effet";
            case BasicWord.Attempt:
                return "Essayer";
            case BasicWord.InputNewMultiplier:
                return "Rentrer la nouvelle valeur du multiplicateur.";
            case BasicWord.PetStats:
                return "Stats du Familier";
            case BasicWord.FieldCurse:
                return "Malédiction du Terrain";
            case BasicWord.RestorePurchase:
                return "Restaurer les Achats";
            case BasicWord.NetFree:
                return "Sans Filet";
            case BasicWord.Dung:
                return "Donj";
            case BasicWord.ScrollFilter:
                return "Filtre de Parchemin";
            case BasicWord.ScrollFilterDescription:
                return "Les parchemins ayant une coche seront gardés après avoir réclamé la récompense. Les parchemins sans coche seront désassemblés. ";
            case BasicWord.AutoAreaProgression:
                return "Auto Progression de Zone";
            case BasicWord.AutoAreaProgressionDescription:
                return "Le héros actif ira dans chaque zone pour atteindre le # de Complétions donné ci-dessous, en commençant par Village des Slimes 1. Ce nombre est basé sur la Difficulté courante de la Zone. L'Auto Progression de Zone passera les zones verrouillées, ainsi que les zones ayant déjà atteint le # de Complétions cible. NOTE: Pendant l'Auto Progression de Zone, [Chasseur d'Invasion] restera actif. [Auto-Réincarnation] restera actif. [Zone Favorite], [Meilleur Gain d'EXP] et [Mode Quête Automatique] seront désactivés. Après une réincarnation ou un donjon, le héros sera renvoyé à la première zone qui ne remplit pas le critère de complétion donné.";
            case BasicWord.AutoProgression:
                return "Progression Auto";
            case BasicWord.InputAll:
                return "Tout Mettre à";
            case BasicWord.PerformanceModeText:
                return "<size=24>Mode Performance Actif</size> \n\nMaj+P pour désactiver";
            case BasicWord.LazyQuestingMode:
                return "Mode Quête Automatique (Maj + Clic Droit sur le bouton \"" + BasicWord.Questing + "\" pour changer la zone de quête)";
            case BasicWord.ManualQuestingArea:
                return "Maj + Clic Droit pour enregistrer la zone courante en tant que zone de quête.";
            case BasicWord.Save:
                return "Sauver";
            case BasicWord.Load:
                return "Charger";
            case BasicWord.AMWASaveDescription:
                return "Cliquez pour sauvegarder le ratio d'allocation d'Eau Mystérieuse par Essence.";
            case BasicWord.AMWALoadDescription:
                return "L'Eau Mystérieuse (/sec) sera allouée aux Essences au ratio sauvegardé.";
            case BasicWord.CurrentSave:
                return "Sauvegarde Courante";
            case BasicWord.ArmoredFuryDescription:
                return "Augmente les Dégâts Physiques par ([Furie d'Armure] x Log2([DEF]))%";
            case BasicWord.WardedFuryDescription:
                return "Augmente les Dégâts Magiques par ([Furie d'Esprit] x Log2([MDEF]))%";
            case BasicWord.After:
                return "Après";
            case BasicWord.NumberFormat:
                return "Format de Nombre";
            case BasicWord.Lv:
                return "Nv";
            case BasicWord.GLv:
                return "GNv";
            case BasicWord.Fame:
                return "Renommée";
            case BasicWord.Grade:
                return "Classe";
            case BasicWord.DungeonCoin:
                return "Pièce Donjon";
            case BasicWord.Super:
                return "Super";
            case BasicWord.SuperAbility:
                return "Super Capacité";
            case BasicWord.Normal:
                return "Normal";
            case BasicWord.AlchemyPointGain:
                return "Gain de Point d'Alchimie";
            case BasicWord.EnchantedEffectChance1:
                return "Chance de 1er Emplacement d'Enchantement";
            case BasicWord.EnchantedEffectChance2:
                return "Chance de 2ème Emplacement d'Enchantement";
            case BasicWord.EnchantedEffectChance3:
                return "Chance de 3ème Emplacement d'Enchantement";
            case BasicWord.WarriorSkillLevelBonus:
                return "Bonus de Niveau de Capacité du Guerrier";
            case BasicWord.WizardSkillLevelBonus:
                return "Bonus de Niveau de Capacité du Mage";
            case BasicWord.AngelSkillLevelBonus:
                return "Bonus de Niveau de Capacité de l'Ange";
            case BasicWord.ThiefSkillLevelBonus:
                return "Bonus de Niveau de Capacité du Voleur";
            case BasicWord.ArcherSkillLevelBonus:
                return "Bonus de Niveau de Capacité de l'Archer";
            case BasicWord.TamerSkillLevelBonus:
                return "Bonus de Niveau de Capacité de la Dompteuse";
            case BasicWord.WarriorSkillRange:
                return "Portée des Capacités du Guerrier";
            case BasicWord.WizardSkillRange:
                return "Portée des Capacités du Mage";
            case BasicWord.AngelSkillRange:
                return "Portée des Capacités de l'Ange";
            case BasicWord.ThiefSkillRange:
                return "Portée des Capacités du Voleur";
            case BasicWord.ArcherSkillRange:
                return "Portée des Capacités de l'Archer";
            case BasicWord.TamerSkillRange:
                return "Portée des Capacités de la Dompteuse";
            case BasicWord.WarriorSkillAreaOfEffect:
                return "Zone d'Effet des Capacités du Guerrier";
            case BasicWord.WizardSkillAreaOfEffect:
                return "Zone d'Effet des Capacités du Mage";
            case BasicWord.AngelSkillAreaOfEffect:
                return "Zone d'Effet des Capacités de l'Ange";
            case BasicWord.ThiefSkillAreaOfEffect:
                return "Zone d'Effet des Capacités du Voleur";
            case BasicWord.ArcherSkillAreaOfEffect:
                return "Zone d'Effet des Capacités de l'Archer";
            case BasicWord.TamerSkillAreaOfEffect:
                return "Zone d'Effet des Capacités de la Dompteuse";
            case BasicWord.Skills:
                return "Capacités";
            case BasicWord.HeroGrade:
                return "Classe du Héros";
            case BasicWord.Artifact:
                return "Antiquité";
            case BasicWord.ArtifactReplica:
                return "Réplique d'Antiquité";
            case BasicWord.ArtifactProficiency:
                return "Maîtrise d'Antiquité";
            case BasicWord.PermanentEffect:
                return "Effet Permanent";
            case BasicWord.Topaz:
                return "Topaze";
            case BasicWord.Ruby:
                return "Rubis";
            case BasicWord.PieceOfRuby:
                return "Morceau de Rubis";
            case BasicWord.EntryCostRefreshTicket:
                return "Ticket de Rafraîchissement de Coût d'Entrée";
            case BasicWord.Floor:
                return "Niveau";
            case BasicWord.Attack:
                return "Attaque";
            case BasicWord.Defense:
                return "Défense";
            case BasicWord.Bestiary:
                return "Bestiaire";
            case BasicWord.AttackStats:
                return "Stats d'Attaque";
            case BasicWord.DefenseStats:
                return "Stats de Défense";
            case BasicWord.SkillStats:
                return "Stats de Capacité";
            case BasicWord.BestiaryStats:
                return "Stats de Bestiaire";
            case BasicWord.ExtraAfterDamage:
                return "Dégâts Absolus Supplémentaires";
            case BasicWord.DungeonCoinGain:
                return "Gain de Pièce de Donjon";
            case BasicWord.DoubleCaptureChance:
                return "Chance de Double Capture";
            case BasicWord.TripleCaptureChance:
                return "Chance de Triple Capture";
            case BasicWord.EquipmentEffect:
                return "Effet d'Équipement";
            case BasicWord.ExpeditionPassiveEffect:
                return "Effet d'Expedition Passif";
            case BasicWord.SlimeCoinCap:
                return "Limite de Pièce Smile";
            case BasicWord.LastMinuteFame:
                return "Renommée gagné depuis une minute";
            case BasicWord.SD:
                return "SD";
            case BasicWord.TemporaryTotal:
                return "Total Temporaire";
        }
        return base.Basic(basicWord);
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
                return "Amélioration";
            case MenuKind.Equip:
                return "Équipement";
            case MenuKind.Guild:
                return "Guilde";
            case MenuKind.Quest:
                return "Quête";
            case MenuKind.Lab:
                return "Labo";
            case MenuKind.Setting:
                return "Options";
            case MenuKind.Bestiary:
                return "Bestiaire";
            case MenuKind.Rebirth:
                return "Réincarnation";
            case MenuKind.Challenge:
                return "Défi";
            case MenuKind.SuperDungeon:
                return "Super Donjon";
            case MenuKind.Ascension:
                return "Ascension";
            case MenuKind.Town:
                return "Ville";
            case MenuKind.Shop:
                return "Magasin";
            case MenuKind.Expedition:
                return "Expédition";
        }
        return base.Menu(kind);
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
                return "Extension de Limite";
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
            case MultiplierKind.ArmoredFury:
                return "Furie d'Armure";
            case MultiplierKind.WardedFury:
                return "Furie d'Esprit";
            case MultiplierKind.SuperAbility:
                return "Super Capacité";
            case MultiplierKind.PetRankMilestone:
                return "Pilier de Rang de Familier";
            case MultiplierKind.SuperDungeon:
                return "Super Donjon";
            case MultiplierKind.DungeonItem:
                return "Pouvoir de Super Donjon";
            case MultiplierKind.DungeonItemPermanent:
                return "Pouvoir de Super Donjon (Permanent)";
            case MultiplierKind.SDUpgrade:
                return "Amélioration de Super Donjon";
            case MultiplierKind.SDShop:
                return "Magasin de Super Donjon";
            case MultiplierKind.GradeMilestone:
                return "Palier de Classe";
            case MultiplierKind.ExpeditionMilestone:
                return "Palier d'Expédition";
        }
        return base.StatsBreakdown(kind);
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
        return base.ResourceName(kind);
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
        return base.Hero(kind);
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
        return base.BasicStatsDescription(kind);
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
                return "Gain d'EXP";
            case Stats.SkillProficiencyGain:
                return "Maîtrise de Capacité";
            case Stats.EquipmentProficiencyGain:
                return "Maîtrise d'Équipement";
            case Stats.EquipmentDropChance:
                return "Apparition d'Équipement";
            case Stats.MoveSpeed:
                return "Vitesse de Déplacement";
            case Stats.TamingPointGain:
                return "Points de Domptage";
            case Stats.ArmoredFury:
                return "Furie d'Armure";
            case Stats.WardedFury:
                return "Furie d'Esprit";
            case Stats.PetPhysCritChance:
                return "Chance de Coup Critique Physique de Familier";
            case Stats.PetMagCritChance:
                return "Chance de Coup Critique Magique de Familier";
            case Stats.PetCriticalDamage:
                return "Dégâts Critiques de Familier";
            case Stats.PetDebuffResistance:
                return "Résistance aux Débuffs de Familier";
            case Stats.ArtifactProficiencyGain:
                return "Gain de Maîtrise d'Antiquité";
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
        return base.GlobalStat(stats);
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
        return base.Ability(kind);
    }
    public override string SuperAbility(AbilityKind kind)
    {
        switch (kind)
        {
            case AbilityKind.Vitality:
                return "Super VTL";
            case AbilityKind.Strength:
                return "Super FOR";
            case AbilityKind.Intelligence:
                return "Super INT";
            case AbilityKind.Agility:
                return "Super AGI";
            case AbilityKind.Luck:
                return "Super CHA";
        }
        return Basic(BasicWord.Super) + " " + kind.ToString();
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
                return "L'Agilité a un effet sur les PM, la CEL et la Vitesse de Déplacement.";
            case AbilityKind.Luck:
                return "La Chance a un effet sur la Chance de Coup Critique et la Chance d'Apparition d'Équipement.";
        }
        return base.AbilityDescription(kind);
    }
    public override string SuperAbilityDescription(AbilityKind kind)
    {
        switch (kind)
        {
            case AbilityKind.Vitality:
                return "La Super Vitalité a un effet sur les PV, la DEF et la MDEF Multiplicatifs et Absolus.";
            case AbilityKind.Strength:
                return "La Super Force a un effet sur l'ATQ et la DEF Multiplicatifs et Absolus.";
            case AbilityKind.Intelligence:
                return "La Super Intelligence a un effet sur les PM, la MATQ et la MDEF Multiplicatifs et Absolus.";
            case AbilityKind.Agility:
                return "La Super Agilité a un effet sur les PM, la CEL et la Vitesse de Déplacement Multiplicatifs et Absolus.";
            case AbilityKind.Luck:
                return "La Super Chance a un effet sur la Chance de Coup Critique et la Chance d'Apparition d'Équipement Multiplicatifs et Absolus.";
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
                return "Dégâts - Poissons Démons";
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
                return "Dégâts - Boss";
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
        return base.AbilityWord(kind);
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
        return base.Title(kind);
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
                tempString = optStr + "Vitesse de Déplacement + " + percent(effectValue);
                break;
            case TitleKind.Alchemist:
                tempString = optStr + "Gain d'Eau Mystérieuse + " + percent(effectValue);
                break;
            case TitleKind.MetalHunter:
                if (isSub) tempString = optStr + "Gain d'EXP venant de monstres Métalliques + " + percent(effectValue);
                else
                    tempString = optStr + "Dégâts infligés aux monstres Métalliques + " + tDigit(effectValue);
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
                tempString = optStr + "Permet une Activation en Arrière-Plan qui gagne " + percent(effectValue) + " des ressources normales";
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
        return base.MonsterSpeciesName(species);
    }
    public enum GenderKind
    {
        Male,
        Female
    }
    public GenderKind MonsterSpeciesGenderKind(MonsterSpecies species)
    {
        switch (species)
        {
            case MonsterSpecies.Slime:
                return GenderKind.Male;
            case MonsterSpecies.MagicSlime:
                return GenderKind.Male;
            case MonsterSpecies.Spider:
                return GenderKind.Female;
            case MonsterSpecies.Bat:
                return GenderKind.Female;
            case MonsterSpecies.Fairy:
                return GenderKind.Female;
            case MonsterSpecies.Fox:
                return GenderKind.Male;
            case MonsterSpecies.DevilFish:
                return GenderKind.Male;
            case MonsterSpecies.Treant:
                return GenderKind.Male;
            case MonsterSpecies.FlameTiger:
                return GenderKind.Male;
            case MonsterSpecies.Unicorn:
                return GenderKind.Female;
            default:
                return GenderKind.Male;
        }
    }
    public override string MonsterName(MonsterSpecies species, MonsterColor color)
    {
        string tempColorStr = color.ToString();
        string tempSpeciesStr = MonsterSpeciesName(species);
        if (MonsterSpeciesGenderKind(species) == GenderKind.Male)
        {
            //Male
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
                    tempColorStr = "de Métal";
                    break;
            }
        }
        else
        {
            //Female
            switch (color)
            {
                case MonsterColor.Normal:
                    tempColorStr = "Normale";
                    break;
                case MonsterColor.Blue:
                    tempColorStr = "Bleue";
                    break;
                case MonsterColor.Yellow:
                    tempColorStr = "Jaune";
                    break;
                case MonsterColor.Red:
                    tempColorStr = "Rouge";
                    break;
                case MonsterColor.Green:
                    tempColorStr = "Verte";
                    break;
                case MonsterColor.Purple:
                    tempColorStr = "Violette";
                    break;
                case MonsterColor.Boss:
                    tempColorStr = "Boss";
                    break;
                case MonsterColor.Metal:
                    tempColorStr = "de Métal";
                    break;
            }
        }
        return tempSpeciesStr + " " + tempColorStr;
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
                return "Réapprovisionne les objets Utilitaires équipés";
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
                return "Achète la " + Material(MaterialKind.FairyDust) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialFox:
                return "Achète la " + Material(MaterialKind.FoxTail) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialDevilfish:
                return "Achète les " + Material(MaterialKind.FishScales) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialTreant:
                return "Achète la " + Material(MaterialKind.CarvedBranch) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialFlametiger:
                return "Achète la " + Material(MaterialKind.ThickFur) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopMaterialUnicorn:
                return "Achète la " + Material(MaterialKind.UnicornHorn) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopTrapNormal:
                return "Achète le " + PotionName(PotionKind.ThrowingNet) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopTrapIce:
                return "Achète le " + PotionName(PotionKind.IceRope) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopTrapThunder:
                return "Achète le " + PotionName(PotionKind.ThunderRope) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopTrapFire:
                return "Achète le " + PotionName(PotionKind.FireRope) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopTrapLight:
                return "Achète le " + PotionName(PotionKind.LightRope) + " automatiquement dans le magasin";
            case PetActiveEffectKind.BuyShopTrapDark:
                return "Achète le " + PotionName(PotionKind.DarkRope) + " automatiquement dans le magasin";
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
            case PetActiveEffectKind.AutoSwitchTownResearch:
                return "Automatiquement change la recherche vers un autre projet lorsque le projet actuel est maximisé.";
            case PetActiveEffectKind.ClearLowerDifAreaMission:
                return "Lorsqu'une mission est complétée, la même mission sera complétée dans les difficultés inférieures.";
            case PetActiveEffectKind.AutoAlchemiseForNito:
                return "Créée et désassemble des Potions de Soin Mineures automatiquement pour maximiser la Nitro lorsqu'il n'y en a plus. (le Slime Magique Bleu doit être Actif, requiert [Auto Désassemblage de Potion Avancé] dans le Magasin Épique et assez d'essences pour maximiser la Nitro)";
            case PetActiveEffectKind.AutoBuyGuildAbility:
                return "Achète les Capacités de Guilde automatiquement.\nMaj + Flèche Haut/Bas sur une capacité de guilde pour augmenter/réduire le niveau visé.";
        }
        return base.PetActiveEffect(kind);
    }
    public override string PetActiveEffectImprovement(PetActiveEffectKind kind)
    {
        switch (kind)
        {
            case PetActiveEffectKind.UpgradeQueue:
                return "File d'Amélioration Disponible + 5";
            case PetActiveEffectKind.AlchemyQueue:
                return "File d'Alchimie Disponible + 5";
            case PetActiveEffectKind.DisassembleEquipment:
                return "Emplacement d'Auto-Désassemblage d'Équipement + 5";
            case PetActiveEffectKind.BuyShopTrapNormal:
                return "Réduit le temps de recharge du " + PotionName(PotionKind.ThrowingNet) + " par 1";
            case PetActiveEffectKind.BuyShopTrapIce:
                return "Réduit le temps de recharge du " + PotionName(PotionKind.IceRope) + " par 1";
            case PetActiveEffectKind.BuyShopTrapThunder:
                return "Réduit le temps de recharge du " + PotionName(PotionKind.ThunderRope) + " par 1";
            case PetActiveEffectKind.BuyShopTrapFire:
                return "Réduit le temps de recharge du " + PotionName(PotionKind.FireRope) + " par 1";
            case PetActiveEffectKind.BuyShopTrapLight:
                return "Réduit le temps de recharge du " + PotionName(PotionKind.LightRope) + " par 1";
            case PetActiveEffectKind.BuyShopTrapDark:
                return "Réduit le temps de recharge du " + PotionName(PotionKind.DarkRope) + " par 1";
            case PetActiveEffectKind.BuyShopMaterialSlime:
                return "Réapprovisionnement de Matériau dans le Magasin + 50";
            case PetActiveEffectKind.BuyShopMaterialMagicSlime:
                return "Réapprovisionnement de Matériau dans le Magasin + 50";
            case PetActiveEffectKind.BuyShopMaterialSpider:
                return "Réapprovisionnement de Matériau dans le Magasin + 50";
            case PetActiveEffectKind.BuyShopMaterialBat:
                return "Réapprovisionnement de Matériau dans le Magasin + 50";
            case PetActiveEffectKind.BuyShopMaterialFairy:
                return "Réapprovisionnement de Matériau dans le Magasin + 50";
            case PetActiveEffectKind.BuyShopMaterialFox:
                return "Réapprovisionnement de Matériau dans le Magasin + 50";
            case PetActiveEffectKind.BuyShopMaterialDevilfish:
                return "Réapprovisionnement de Matériau dans le Magasin + 50";
            case PetActiveEffectKind.BuyShopMaterialTreant:
                return "Réapprovisionnement de Matériau dans le Magasin + 50";
            case PetActiveEffectKind.BuyShopMaterialFlametiger:
                return "Réapprovisionnement de Matériau dans le Magasin + 50";
            case PetActiveEffectKind.BuyShopMaterialUnicorn:
                return "Réapprovisionnement de Matériau dans le Magasin + 50";
            case PetActiveEffectKind.RebirthTier1:
                return "Débloque un bouton dans la Réincarnation de Classe 1 qui achète l'amélioration la moins chère automatiquement.";
            case PetActiveEffectKind.RebirthTier2:
                return "Débloque un bouton dans la Réincarnation de Classe 2 qui achète l'amélioration la moins chère automatiquement.";
            case PetActiveEffectKind.RebirthTier3:
                return "Débloque un bouton dans la Réincarnation de Classe 3 qui achète l'amélioration la moins chère automatiquement.";
            case PetActiveEffectKind.RebirthTier4:
                return "Débloque un bouton dans la Réincarnation de Classe 4 qui achète l'amélioration la moins chère automatiquement.";
            case PetActiveEffectKind.RebirthTier5:
                return "Débloque un bouton dans la Réincarnation de Classe 5 qui achète l'amélioration la moins chère automatiquement.";
            case PetActiveEffectKind.RebirthTier6:
                return "Débloque un bouton dans la Réincarnation de Classe 6 qui achète l'amélioration la moins chère automatiquement.";
            case PetActiveEffectKind.DisassembleTalismanCommon:
                return "Permet la sélection de talismans à auto-désassembler.";
        }
        return "";
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
                return "Lac des Poissons Démons";
            case AreaKind.TreantDarkForest:
                return "Forêt Noire des Tréants";
            case AreaKind.FlameTigerVolcano:
                return "Volcan des Tigres de Feu";
            case AreaKind.UnicornIsland:
                return "Île des Licornes";
        }
        return base.AreaName(kind);
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
            case AreaPrestigeUpgradeKind.UnlockMission:
                tempName = "Challengeur de Mission";
                tempEffect = "Débloque " + tDigit(upgrade.effectValue) + " autre(s) mission(s) ";
                tempNextEffect = "Débloque " + tDigit(upgrade.nextEffectValue) + " autre(s) mission(s) ";
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
                tempEffect = "Vitesse de Déplacement + " + percent(upgrade.effectValue) + " si vous êtes dans la région " + AreaName(upgrade.prestige.areaKind);
                tempNextEffect = "Vitesse de Déplacement + " + percent(upgrade.nextEffectValue) + " si vous êtes dans la région " + AreaName(upgrade.prestige.areaKind);
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
            case EquipmentKind.MagicSlimeRecorder:
                return "Flûte de Slime Magique";
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
            case EquipmentKind.BatRecorder:
                return "Flûte Chauve-Souris";
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
            case EquipmentKind.DevilfishRecorder:
                return "Flûte Poisson Démon";
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
            case EquipmentKind.FlametigerPortableHotSpring:
                return "Source Chaude Portable de Tigre de Feu";
            case EquipmentKind.FlametigerVolcanicShield:
                return "Bouclier Volcanique de Tigre de Feu";
            case EquipmentKind.FlametigerStripedBriefs:
                return "Slip à Rayures de Tigre de Feu";
            case EquipmentKind.TorchOfEverburningFlametiger:
                return "Torche Eternelle de Tigre de Feu";
            case EquipmentKind.FlametigerCostume:
                return "Costume de Tigre de Feu";
            case EquipmentKind.RingOfFlametigersWrath:
                return "Anneau de Colère de Tigre de Feu";
            case EquipmentKind.EndlessBowlOfSpicyFlametigerRamen:
                return "Bol de Ramen Epicé Sans Fin de Tigre de Feu";
            case EquipmentKind.ScreenOfTheSneakyFlametiger:
                return "Ecran Furtif de Tigre de Feu";
            case EquipmentKind.ModifiedSword:
                return "Epée Antique";
            case EquipmentKind.ModifiedStaff:
                return "Bâton Antique";
            case EquipmentKind.ModifiedWing:
                return "Aile Antique";
            case EquipmentKind.ModifiedDart:
                return "Fléchette Antique";
            case EquipmentKind.ModifiedBow:
                return "Arc Antique";
            case EquipmentKind.ModifiedRecorder:
                return "Flûte Antique";
            case EquipmentKind.AncientCloak:
                return "Cape Antique";
            case EquipmentKind.AncientBelt:
                return "Ceinture Antique";
            case EquipmentKind.AncientShoes:
                return "Chaussures Antiques";
            case EquipmentKind.AncientRing:
                return "Bague Antique";
            case EquipmentKind.AncientEarring:
                return "Boucle d'Oreille Antique";
        }
        return base.EquipmentName(kind);
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
                return "CEL +";
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
                return "Vitesse de Déplacement +";
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
                return "Affinité - Poissons Démons";
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
            case EquipmentEffectKind.HpRegenMultiplier:
                return "Multiplicateur de Régénération de PV";
            case EquipmentEffectKind.MpRegenMultiplier:
                return "Multiplicateur de Régénération de PM";
            case EquipmentEffectKind.ArmoredFury:
                return "Furie d'Armure";
            case EquipmentEffectKind.WardedFury:
                return "Furie d'Esprit";
            case EquipmentEffectKind.PetPhysicalCriticalChance:
                return "Chance de Coup Critique Physique de Familier";
            case EquipmentEffectKind.PetMagicalCriticalChance:
                return "Chance de Coup Critique Magique de Familier";
            case EquipmentEffectKind.PetCriticalDamage:
                return "Dégâts Critiques de Familier";
            case EquipmentEffectKind.PetDebuffResistance:
                return "Résistance aux Débuffs de Familier";
            case EquipmentEffectKind.StoneTownResearchPower:
                return "Pouvoir de Recherche de Pierre";
            case EquipmentEffectKind.CrystalTownResearchPower:
                return "Pouvoir de Recherche de Crystal";
            case EquipmentEffectKind.LeafTownResearchPower:
                return "Pouvoir de Recherche de Feuille";
            case EquipmentEffectKind.GuildEXPGain:
                return "Gain d'EXP de Guilde";
            case EquipmentEffectKind.SPDMultiplier:
                return "Multiplicateur de CEL";
            case EquipmentEffectKind.CriticalDamageMultiplier:
                return "Multiplicateur de Dégâts Critiques";
            case EquipmentEffectKind.SkillProficiencyMultiplier:
                return "Multiplicateur de Maîtrise de Capacité";
            case EquipmentEffectKind.EquipmentProficiencyMultiplier:
                return "Multiplicateur de Maîtrise d'Équipement";
            case EquipmentEffectKind.EXPGainMultiplier:
                return "Multiplicateur de Gain d'EXP";
            case EquipmentEffectKind.GoldGainMultiplier:
                return "Multiplicateur de Gain d'Or";
            case EquipmentEffectKind.PhysicalDamageMultiplier:
                return "Multiplicateur de Dégâts Physiques";
            case EquipmentEffectKind.FireDamageMultiplier:
                return "Multiplicateur de Dégâts de Feu";
            case EquipmentEffectKind.IceDamageMultiplier:
                return "Multiplicateur de Dégâts de Glace";
            case EquipmentEffectKind.ThunderDamageMultiplier:
                return "Multiplicateur de Dégâts d'Electricité";
            case EquipmentEffectKind.LightDamageMultiplier:
                return "Multiplicateur de Dégâts de Lumière";
            case EquipmentEffectKind.DarkDamageMultiplier:
                return "Multiplicateur de Dégâts des Ténèbres";
            case EquipmentEffectKind.TamingPointMultiplier:
                return "Multiplicateur de Gain de Points de Domptage";
            case EquipmentEffectKind.PetEXPGainMultiplier:
                return "Multiplicateur de Gain d'EXP de Familier";
            case EquipmentEffectKind.LoyaltyPointGainMultiplier:
                return "Multiplicateur de Gain de Points de Loyauté";
            case EquipmentEffectKind.BlessingEffectMultiplier:
                return "Multiplicateur d'Effet de Bénédiction";
            case EquipmentEffectKind.PhysicalCriticalMultiplier:
                return "Multiplicateur de Critique Physique";
            case EquipmentEffectKind.MagicalCriticalMultiplier:
                return "Multiplicateur de Critique Magique";
            case EquipmentEffectKind.ChallengeBossKnowledge:
                return "Connaissance de Boss de Défi";
            case EquipmentEffectKind.HPAfter:
                return "PV Absolus";
            case EquipmentEffectKind.MPAfter:
                return "MP Absolus";
            case EquipmentEffectKind.ATKAfter:
                return "ATQ Absolue";
            case EquipmentEffectKind.MATKAfter:
                return "MATQ Absolue";
            case EquipmentEffectKind.DEFAfter:
                return "DEF Absolue";
            case EquipmentEffectKind.MDEFAfter:
                return "MDEF Absolue";
            case EquipmentEffectKind.SPDAfter:
                return "VIT Absolue";
            case EquipmentEffectKind.MoveSpeedAfter:
                return "Vitesse de Déplacement Absolue";
            case EquipmentEffectKind.PhysicalCriticalAfter:
                return "Critique Physique Absolu";
            case EquipmentEffectKind.MagicalCriticalAfter:
                return "Critique Magique Absolu";
            case EquipmentEffectKind.CriticalDamageAfter:
                return "Dégâts Critique Absolus";
            case EquipmentEffectKind.DebuffResistanceAfter:
                return "Résistance aux Débuffs Absolue";
            case EquipmentEffectKind.PhysicalDamageAfter:
                return "Dégâts Physiques Absolus";
            case EquipmentEffectKind.FireDamageAfter:
                return "Dégâts de Feu Absolus";
            case EquipmentEffectKind.IceDamageAfter:
                return "Dégâts de Glace Absolus";
            case EquipmentEffectKind.ThunderDamageAfter:
                return "Dégâts d'Electricité Absolus";
            case EquipmentEffectKind.LightDamageAfter:
                return "Dégâts de Lumière Absolus";
            case EquipmentEffectKind.DarkDamageAfter:
                return "Dégâts des Ténèbres Absolus";
            case EquipmentEffectKind.FireResistanceAfter:
                return "Résistance au Feu Absolue";
            case EquipmentEffectKind.IceResistanceAfter:
                return "Résistance à la Glace Absolue";
            case EquipmentEffectKind.ThunderResistanceAfter:
                return "Résistance à l'Electricité Absolue";
            case EquipmentEffectKind.LightResistanceAfter:
                return "Résistance à la Lumière Absolue";
            case EquipmentEffectKind.DarkResistanceAfter:
                return "Résistance aux Ténèbres Absolue";
            case EquipmentEffectKind.SlimeKnowledgeAfter:
                return "Dégâts Absolus infligés aux Slimes";
            case EquipmentEffectKind.MagicSlimeKnowledgeAfter:
                return "Dégâts Absolus infligés aux Slimes Magiques";
            case EquipmentEffectKind.SpiderKnowledgeAfter:
                return "Dégâts Absolus infligés aux Araignées";
            case EquipmentEffectKind.BatKnowledgeAfter:
                return "Dégâts Absolus infligés aux Chauve-Souris";
            case EquipmentEffectKind.FairyKnowledgeAfter:
                return "Dégâts Absolus infligés aux Fées";
            case EquipmentEffectKind.FoxKnowledgeAfter:
                return "Dégâts Absolus infligés aux Renards";
            case EquipmentEffectKind.DevilFishKnowledgeAfter:
                return "Dégâts Absolus infligés aux Poissons Démons";
            case EquipmentEffectKind.TreantKnowledgeAfter:
                return "Dégâts Absolus infligés aux Tréants";
            case EquipmentEffectKind.FlameTigerKnowledgeAfter:
                return "Dégâts Absolus infligés aux Tigres de Feu";
            case EquipmentEffectKind.UnicornKnowledgeAfter:
                return "Dégâts Absolus infligés aux Licornes";
            case EquipmentEffectKind.ChallengeBossKnowledgeAfter:
                return "Dégâts Absolus infligés aux Boss de Défi";
            case EquipmentEffectKind.SDDamageMultiplier:
                return "Multiplicateur de Dégâts dans un SD";
            case EquipmentEffectKind.SDDamageCutMultiplier:
                return "Multiplicateur de Réduction de Dégâts dans un SD";
            case EquipmentEffectKind.FameGain:
                return "Gain de Renommée";
            case EquipmentEffectKind.DungeonCoinGain:
                return "Gain de Pièce de Donjon";
            case EquipmentEffectKind.ExtraAfterDamage:
                return "Dégâts Absolus Supplémentaires";
        }
        return base.EquipmentEffectName(kind);
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
                if (value < 0) tempString = "PV <color=red>" + tDigit(value, 1) + "</color>";
                else tempString = "PV + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.MPAdder:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "PM <color=red>" + tDigit(value, 1) + "</color>";
                else tempString = "PM + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.ATKAdder:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "ATQ <color=red>" + tDigit(value, 1) + "</color>";
                else tempString = "ATQ + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.MATKAdder:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "MATQ <color=red>" + tDigit(value, 1) + "</color>";
                else tempString = "MATQ + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.DEFAdder:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "DEF <color=red>" + tDigit(value, 1) + "</color>";
                else tempString = "DEF + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.MDEFAdder:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "MDEF <color=red>" + tDigit(value, 1) + "</color>";
                else tempString = "MDEF + " + tDigit(value, 1);
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
                if (value < 0) tempString = "PV <color=red>" + percent(value, 1) + "</color>";
                else tempString = "PV + " + percent(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MPMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "PM <color=red>" + percent(value, 1) + "</color>";
                else tempString = "PM + " + percent(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ATKMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "ATQ <color=red>" + percent(value, 1) + "</color>";
                else tempString = "ATQ + " + percent(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MATKMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "MATQ <color=red>" + percent(value, 1) + "</color>";
                else tempString = "MATQ + " + percent(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DEFMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "DEF <color=red>" + percent(value, 1) + "</color>";
                else tempString = "DEF + " + percent(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MDEFMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "MDEF <color=red>" + percent(value, 1) + "</color>";
                else tempString = "MDEF + " + percent(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ATKPropotion:
                if (isOnlyEffectValue) return percent(value);
                tempString = "ATQ + " + percent(value) + " du Niveau du Héros";
                if (value < 0) tempString = "ATQ <color=red>" + percent(value) + "</color> du Niveau du Héros";
                else tempString = "ATQ + " + percent(value) + " du Niveau du Héros";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MATKPropotion:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "MATQ <color=red>" + percent(value) + "</color> du Niveau du Héros";
                else tempString = "MATQ + " + percent(value) + " du Niveau du Héros";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DEFPropotion:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "DEF <color=red>" + percent(value) + "</color> du Niveau du Héros";
                else tempString = "DEF + " + percent(value) + " du Niveau du Héros";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MDEFPropotion:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "MDEF <color=red>" + percent(value) + "</color> du Niveau du Héros";
                else tempString = "MDEF + " + percent(value) + " du Niveau du Héros";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FireResistance:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Résistance au Feu <color=red>" + percent(value) + "</color>";
                else tempString = "Résistance au Feu + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.IceResistance:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Résistance à la Glace <color=red>" + percent(value) + "</color>";
                else tempString = "Résistance à la Glace + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ThunderResistance:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Résistance à l'Electricité <color=red>" + percent(value) + "</color>";
                else tempString = "Résistance à l'Electricité + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LightResistance:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Résistance à la Lumière <color=red>" + percent(value) + "</color>";
                else tempString = "Résistance à la Lumière + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DarkResistance:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Résistance aux Ténèbres <color=red>" + percent(value) + "</color>";
                else tempString = "Résistance aux Ténèbres + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PhysicalAbsorption:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Absorption Physique <color=red>" + percent(value) + "</color> des dégâts reçus";
                else tempString = "Absorption Physique + " + percent(value) + " des dégâts reçus";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FireAbsorption:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Absorption du Feu <color=red>" + percent(value) + "</color> des dégâts reçus";
                else tempString = "Absorption du Feu + " + percent(value) + " des dégâts reçus";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.IceAbsorption:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Absorption de la Glace <color=red>" + percent(value) + "</color> des dégâts reçus";
                else tempString = "Absorption de la Glace + " + percent(value) + " des dégâts reçus";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ThunderAbsorption:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Absorption de l'Electricité <color=red>" + percent(value) + "</color> des dégâts reçus";
                else tempString = "Absorption de l'Electricité + " + percent(value) + " des dégâts reçus";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LightAbsorption:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Absorption de la Lumière <color=red>" + percent(value) + "</color> des dégâts reçus";
                else tempString = "Absorption de la Lumière + " + percent(value) + " des dégâts reçus";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DarkAbsorption:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Absorption des Ténèbres <color=red>" + percent(value) + "</color> des dégâts reçus";
                else tempString = "Absorption des Ténèbres + " + percent(value) + " des dégâts reçus";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DebuffResistance:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Résistance aux Débuffs <color=red> " + percent(value) + "</color>";
                else tempString = "Résistance aux Débuffs + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PhysicalCritical:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Chance de Coup Critique Physique <color=red> " + percent(value) + "</color>";
                else tempString = "Chance de Coup Critique Physique + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MagicalCritical:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Chance de Coup Critique Magique <color=red> " + percent(value) + "</color>";
                else tempString = "Chance de Coup Critique Magique + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.EXPGain:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain d'EXP <color=red>" + percent(value) + "</color>";
                else tempString = "Gain d'EXP + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.SkillProficiency:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain de Maîtrise de Capacité <color=red>" + percent(value) + "</color>";
                else tempString = "Gain de Maîtrise de Capacité + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.EquipmentProficiency:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain de Maîtrise d'Équipement <color=red>" + percent(value) + "</color>";
                else tempString = "Gain de Maîtrise d'Équipement + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MoveSpeedAdder:
                if (isOnlyEffectValue) return meter(value);
                if (value < 0) tempString = "Vitesse de Déplacement <color=red>" + meter(value) + " / sec</color>";
                else tempString = "Vitesse de Déplacement + " + meter(value) + " / sec";
                if (perLevelValue > 0) tempString += " ( + " + meter(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MoveSpeedMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Vitesse de Déplacement <color=red>" + percent(value) + "</color>";
                else tempString = "Vitesse de Déplacement + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.GoldGain:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain d'Or (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Gain d'Or (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.StoneGain:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain de Pierre (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Gain de Pierre (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.CrystalGain:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain de Cristal (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Gain de Cristal (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LeafGain:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain de Feuille (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Gain de Feuille (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.WarriorSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "Niveau des Capacités du Guerrier (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Niveau des Capacités du Guerrier (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.WizardSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "Niveau des Capacités de la Mage (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Niveau des Capacités de la Mage (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.AngelSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "Niveau des Capacités de l'Ange (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Niveau des Capacités de l'Ange (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.ThiefSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "Niveau des Capacités du Voleur (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Niveau des Capacités du Voleur (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.ArcherSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "Niveau des Capacités de l'Archer (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Niveau des Capacités de l'Archer (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.TamerSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "Niveau des Capacités de la Dompteuse (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Niveau des Capacités de la Dompteuse (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.AllSkillLevel:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "Niveau de Toutes les Capacités (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Niveau de Toutes les Capacités (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.SlimeKnowledge:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts infligés aux Slimes <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts infligés aux Slimes + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MagicSlimeKnowledge:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts infligés aux Slimes Magiques <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts infligés aux Slimes Magiques + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.SpiderKnowledge:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts infligés aux Araignées <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts infligés aux Araignées + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.BatKnowledge:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts infligés aux Chauve-Souris <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts infligés aux Chauve-Souris + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FairyKnowledge:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts infligés aux Fées <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts infligés aux Fées + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FoxKnowledge:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts infligés aux Renards <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts infligés aux Renards + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DevilFishKnowledge:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts infligés aux Poissons Démons <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts infligés aux Poissons Démons + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.TreantKnowledge:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts infligés aux Tréants <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts infligés aux Tréants + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FlameTigerKnowledge:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts infligés aux Tigres de Feu <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts infligés aux Tigres de Feu + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.UnicornKnowledge:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts infligés aux Licornes <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts infligés aux Licornes + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PhysicalDamage:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts Physiques <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts Physiques + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FireDamage:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts de Feu <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts de Feu + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.IceDamage:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts de Glace <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts de Glace + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ThunderDamage:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts d'Electricité <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts d'Electricité + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LightDamage:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts de Lumière <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts de Lumière + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DarkDamage:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts des Ténèbres <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts des Ténèbres + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.EquipmentDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Chance d'Apparition d'Équipement <color=red>" + percent(value) + "</color>";
                else tempString = "Chance d'Apparition d'Équipement + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 4) + " / Nv )";
                break;
            case EquipmentEffectKind.SlimeDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Chance d'Apparition d'" + Material(MaterialKind.OilOfSlime) + " (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Chance d'Apparition d'" + Material(MaterialKind.OilOfSlime) + " (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.MagicSlimeDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Chance d'Apparition de " + Material(MaterialKind.EnchantedCloth) + " (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Chance d'Apparition de " + Material(MaterialKind.EnchantedCloth) + " (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.SpiderDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Chance d'Apparition de " + Material(MaterialKind.SpiderSilk) + " (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Chance d'Apparition de " + Material(MaterialKind.SpiderSilk) + " (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.BatDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Chance d'Apparition d'" + Material(MaterialKind.BatWing) + " (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Chance d'Apparition d'" + Material(MaterialKind.BatWing) + " (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.FairyDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Chance d'Apparition de " + Material(MaterialKind.FairyDust) + " (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Chance d'Apparition de " + Material(MaterialKind.FairyDust) + " (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.FoxDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Chance d'Apparition de " + Material(MaterialKind.FoxTail) + " (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Chance d'Apparition de " + Material(MaterialKind.FoxTail) + " (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.DevilFishDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Chance d'Apparition d'" + Material(MaterialKind.FishScales) + " (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Chance d'Apparition d'" + Material(MaterialKind.FishScales) + " (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.TreantDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Chance d'Apparition de " + Material(MaterialKind.CarvedBranch) + " (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Chance d'Apparition de " + Material(MaterialKind.CarvedBranch) + " (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.FlameTigerDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Chance d'Apparition de " + Material(MaterialKind.ThickFur) + " (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Chance d'Apparition de " + Material(MaterialKind.ThickFur) + " (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.UnicornDropChance:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Chance d'Apparition de " + Material(MaterialKind.UnicornHorn) + " (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Chance d'Apparition de " + Material(MaterialKind.UnicornHorn) + " (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.ColorMaterialDropChance:
                if (isOnlyEffectValue) return percent(value, 4);
                tempString = "Chance d'Apparition de Matériaux Rares (Global) + " + percent(value, 4);
                if (value < 0) tempString = "Chance d'Apparition de Matériaux Rares (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Chance d'Apparition de Matériaux Rares (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 4) + " / Nv )";
                break;
            case EquipmentEffectKind.HpRegen:
                if (isOnlyEffectValue) return tDigit(value, 2);
                if (value < 0) tempString = "Régénération de PV <color=red>" + tDigit(value, 2) + "</color> / sec";
                else tempString = "Régénération de PV + " + tDigit(value, 2) + " / sec";
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.MpRegen:
                if (isOnlyEffectValue) return tDigit(value, 2);
                if (value < 0) tempString = "Régénération de PM <color=red>" + tDigit(value, 2) + "</color> / sec";
                else tempString = "Régénération de PM + " + tDigit(value, 2) + " / sec";
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.TamingPoint:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain de Points de Domptage <color=red>" + percent(value) + "</color>";
                else tempString = "Gain de Points de Domptage + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PetEXPGain:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain d'EXP des Familiers <color=red>" + percent(value) + "</color>";
                else tempString = "Gain d'EXP des Familiers + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LoyaltyPointGain:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain de Points de Loyauté <color=red>" + percent(value) + "</color>";
                else tempString = "Gain de Points de Loyauté + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.WarriorSkillRange:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Portée des Capacités du Guerrier <color=red>" + percent(value) + "</color>";
                else tempString = "Portée des Capacités du Guerrier + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.WizardSkillRange:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Portée des Capacités de la Mage <color=red>" + percent(value) + "</color>";
                else tempString = "Portée des Capacités de la Mage + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.AngelSkillRange:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Portée des Capacités de l'Ange <color=red>" + percent(value) + "</color>";
                else tempString = "Portée des Capacités de l'Ange + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.ThiefSkillRange:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Portée des Capacités du Voleur <color=red>" + percent(value) + "</color>";
                else tempString = "Portée des Capacités du Voleur + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.ArcherSkillRange:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Portée des Capacités de l'Archer <color=red>" + percent(value) + "</color>";
                else tempString = "Portée des Capacités de l'Archer + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.TamerSkillRange:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Portée des Capacités de la Dompteuse <color=red>" + percent(value) + "</color>";
                else tempString = "Portée des Capacités de la Dompteuse + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.WarriorSkillEffectRange:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Portée des Effets des Capacités du Guerrier <color=red>" + percent(value) + "</color>";
                else tempString = "Portée des Effets des Capacités du Guerrier + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.WizardSkillEffectRange:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Portée des Effets des Capacités de la Mage <color=red>" + percent(value) + "</color>";
                else tempString = "Portée des Effets des Capacités de la Mage + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.AngelSkillEffectRange:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Portée des Effets des Capacités de l'Ange <color=red>" + percent(value) + "</color>";
                else tempString = "Portée des Effets des Capacités de l'Ange + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.ThiefSkillEffectRange:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Portée des Effets des Capacités du Voleur <color=red>" + percent(value) + "</color>";
                else tempString = "Portée des Effets des Capacités du Voleur + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.ArcherSkillEffectRange:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Portée des Effets des Capacités de l'Archer <color=red>" + percent(value) + "</color>";
                else tempString = "Portée des Effets des Capacités de l'Archer + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.TamerSkillEffectRange:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Portée des Effets des Capacités de la Dompteuse <color=red>" + percent(value) + "</color>";
                else tempString = "Portée des Effets des Capacités de la Dompteuse + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.TownMatGain:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain de Matériaux de Ville <color=red>" + percent(value) + "</color>";
                else tempString = "Gain de Matériaux de Ville + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.TownMatAreaClearGain:
                if (isOnlyEffectValue) return tDigit(value, 1);
                if (value < 0) tempString = "Gain de Matériaux de Ville à travers la Complétion d'une Zone <color=red>" + percent(value) + "</color>";
                else tempString = "Gain de Matériaux de Ville à travers la Complétion d'une Zone + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            //case EquipmentEffectKind.TownMatDungeonRewardGain:
            //    if (value < 0) tempString = "Gain de Matériaux de Ville à travers la Complétion d'un Donjon <color=red>" + percent(value) + "</color>";
            //    else           tempString = "Gain de Matériaux de Ville à travers la Complétion d'un Donjon + " + percent(value);
            //    if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
            //    break;
            case EquipmentEffectKind.RebirthPointGain1:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain de Points de Réincarnation de Classe 1 <color=red>" + percent(value) + "</color>";
                else tempString = "Gain de Points de Réincarnation de Classe 1 + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.RebirthPointGain2:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain de Points de Réincarnation de Classe 2 <color=red>" + percent(value) + "</color>";
                else tempString = "Gain de Points de Réincarnation de Classe 2 + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.RebirthPointGain3:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Gain de Points de Réincarnation de Classe 3 <color=red>" + percent(value) + "</color>";
                else tempString = "Gain de Points de Réincarnation de Classe 3 + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.CriticalDamage:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts des Coups Critiques <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts des Coups Critiques + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.BlessingEffect:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Effet des Bénédictions <color=red>" + percent(value) + "</color>";
                else tempString = "Effet des Bénédictions + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.CatalystDoubleCriticalChance:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Chance de Catalysation Critique <color=red>" + percent(value) + "</color>";
                else tempString = "Chance de Catalysation Critique + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.HpRegenMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Régénération de PV / sec <color=red>" + percent(value, 3) + "</color> des PV Max";
                else tempString = "Régénération de PV / sec + " + percent(value, 3) + " des PV Max";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.MpRegenMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Régénération de PM / sec <color=red>" + percent(value, 3) + "</color> des PV Max";
                else tempString = "Régénération de PM / sec + " + percent(value, 3) + " des PV Max";
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.ArmoredFury:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Furie d'Armure <color=red>" + percent(value, 3) + "</color>";
                else tempString = "Furie d'Armure + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.WardedFury:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Furie d'Esprit <color=red>" + percent(value, 3) + "</color>";
                else tempString = "Furie d'Esprit + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.PetPhysicalCriticalChance:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Chance de Coup Critique Physique de Familier <color=red>" + percent(value) + "</color>";
                else tempString = "Chance de Coup Critique Physique de Familier + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PetMagicalCriticalChance:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Chance de Coup Critique Magique des Familiers <color=red>" + percent(value) + "</color>";
                else tempString = "Chance de Coup Critique Magique des Familiers + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PetCriticalDamage:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts Critiques des Familiers <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts Critiques des Familiers + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PetDebuffResistance:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Résistance aux Débuffs des Familiers <color=red>" + percent(value) + "</color>";
                else tempString = "Résistance aux Débuffs des Familiers + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.StoneTownResearchPower:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Pouvoir de Recherche de Pierre (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Pouvoir de Recherche de Pierre (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.CrystalTownResearchPower:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Pouvoir de Recherche de Crystal (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Pouvoir de Recherche de Crystal (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LeafTownResearchPower:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Pouvoir de Recherche de Feuille (Global) <color=red>" + percent(value) + "</color>";
                else tempString = "Pouvoir de Recherche de Feuille (Global) + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.GuildEXPGain:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Gain d'EXP de Guilde <color=red>" + percent(value, 3) + "</color>";
                else tempString = "Gain d'EXP de Guilde + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.SPDMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "VIT <color=red>" + percent(value, 3) + "</color>";
                else tempString = "VIT + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.CriticalDamageMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Dégâts Critiques <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Dégâts Critiques x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.SkillProficiencyMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Gain de Maîtrise de Capacité <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Gain de Maîtrise de Capacité x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.EquipmentProficiencyMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Gain de Maîtrise d'Équipement <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Gain de Maîtrise d'Équipement x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.EXPGainMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Gain d'EXP <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Gain d'EXP x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.GoldGainMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Gain d'Or <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Gain d'Or x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.PhysicalDamageMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Dégâts Physiques <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Dégâts Physiques x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.FireDamageMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Dégâts de Feu <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Dégâts de Feu x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.IceDamageMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Dégâts de Glace <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Dégâts de Glace x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.ThunderDamageMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Dégâts d'Electricité <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Dégâts d'Electricité x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.LightDamageMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Dégâts de Lumière <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Dégâts de Lumière x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.DarkDamageMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Dégâts des Ténèbres <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Dégâts des Ténèbres x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.TamingPointMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                tempString = "Multiplicative Taming Point Gain + " + percent(value, 3);
                if (value < 0) tempString = "Gain de Points de Domptage <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Gain de Points de Domptage x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.PetEXPGainMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Gain d'EXP de Familier <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Gain d'EXP de Familier x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.LoyaltyPointGainMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Gain de Points de Loyauté <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Gain de Points de Loyauté x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.BlessingEffectMultiplier:
                if (isOnlyEffectValue) return percent(value, 3);
                if (value < 0) tempString = "Effet de Bénédiction <color=red>x" + percent(value, 3) + "</color>";
                else tempString = "Effet de Bénédiction x" + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.PhysicalCriticalMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Chance Critique Physique <color=red>x" + percent(value) + "</color>";
                else tempString = "Chance Critique Physique x" + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MagicalCriticalMultiplier:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Chance Critique Magique <color=red>x" + percent(value) + "</color>";
                else tempString = "Chance Critique Magique x" + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ChallengeBossKnowledge:
                if (isOnlyEffectValue) return percent(value);
                if (value < 0) tempString = "Dégâts infligés aux Boss de Défi <color=red>" + percent(value) + "</color>";
                else tempString = "Dégâts infligés aux Boss de Défi + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.HPAfter:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "PV Absolus + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.MPAfter:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "PM Absolus + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.ATKAfter:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "ATQ Absolue + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.MATKAfter:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "MATQ Absolue + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.DEFAfter:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "DEF Absolue + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.MDEFAfter:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "MDEF Absolue + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.SPDAfter:
                if (isOnlyEffectValue) return tDigit(value, 1);
                tempString = "VIT Absolue + " + tDigit(value, 1);
                if (perLevelValue > 0) tempString += " ( + " + tDigit(perLevelValue, 2) + " / Nv )";
                break;
            case EquipmentEffectKind.MoveSpeedAfter:
                if (isOnlyEffectValue) return meter(value);
                tempString = "Vitesse de Déplacement Absolue + " + meter(value) + " / sec";
                if (perLevelValue > 0) tempString += " ( + " + meter(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PhysicalCriticalAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Chance Critique Physique Absolue + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MagicalCriticalAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Chance Critique Magique Absolue + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.CriticalDamageAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Critiques Absolus + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DebuffResistanceAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Résistance aux Débuffs Absolue + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.PhysicalDamageAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Physiques Absolus + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FireDamageAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts de Feu Absolus + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.IceDamageAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts de Glace Absolus + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ThunderDamageAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts d'Electricité Absolus + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LightDamageAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts de Lumière Absolus + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DarkDamageAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts des Ténèbres Absolus + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FireResistanceAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "After Fire Résistance au Feu Absolue + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.IceResistanceAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Résistance à la Glace Absolue + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ThunderResistanceAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Résistance à l'Electricité Absolue + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.LightResistanceAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Résistance à la Lumière Absolue + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DarkResistanceAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Résistance aux Ténèbres Absolue + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.SlimeKnowledgeAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Absolus infligés aux Slimes + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.MagicSlimeKnowledgeAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Absolus infligés aux Slimes Magiques + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.SpiderKnowledgeAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Absolus infligés aux Araignées + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.BatKnowledgeAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Absolus infligés aux Chauve-Souris + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FairyKnowledgeAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Absolus infligés aux Fées + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FoxKnowledgeAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Absolus infligés aux Renards + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.DevilFishKnowledgeAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Absolus infligés aux Poissons Démons + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.TreantKnowledgeAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Absolus infligés aux Tréants + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FlameTigerKnowledgeAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Absolus infligés aux Tigres de Feu + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.UnicornKnowledgeAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Absolus infligés aux Licornes + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.ChallengeBossKnowledgeAfter:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Absolus infligés aux Boss de Défi + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.SDDamageMultiplier:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Multiplicateur de Dégâts dans un SD + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.SDDamageCutMultiplier:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Multiplicateur de Réduction de Dégâts dans un SD + " + percent(value);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue) + " / Nv )";
                break;
            case EquipmentEffectKind.FameGain:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain de Renommée + " + percent(value, 3);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 3) + " / Nv )";
                break;
            case EquipmentEffectKind.DungeonCoinGain:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Gain de Pièce de Donjon + " + percent(value, 4);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 4) + " / Nv )";
                break;
            case EquipmentEffectKind.ExtraAfterDamage:
                if (isOnlyEffectValue) return percent(value);
                tempString = "Dégâts Absolus Supplémentaires + " + percent(value, 4);
                if (perLevelValue > 0) tempString += " ( + " + percent(perLevelValue, 4) + " / Nv )";
                break;
            default:
                if (isOnlyEffectValue) return tDigit(value);
                if (value < 0) tempString = kind.ToString() + " <color=red>" + tDigit(value) + "</color>";
                else tempString = kind.ToString() + " + " + tDigit(value);
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
            case EquipmentForgeEffectKind.PurifyCurseEffect:
                return "Purifie " + percent(value) + " de l'Effet Maudit";
            case EquipmentForgeEffectKind.IncreaseEffectIncrement:
                return "Augmentation de l'Effet / Nv + " + percent(value);
        }
        return base.ForgeNameString(kind, value);
    }
    public override string ForgeEffectString(EquipmentForgeEffectKind kind, double value, double maxValue)
    {
        switch (kind)
        {
            case EquipmentForgeEffectKind.ReduceRequiredHeroLevel:
                return "Niveau du Héros requis pour cet équipement - " + tDigit(value) + " (Max : " + tDigit(maxValue) + ")";
            case EquipmentForgeEffectKind.ReduceRequiredAbility:
                return "Points d'Abilité requis pour cet équipement - " + tDigit(value) + " (Max : " + tDigit(maxValue) + ")";
            case EquipmentForgeEffectKind.IncreaseProficiencyGain:
                return "Gain de Maîtrise de cet équipement + " + percent(value) + " (Max : " + tDigit(maxValue) + ")";
            case EquipmentForgeEffectKind.IncreaseEffect:
                return "Effet de cet équipement + " + percent(value) + " (Max : " + tDigit(maxValue) + ")";
            case EquipmentForgeEffectKind.PurifyCurseEffect:
                return "Réduit les effets négatifs de cet équipement par " + percent(value) + " (Max : " + percent(maxValue) + ")";
            case EquipmentForgeEffectKind.IncreaseEffectIncrement:
                return "Effet de cet équipement + " + percent(value) + " par niveau (Max : " + percent(maxValue) + ")";
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
                name = "Chasseur d'Équipement";
                effect = "Chance d'Apparition d'Équipement (sauf Unique) ";
                break;
            case DictionaryUpgradeKind.EnchantedEffectChance1:
                name = "Fortune d'Équipement 1";
                effect = "Chance additionnelle d'avoir un 1er enchantement";
                break;
            case DictionaryUpgradeKind.EnchantedEffectChance2:
                name = "Fortune d'Équipement 2";
                effect = "Chance additionnelle d'avoir un 2ème enchantement";
                break;
            case DictionaryUpgradeKind.EnchantedEffectChance3:
                name = "Fortune d'Équipement 3";
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
        return base.EquipmentPartName(part);
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
        return base.EquipmentRarityName(rarity);
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
        return base.EquipmentSetKindName(kind);
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
            case EnchantKind.OptionDeleteAll:
                return "Parchemin de Suppression Global";
            case EnchantKind.OptionExtractAll:
                return "Parchemin d'Extraction Global";
            case EnchantKind.OptionLotteryAll:
                return "Parchemin de Lotterie Global";
            case EnchantKind.OptionLevelupAll:
                return "Parchemin de Niveau Supérieur Global";
            case EnchantKind.OptionLevelMaxAll:
                return "Parchemin de Niveau Maximal Global";
            case EnchantKind.OptionCopyAll:
                return "Parchemin de Copie Global";
            case EnchantKind.ArtifactOptionAdd:
                return "Parchemin d'Enchantement Antique";
            case EnchantKind.ArtifactDelete:
                return "Parchemin Antique de Suppression";
            case EnchantKind.ArtifactExtract:
                return "Parchemin Antique d'Extraction";
            case EnchantKind.ArtifactLottery:
                return "Parchemin Antique de Lotterie";
            case EnchantKind.ArtifactLevelup:
                return "Parchemin Antique de Niveau Supérieur";
            case EnchantKind.ArtifactLevelMax:
                return "Parchemin Antique de Niveau Maximal";
            case EnchantKind.ArtifactExpandEnchantSlot:
                return "Parchemin Antique d'Expansion";
            case EnchantKind.ArtifactDeleteAll:
                return "Parchemin Antique de Suppression Global";
            case EnchantKind.ArtifactExtractAll:
                return "Parchemin Antique d'Extraction Global";
            case EnchantKind.ArtifactLotteryAll:
                return "Parchemin Antique de Lotterie Global";
            case EnchantKind.ArtifactLevelupAll:
                return "Parchemin Antique de Niveau Supérieur Global";
            case EnchantKind.ArtifactLevelMaxAll:
                return "Parchemin Antique de Niveau Maximal Global";
        }
        return base.EnchantName(kind);
    }
    //EnchantInfo
    public override string EnchantInformation(EnchantKind kind)
    {
        switch (kind)
        {
            case EnchantKind.OptionAdd:
                return "Ajoute un enchantement à un équipement ayant un [Enchantement Vide].";
            case EnchantKind.OptionLevelup:
                return "Augmente le niveau d'un enchantement d'un équipement qui n'est pas au niveau maximal.";
            case EnchantKind.OptionLevelMax:
                return "Augmente le niveau d'un enchantement d'un équipement jusqu'à son maximum.";
            case EnchantKind.OptionLottery:
                return "Randomise la valeur d'un enchantement d'un équipement.";
            case EnchantKind.OptionDelete:
                return "Supprime un enchantement d'un équipement et le transforme en un [Enchantement Vide].";
            case EnchantKind.OptionExtract:
                return "Extrait un enchantement d'un équipement et créée un Parchemin d'Enchantement associé. L'effet extrait est supprimé de l'équipement.";
            case EnchantKind.OptionCopy:
                return "Copie l'enchantement d'un équipement et créée un Parchemin d'Enchantement associé. L'enchantement originel est gardé.";
            case EnchantKind.ExpandEnchantSlot:
                return "Augmente le nombre d'enchantements d'un équipement par 1. Max 4 emplacements en tout en dehors de l'Effet de Maîtrise du Voleur.";
            case EnchantKind.InstantProf:
                return "Gagne instantanément de la Maîtrise sur cet équipement pour le héros couramment joué.";
            case EnchantKind.ForgeAdd:
                return "Donne un effet forgé à un équipement ayant un emplacement [Forge Disponible] ou le même type d'effet forgé.";
            case EnchantKind.ForgeDelete:
                return "Supprime un effet forgé d'un équipement et le remplace par un emplacement [Forge Disponible].";
            case EnchantKind.ForgeExtract:
                return "Extrait l'effet forgé d'un équipement et créée son [Enclume de Forge] associé. L'effet forgé extrait est supprimé de l'équipement.";
            case EnchantKind.OptionDeleteAll:
                return "Supprime tous les enchantements d'un équipement et les transforme en [Enchantement Vide]s.";
            case EnchantKind.OptionExtractAll:
                return "Extrait tous les enchantements d'un équipement et créée des Parchemins d'Enchantement associés. Les effets extraits sont supprimés de l'équipement.";
            case EnchantKind.OptionLotteryAll:
                return "Randomise les valeurs de tous les enchantements d'un équipement.";
            case EnchantKind.OptionLevelupAll:
                return "Augmente le niveau de tous les enchantements d'un équipement qui ne sont pas à leur niveau maximal.";
            case EnchantKind.OptionLevelMaxAll:
                return "Augmente le niveau de tous les enchantements d'un équipement jusqu'à leur maximum.";
            case EnchantKind.OptionCopyAll:
                return "Copie tous les enchantements d'un équipement et créée des Parchemins d'Enchantement associés. Les enchantements originels sont gardés.";
            case EnchantKind.ArtifactOptionAdd:
                return "Ajoute un enchantement de SD à un équipement ayant un [Enchantement Vide].";
            case EnchantKind.ArtifactDelete:
                return "Supprime un enchantement de SD d'une antiquité et le transforme en un [Enchantement Vide].";
            case EnchantKind.ArtifactExtract:
                return "Extrait un enchantement de SD d'une antiquité et créée un Parchemin Antique d'Enchantement associé. L'effet extrait est supprimé de l'antiquité.";
            case EnchantKind.ArtifactLottery:
                return "Randomise la valeur d'un enchantement de SD d'une antiquité.";
            case EnchantKind.ArtifactLevelup:
                return "Augmente le niveau d'un enchantement de SD d'une antiquité qui n'est pas au niveau maximal.";
            case EnchantKind.ArtifactLevelMax:
                return "Augmente le niveau d'un enchantement de SD d'une antiquité jusqu'à son maximum.";
            case EnchantKind.ArtifactExpandEnchantSlot:
                return "Augmente le nombre d'enchantements d'une antiquité par 1. Max 4 emplacements en tout en dehors de l'Effet de Maîtrise du Voleur.";
            case EnchantKind.ArtifactDeleteAll:
                return "Supprime tous les enchantements de SD d'une antiquité et les transforme en [Enchantement Vide]s.";
            case EnchantKind.ArtifactExtractAll:
                return "Extrait tous les enchantements de SD d'une antiquité et créée des Parchemins Antiques d'Enchantement associés. Les effets extraits sont supprimés de l'antiquité.";
            case EnchantKind.ArtifactLotteryAll:
                return "Randomise les valeurs de tous les enchantements de SD d'une antiquité.";
            case EnchantKind.ArtifactLevelupAll:
                return "Augmente le niveau de tous les enchantements de SD d'une antiquité qui ne sont pas à leur niveau maximal.";
            case EnchantKind.ArtifactLevelMaxAll:
                return "Augmente le niveau de tous les enchantements de SD d'une antiquité jusqu'à leur maximum.";
        }
        return base.EnchantInformation(kind);
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
                tempName = "Catalyseur de Slime";
                break;
            case CatalystKind.Mana:
                tempName = "Catalyseur de Mana";
                break;
            case CatalystKind.Frost:
                tempName = "Catalyseur du Froid";
                break;
            case CatalystKind.Flame:
                tempName = "Catalyseur de la Flamme";
                break;
            case CatalystKind.Storm:
                tempName = "Catalyseur de la Tempête";
                break;
            case CatalystKind.Soul:
                tempName = "Catalyseur de l'Âme";
                break;
            case CatalystKind.Sun:
                tempName = "Catalyseur du Soleil";
                break;
            case CatalystKind.Void:
                tempName = "Catalyseur du Vide";
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
        return base.EssenceName(kind);
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
                return "Charme de Vie";
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
        return base.AlchemyUpgradeName(kind);
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
                return "Catalyseurs disponibles + " + tDigit(effectValue);
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
        return base.AlchemyUpgradeEffect(kind, effectValue);
    }

    //Potion
    public override string PotionName(PotionKind kind)
    {
        switch (kind)
        {
            case PotionKind.MinorHealthPotion:
                return "Potion de Santé Mineure";
            case PotionKind.MinorRegenerationPoultice:
                return "Bandage de Régénération Mineure";
            case PotionKind.MinorResourcePoultice:
                return "Bandage de Ressouces Mineure";
            case PotionKind.SlickShoeSolution:
                return "Solution pour Chaussures Glissantes";
            case PotionKind.MinorManaRegenerationPoultice:
                return "Bandage de Régénération de Mana Mineure";
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
                return "Poupée Aranetta";
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
            case PotionKind.TrackersMap:
                return "Carte du Traqueur";
            case PotionKind.BerserkersStone:
                return "Pierre de Berserker";
            case PotionKind.AncientSlimeBadge:
                return "Badge Slime Antique";
            case PotionKind.AncientMagicslimeBadge:
                return "Badge Slime Magique Antique";
            case PotionKind.AncientSpiderBadge:
                return "Badge Araignée Antique";
            case PotionKind.AncientBatBadge:
                return "Badge Chauve-Souris Antique";
            case PotionKind.AncientFairyBadge:
                return "Badge Fée Antique";
            case PotionKind.AncientFoxBadge:
                return "Badge Renard Antique";
            case PotionKind.AncientDevilfishBadge:
                return "Badge Poisson Démon Antique";
            case PotionKind.AncientTreantBadge:
                return "Badge Tréant Antique";
            case PotionKind.AncientFlametigerBadge:
                return "Badge Tigre de Feu Antique";
            case PotionKind.AncientUnicornBadge:
                return "Badge Licorne Antique";
        }
        return base.PotionName(kind);
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
        return base.PotionConsume(kind, chance);
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
                return optStr + "Gain de Ressources (Global) + " + percent(effectValue) + "</color>";
            case PotionKind.SlickShoeSolution:
                return optStr + "Vitesse de Déplacement + " + percent(effectValue) + "</color>";
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
                return optStr + "Gain d'Or (Global) + " + percent(effectValue) + "</color>";
            case PotionKind.SlickerShoeSolution:
                return optStr + "Vitesse de Déplacement + " + percent(effectValue) + "</color>";
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
                if (isPassive) return "Multiplie les Gains de Maîtrise d'Équipement par " + percent(1 + effectValue);
                return "Si les dégâts reçus sont égaux ou en dessous de " + percent(System.Math.Min(0.25d, effectValue)) + " des PV, ils sont nullifiés (Max : 25%)";
            case PotionKind.NostroDoll:
                if (isPassive) return "Absorption Physique + " + percent(effectValue);
                return "Augmente la Régénération de PM / sec par " + percent(effectValue) + " des PM max";
            case PotionKind.LadyEmeldaDoll:
                if (isPassive) return "Absorption Magique + " + percent(effectValue);
                return "Dégâts des Capacités infligeant des dégâts + " + percent(effectValue) + " mais leur Consommation de PM + " + percent(4 * effectValue);
            case PotionKind.NariSuneDoll:
                if (isPassive) return "Chance de Grosse Invasion + " + percent(effectValue) + " au lieu d'une Invasion Normale";
                return "Portée des Capacités + " + percent(effectValue);
            case PotionKind.OctobaddieDoll:
                if (isPassive) return "Gain de Pièces Slime + " + percent(effectValue);
                return "Zone d'Effet des Capacités + " + percent(effectValue);
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
                return "Vitesse de Déplacement + " + percent(effectValue);
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
            case PotionKind.EnchantedAlembic:
                if (isPassive) return "Gain d'Eau Mystérieuse + " + tDigit(effectValue, 3) + " / " + Basic(BasicWord.Sec);
                return "Effet de Potion (Global) + " + percent(effectValue);
            case PotionKind.TrackersMap:
                if (isPassive) return "Chance d'Invasion Épique + " + percent(effectValue) + " au lieu d'une Grosse Invasion";
                return "Augmente le # de Complétions de Zone et de Récompense de Zone par " + tDigit(effectValue, 1);
            case PotionKind.BerserkersStone:
                if (isPassive) return "Effet de l'Équipement + " + percent(effectValue);
                return "Dégâts infligés aux Boss de Défi + " + percent(effectValue);
            case PotionKind.AncientSlimeBadge:
                if (isPassive) return "Dégâts Absolus infligés aux Slimes + " + percent(effectValue);
                return "Multiplicateur de Dégâts infligés aux Slimes + " + percent(effectValue);
            case PotionKind.AncientMagicslimeBadge:
                if (isPassive) return "Dégâts Absolus infligés aux Slimes Magiques + " + percent(effectValue);
                return "Multiplicateur de Dégâts infligés aux Slimes Magiques + " + percent(effectValue);
            case PotionKind.AncientSpiderBadge:
                if (isPassive) return "Dégâts Absolus infligés aux Araignées + " + percent(effectValue);
                return "Multiplicateur de Dégâts infligés aux Araignées + " + percent(effectValue);
            case PotionKind.AncientBatBadge:
                if (isPassive) return "Dégâts Absolus infligés aux Chauve-Souris + " + percent(effectValue);
                return "Multiplicateur de Dégâts infligés aux Chauve-Souris + " + percent(effectValue);
            case PotionKind.AncientFairyBadge:
                if (isPassive) return "Dégâts Absolus infligés aux Fées + " + percent(effectValue);
                return "Multiplicateur de Dégâts infligés aux Fées + " + percent(effectValue);
            case PotionKind.AncientFoxBadge:
                if (isPassive) return "Dégâts Absolus infligés aux Renards + " + percent(effectValue);
                return "Multiplicateur de Dégâts infligés aux Renards + " + percent(effectValue);
            case PotionKind.AncientDevilfishBadge:
                if (isPassive) return "Dégâts Absolus infligés aux Poissons Démons + " + percent(effectValue);
                return "Multiplicateur de Dégâts infligés aux Poissons Démons + " + percent(effectValue);
            case PotionKind.AncientTreantBadge:
                if (isPassive) return "Dégâts Absolus infligés aux Tréant + " + percent(effectValue);
                return "Multiplicateur de Dégâts infligés aux Tréant + " + percent(effectValue);
            case PotionKind.AncientFlametigerBadge:
                if (isPassive) return "Dégâts Absolus infligés aux Tigres de Feu + " + percent(effectValue);
                return "Multiplicateur de Dégâts infligés aux Tigres de Feu + " + percent(effectValue);
            case PotionKind.AncientUnicornBadge:
                if (isPassive) return "Dégâts Absolus infligés aux Licornes + " + percent(effectValue);
                return "Multiplicateur de Dégâts infligés aux Licornes + " + percent(effectValue);
        }
        return base.PotionEffect(kind, effectValue);
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
        return base.PotionType(type);
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
        return base.TalismanRarity(rarity);
    }

    //SkillName
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
        return base.SkillNameWarrior(kind);
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
        return base.SkillNameWizard(kind);
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
                return "Bénédiction des Dieux";
            case SkillKindAngel.MuscleInflation:
                return "Gonflement de Muscle";
            case SkillKindAngel.MagicImpact:
                return "Impact Magique";
            case SkillKindAngel.ProtectWall:
                return "Mur de Protection";
            case SkillKindAngel.Haste:
                return "Célérité Accrue";
            case SkillKindAngel.WingStorm:
                return "Tempête de Plumes";
            case SkillKindAngel.HolyArch:
                return "Arche Sainte";
        }
        return base.SkillNameAngel(kind);
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
                return "Coup de l'Ombre";
            case SkillKindThief.SneakyStrike:
                return "Coup Furtif";
            case SkillKindThief.Pilfer:
                return "Chapardage";
            case SkillKindThief.DarkWield:
                return "Maniement Ténébreux";
            case SkillKindThief.Assassination:
                return "Assassinat";
        }
        return base.SkillNameThief(kind);
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
        return base.SkillNameArcher(kind);
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
            case SkillKindTamer.FeedChilli:
                return "Donner du Chili";
            case SkillKindTamer.BreedingKnowledge:
                return "Connaissance en Domptage";
            case SkillKindTamer.TuneOfTotalTaming:
                return "Mélodie de Domptage Total";
        }
        return base.SkillNameTamer(kind);
    }
    public override string SkillDescriptionWarrior(SkillKindWarrior kind)
    {
        switch (kind)
        {
            case SkillKindWarrior.SwordAttack:
                return "Un coût d'épée rapide qui inflique peu de dégâts à une seule cible.";
            case SkillKindWarrior.Slash:
                return "Délivre une attaque tranchante qui touche une fois.";
            case SkillKindWarrior.DoubleSlash:
                return "Effectue deux attaques à l'épée rapides à la suite, infligeant des dégâts modérés.";
            case SkillKindWarrior.SonicSlash:
                return "Délivre une ruée de coups d'épée rapides qui infligent plusieurs coups ayant des dégâts modérés.";
            case SkillKindWarrior.SwingDown:
                return "Effectue un tranchage de haut en bas qui inflige d'importants dégâts à une seule cible tout en réduisant son ATQ.";
            case SkillKindWarrior.SwingAround:
                return "Effectue une attaque à l'épée de grande envergure dans un arc, effectuant des dégâts modérés à tous les ennemis en face. ";
            case SkillKindWarrior.ChargeSwing:
                return "Charge une attaque puissante qui infligent des dégâts massifs à un seul ennemi tout en réduisant son MATQ.";
            case SkillKindWarrior.FanSwing:
                return "Délivre une attaque à l'épée tourbillonante, touchant tous les ennemis autour du héros plusieurs fois.";
            case SkillKindWarrior.ShieldAttack:
                return "Cours à toute vitesse vers l'ennemi cible pour l'attaquer.";
            case SkillKindWarrior.KnockingShot:
                return "Délivre une attaque à dégâts modérés qui pousse grandement les ennemis qui l'ont subi.";
        }
        return kind.ToString();
    }
    public override string SkillDescriptionWizard(SkillKindWizard kind)
    {
        switch (kind)
        {
            case SkillKindWizard.StaffAttack:
                return "Une attaque debâton simple qui inflige des dégâts de feu à une cible à distance faible.";
            case SkillKindWizard.FireBolt:
                return "Lance une boule de feu qui explose à l'impact, infligeant des dégâts de feu à une cible.";
            case SkillKindWizard.FireStorm:
                return "Invoque un cercle de feu autour du héros, infligeant des dégâts de feu à tous les ennemis à sa portée.";
            case SkillKindWizard.MeteorStrike:
                return "Invoque un météore enflammé qui s'abat sur la zone cible, infligeant d'énormes dégâts à tous les ennemis dans sa zone d'effet.";
            case SkillKindWizard.IceBolt:
                return "Lance une boule glacial qui inflige des dégâts de glace à une cible et réduit sa VIT.";
            case SkillKindWizard.ChillingTouch:
                return "Frappe un ennemi proche à l'aide d'un toucher glacial qui inflige des dégâts de glace et a une chance de le geler sur place.";
            case SkillKindWizard.Blizzard:
                return "Invoque un blizzard qui affecte une grosse aire et inflige des dégâts de glace à tous les ennemis qui y sont, réduisant leur VIT.";
            case SkillKindWizard.ThunderBolt:
                return "Lance une boule électrique à portée longue qui inflige des dégâts d'électricité à une seule cible, ayant une chance d'augmenter les dégâts qu'elle recevra par la suite.";
            case SkillKindWizard.DoubleThunderBolt:
                return "Lance deux boules électriques qui frappent la cible deux fois, infligeant des dégâts électriques ainsi qu'un débuff qui augmente les dégâts qu'elle recevra par la suite.";
            case SkillKindWizard.LightningThunder:
                return "Appelle un tonnerre puissant qui applique des dégâts d'électricité à tous les ennemis à sa portée.";
        }
        return kind.ToString();
    }
    public override string SkillDescriptionAngel(SkillKindAngel kind)
    {
        switch (kind)
        {
            case SkillKindAngel.WingAttack:
                return "Une attaque d'aile qui inflige des dégâts physiques à plusieurs ennemis à la portée du héros.";
            case SkillKindAngel.WingShoot:
                return "Lance une volée de plumes vers les ennemis, infligeant des dégâts de lumière aux cibles à portée.";
            case SkillKindAngel.Heal:
                return "Régénère une portion de la santé du héros.";
            case SkillKindAngel.GodBless:
                return "Octroie une bénédiction au héros, renforçant leur PV maximums.";
            case SkillKindAngel.MuscleInflation:
                return "Insuffle les muscles du héros avec du pouvoir, augmentant leur ATQ.";
            case SkillKindAngel.MagicImpact:
                return "Invoque une vague d'énergie magique, augmentant la MATQ du héros.";
            case SkillKindAngel.ProtectWall:
                return "Dresse une barrière protectrice qui augmente la DEF et la MDEF du héros.";
            case SkillKindAngel.Haste:
                return "Octroie le don de la vitesse au héros, aumgentant leur VIT.";
            case SkillKindAngel.WingStorm:
                return "Lance un ouragan dévastateur infligeant des dégâts de lumière, endommageant tous les ennemis dans une petite zone d'effet, tout en pouvant les repousser.";
            case SkillKindAngel.HolyArch:
                return "Entre en communication avec un pouvoir divin pour augmenter l'apprentissage des capacités du héros, sauf celle-ci.";
        }
        return kind.ToString();
    }
    public override string SkillDescriptionThief(SkillKindThief kind)
    {
        switch (kind)
        {
            case SkillKindThief.DaggerAttack:
                return "Effectue une attaque physique basique avec une dague.";
            case SkillKindThief.Stab:
                return "Coups de poignard rapides et précis avec une dague.";
            case SkillKindThief.KnifeToss:
                return "Lance une dague pointue vers l'ennemi, infligeant des dégâts.";
            case SkillKindThief.LuckyBlow:
                return "Lancer de dague de courte portée qui a une chance de coup critique élevée, ce qui inflige de gros dégâts en un seul coup.";
            case SkillKindThief.SpreadToss:
                return "Lance plusieurs dagues dans un cercle autour du héros, touchant des ennemis dans différentes directions.";
            case SkillKindThief.ShadowStrike:
                return "Endommage des ennemis avec un attaque infligeant des dégâts des ténèbres, ayant une chance d'appliquer du poison qui inflige des dégâts des ténèbres additionnels au fil du temps.";
            case SkillKindThief.SneakyStrike:
                return "Disparait et réapparait à côté de l'ennemi le plus éloigné pour infliger des dégâts.";
            case SkillKindThief.Pilfer:
                return "Utilise la fourberie pour voler du butin commun, tout en infligeant un peu de dégâts des ténèbres.";
            case SkillKindThief.DarkWield:
                return "Exploite le pouvoir des ténèbres et exécute une attaque dans un arc avec votre dague en face de vous.";
            case SkillKindThief.Assassination:
                return "Utilise votre habileté pour délivrer un coup mortel des ténèbres, qui a une chance d'instantanément éliminer un ennemi ayant en dessous de 50% de ses PV.";
        }
        return kind.ToString();
    }
    public override string SkillDescriptionArcher(SkillKindArcher kind)
    {
        switch (kind)
        {
            case SkillKindArcher.ArrowAttak:
                return "Lance une attaque physique basique en tirant une flèche sur un ennemi.";
            case SkillKindArcher.PiercingArrow:
                return "Tire une flèche qui transperce les ennemis, infligeant des dégâts à toutes les cibles touchées par la flèche.";
            case SkillKindArcher.BurstArrow:
                return "Tire plusieurs flèches à la suite pour infliger des dégâts physiques aux ennemis.";
            case SkillKindArcher.Multishot:
                return "Tire plusieurs flèches qui ciblent tous les ennemis sur le champ de bataille.";
            case SkillKindArcher.ShockArrow:
                return "Tire une flèche infligeant des Dégâts d'Electricité qui a une chance de réduire la résistance à l'électricité de l'ennemi.";
            case SkillKindArcher.FrozenArrow:
                return "Tire une flèche infligeant des Dégâts de Glace qui passe au travers des ennemis, visant l'ennemi le plus éloigné, et qui a une chance de réduire la résistance à la glace de l'ennemi.";
            case SkillKindArcher.ExplodingArrow:
                return "Tire une flèche ayant une zone d'effet moyenne infligeant des Dégâts de Feu qui a une chance de réduire la résistance au feu des ennemis à sa portée.";
            case SkillKindArcher.ShiningArrow:
                return "Tire plusieurs flèches infligeant des Dégâts de Lumière qui commence en cercle avant de converger vers le centre du champ de bataille, qui ont une chance de réduire la résistance à la lumière de l'ennemi.";
            case SkillKindArcher.GravityArrow:
                return "Tire une flèche infligeant des Dégâts des Ténèbres qui a une chance de réduire la résistance aux ténèbres de l'ennemi tout en attirant tout ennemi à portée vers le centre du champ de bataille.";
            case SkillKindArcher.Kiting:
                return "Rase les bords du champ de bataille afin de se déplacer en dehors de la portée physique des ennemis tout en ayant un bonus de Vitesse en mode Déplacement Auto.";
        }
        return kind.ToString();
    }
    public override string SkillDescriptionTamer(SkillKindTamer kind)
    {
        switch (kind)
        {
            case SkillKindTamer.SonnetAttack:
                return "Lance une attaque basique infligeant des Dégâts de Lumière qui permet d'invoquer des familiers pour qu'ils se battent avec vous.";
            case SkillKindTamer.AttackingOrder:
                return "Ordonne aux familiers invoqués d'attaquer, augmentant leurs multiplicateurs de dégâts.";
            case SkillKindTamer.RushOrder:
                return "Ordonne aux familiers invoqués de se ruer sur des ennemis aléatoires, augmentant leurs multiplicateurs de dégâts.";
            case SkillKindTamer.DefensiveOrder:
                return "Ordonne aux faliliers invoqués de rester proche du Héros pour le protéger et attaquer des ennemis proches, augmentant leurs multiplicateurs de dégâts.";
            case SkillKindTamer.SoothingBallad:
                return "Joue une mélodie qui soigne les familiers invoqués.";
            case SkillKindTamer.OdeOfFriendship:
                return "Permet aux familiers invoqués d'utiliser les capacités provenant de la barre de capacités du héros à travers une mélodie musicale.";
            case SkillKindTamer.AnthemOfEnthusiasm:
                return "Imprègne les familiers invoqués avec une meilleure force et des pouvoirs magiques, augmentant leur ATQ% et leur MATQ%.";
            case SkillKindTamer.FeedChilli:
                return "Donne du chili épicé aux familiers invoqués, ce qui augmente leur vitesse de déplacement et leur attaque, tout en les coloriant en rouge.";
            case SkillKindTamer.BreedingKnowledge:
                return "Augmente les gains d'EXP des familiers invoqués, ce qui les aide à se développer.";
            case SkillKindTamer.TuneOfTotalTaming:
                return "Joue une mélodie magique qui ensorcelle les monstres cibles, donnant la possibiité de les capturer et de les transformer en familiers loyaux.";
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
        return base.SkillEffect(effect);
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
                return "CEL";
            case Buff.MoveSpeedUp:
                return "Vitesse de Déplacement";
            case Buff.GoldUp:
                return "Gain d'Or";
            case Buff.SkillLevelUp:
                return "Niveau de Capacité";
        }
        return base.BuffName(kind);
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
                return "Réduction de CEL";
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
        return base.DebuffName(kind);
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
                return "Imitation";
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
        return base.GuildAbilityName(kind);
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
                return "Inventaire d'Enchantement + " + tDigit(effectValue);
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
                return "Réduction du Coût des Améliorations Générales par " + percent(effectValue);
            case GuildAbilityKind.MaterialDrop:
                return "Gain de Matériaux + " + tDigit(effectValue);
            case GuildAbilityKind.NitroCap:
                return "Limite de Nitro + " + tDigit(effectValue);
            case GuildAbilityKind.GoldCap:
                return "Multiplication de la Limite d'Or par " + percent(1 + effectValue);
            case GuildAbilityKind.GoldGain:
                return "Multiplication des Gains d'Or par " + percent(1 + effectValue);
            case GuildAbilityKind.ExpGain:
                return "Multiplication des Gains d'EXP par " + percent(1 + effectValue);
        }
        return tempString;
    }
    public override string DailyQuestRarityName(DailyQuestRarity rarity)
    {
        switch (rarity)
        {
            case DailyQuestRarity.Common:
                return "Commune";
            case DailyQuestRarity.Uncommon:
                return "Peu Commune";
            case DailyQuestRarity.Rare:
                return "Rare";
            case DailyQuestRarity.SuperRare:
                return "Super Rare";
            case DailyQuestRarity.Epic:
                return "Épique";
        }
        return DailyQuestRarityName(rarity);
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
                        name = "Tutoriel 1 : Entraînement Basique";
                        client = "Hitan";
                        description = "Bienvenue sur Incrmental Epic Hero 2 ! Tout d'abord, pour devenir plus fort, assigne 1 <color=orange>Point d'Abilité (PA)</color> à <color=orange>VTL</color>. VTL est l'abilité la plus basique, qui augmente tes PV, DEF et MDEF. Tu gagneras 1 AP à chaque fois que ton niveau augmente. \n<color=yellow>- Pour plus d'informations sur les points d'abilité, clique sur le bouton d'Aide en haut à gauche > [Abilité].</color>";
                        condition = "Assigner 1 PA à VTL";
                        break;
                    case QuestKindGlobal.ClearGeneralQuest:
                        name = "Tutoriel 2 : Quête Générale";
                        client = "Hitan";
                        description = "Il y a quatre types de quêtes : <color=orange>Globale</color>, <color=orange>Journalière</color>, <color=orange>Titre</color> et <color=orange>Générale</color>. Les Quêtes Globales sont l'histoire principale du jeu et progressent pour chaque membre de la guilde. Les Quêtes Générales et de Titre ne concernent que le héros courant. Essaye de compléter la première <color=orange>Quête Générale</color> !\n<color=yellow>- Pour plus d'informations sur les quêtes, clique sur le bouton d'Aide en haut à gauche > [Quête].</color>";
                        condition = "Compléter la première Quête Générale";
                        reward = "Débloque l'onglet [ Capacité ]";
                        break;
                    case QuestKindGlobal.ClearTitleQuest:
                        name = "Tutoriel 3 : Quête de Titre";
                        client = "Hitan";
                        description = "Bien joué ! Les <color=orange>Quêtes de Titre</color> sont des quêtes spéciales qui donnent accès à des Titres une fois complétées. Ces titres ont des effets uniques. Essaye de compléter la première Quête de Titre ! Garde en tête que tu ne peux accepter que 3 quêtes au maximum en comptant les Quêtes Générales et les Quêtes de Titre. Tu pourras augmenter cette limite plus loin dans le jeu. Les Quêtes Globales et Journalières ne sont pas affectées par cette limite.\n<color=yellow>- Pour plus d'informations sur les quêtes, clique sur le bouton d'Aide en haut à gauche > [Quête].</color>";
                        condition = "Compléter la première Quête de Titre";
                        reward = "Débloque l'onglet [ Amélioration ]";
                        break;
                    case QuestKindGlobal.UpgradeResource:
                        name = "Tutoriel 4 : Amélioration";
                        client = "Hitan";
                        description = "Dans l'onglet <color=orange>Amélioration</color>, tu peux acheter différentes améliorations avec de l'or pour augmenter tes statistiques ! Essaye d'acheter des améliorations de <color=orange>Gain de Ressources</color> !\n<color=yellow>- Pour plus d'informations sur les améliorations, cliquez sur le bouton d'Aide en haut à gauche > [Amélioration].</color>";
                        condition = "Atteindre le Nv 25 avec [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 2 ]\n- Débloque l'onglet d'Amélioration Générale 2\n- Débloque l'onglet [ Équipement ]";
                        break;
                    case QuestKindGlobal.Equip:
                        name = "Tutoriel 5 : Équipement";
                        client = "Hitan";
                        description = "Lorsque tu combattras des monstres, il y a une chance mince qu'il lâchent un <color=orange>Équipement</color> après être vaincu. Lorsque tu en récupères un, amène-le à moi s'il te plaît ! Tu peux l'équiper en le glissant-déposant dans un emplacement d'équipement libre dans l'onglet color=orange>Équipement</color>." +
                            " Une fois que tu en récupères un, va voir le <color=orange>Dictionnaire</color> dans l'onglet Équipement. Il affichera tous les équipements rencontrés jusqu'à présent ! Tu peux aussi voir qu'ils y a quelques améliorations. Elles augmentent les <color=orange>Gains de Maîtrise d'Équipement</color> des héros, qui réduit le temps requis pour augmenter le niveau d'un équipement.\n<color=yellow>- Pour plus d'informations sur les Équipements et le Dictionnaire, clique sur le bouton d'Aide en haut à gauche > [Équipement].</color>";
                        condition = "Collecte un Équipement";
                        reward = "Débloque l'onglet [ Labo ]";
                        break;
                    case QuestKindGlobal.Alchemy:
                        name = "Tutoriel 6 : Alchimie";
                        client = "Hitan";
                        description = optStr + "Lorsque tu étais en mission, un membre de la guilde a trouvé de l'<color=orange>Eau Mystérieuse</color> et a mis en place un <color=orange>Laboratoire</color>. Tu la rencontrera bien vite, mais pour le moment, essayons de voir ça. Oh, tu ne connais pas l'alchimie ? Laisse-moi t'expliquer."
                            + " Pour alchimiser, tu dois d'abord aller au Laboratoire et créer un Catalyseur. Pour créer ton premier catalyseur, tu dois récupérer de l'<color=orange>Huile de Slime</color> ainsi que <color=orange>3 Eaux Mystérieuses</color> et les utiliser pour créer un <color=orange>Catalyseur Slime</color>. Après cela, tu devras créer une essence."
                            + " Les Essences sont les ingrédients bruts utilisés pour créer des potions. Pour commencer, tu dois verser au moins 0.1 Eau Mystérieuse sur l'essence d'un catalyseur sélectionné afin qu'il commence à produire de l'essence. Essayons cela avec l'<color=orange>Essence de Slime</color>."
                            + " Une fois terminé, il suffit d'aller dans l'onglet <color=orange>[Potion]</color>, et de cliquer sur l'icône de la potion que tu veux fabriquer. Simple, n'est-ce pas ?"
                            + " Maintenant, va expérimenter dans le Laboratoire et n'oublie pas d'augmenter la Limite d'Eau Mystérieuse, de raffiner tes Catalyseurs, et d'améliorer ton labo avec les points d'alchimie reçus.\n<color=yellow>- Pour plus d'informations, Aide > [Labo].</color>";
                        condition = "Produire une " + PotionName(PotionKind.MinorHealthPotion);
                        reward = "Bénédiction de Gain d'EXP (Durée de 15 mins)\n- Débloque les onglets [ Guilde ] & [ Bestiaire ]";
                        break;
                    case QuestKindGlobal.Guild:
                        name = "Tutoriel 7 : Guilde";
                        client = "Hitan";
                        description = "Pour augmenter la liste de membres de la guilde, <color=orange>atteins le Nv de Guilde 5 !</color> Tu pourras ensuite choisir une nouvelle héroïne, la Mage. Tu peux aussi acquérir des abilités variées dans l'onglet guilde. L'EXP de Guilde est gagné à travers la montée de niveau des héros, ce qui donne accès à des points d'abilité de guilde à dépenser." +
                            "\n- Pour commencer, chacun des héros travaille indépendemment, mais au fur et à mesure du jeu, ils apprendront à coopérer. L'abilité de guilde <color=orange>Imitation</color> te donne un <color=orange>Emplacement de Capacité Global</color>, qui permet à un héros d'un peu modifier leur style de jeu en équipant une capacité apprise par un autre héros. Tu devras sans doute ajuste la <color=orange>Portée de Combat</color> du héros pour qu'il se déplace assez près pour utiliser la capacité qui a été empruntée." +
                            "\n<color=yellow>- Pour plus d'informations, Aide > [Guilde].</color>";
                        condition = "Nv de Guilde 5";
                        reward = "Débloque les onglets [ Ville ] & [ Magasin ]";
                        break;
                    case QuestKindGlobal.Town:
                        name = "Tutoriel 8 : Ville";
                        client = "Hitan";
                        description = optStr + "Maintenant, tu peux aller dans l'onglet <color=orange>Ville</color>." +
                            " Il y a plusieurs bâtiments dans la ville." +
                            " Tu peux améliorer les bâtiments à l'aide de Matériaux de Ville que tu gagnes à chaque fois qu'une zone est complétée ( tu peux le voir dans les infos de la zone )." +
                            " Les Donjons donnents des Matériaux de Ville lorsqu'ils sont complétés." +
                            " Tout comme les capacités, les bâtiments ont un Rang et un Niveau. La limite de niveau augmente par 20 pour chaque rang." +
                            " Pour mieux comprendre, <color=orange>augmentons le niveau du Cartographeur jusqu'au niveau 5.</color>" +
                            " Tu pourras ensuite accéder à une nouvelle région du monde !\n<color=yellow>- Pour plus d'informations, Aide > [Ville].</color>"
                            ;
                        condition = "Atteindre le Nv 5 pour le Bâtiment [ Cartographeur ]";
                        reward = "Bénédiction de Gain d'EXP (Durée 30 mins)";
                        break;
                    case QuestKindGlobal.Research:
                        name = "Tutoriel 9 : Recherche de Ville";
                        client = "Hitan";
                        description = optStr + "Tant que tu es dans la ville, chaque bâtiment a trois différents <color=orange>effets recherchables</color>. Tu peux augmenter la vitesse de recherche en gagnant les ressources associées. <color=orange>Recherchons la Recherche de Feuille du Cartographeur. Celle-ci augmente le nombre de Matériaux de Ville lâchés pour chaque complétion de zone</color>, ce qui est très utile pour ramasser plus de matériaux de ville pour augmenter le niveau des bâtiments dans la ville !\n<color=yellow>- Pour plus d'informations, Aide > [Ville].</color>"
                            ;
                        condition = "Atteindre le Nv 1 de la Recherche de Feuille du Cartographeur";
                        reward = "Bénédiction de Gain d'Or (Durée 30 mins)\n-Débloque l'onglet [ Réincarnation ]";
                        break;
                    case QuestKindGlobal.Rebirth:
                        name = "Tutoriel 10 : Réincarnation";
                        client = "Hitan";
                        description = optStr + "Il est maintenant temps de se <color=orange>Réincarner</color>. Il existe plusieures classes de réincarnation. Pour le moment, essayons d'en faire une de Classe 1. <color=orange>Atteins le Niveau 100 avec un des Héros</color> et clique sur l'onglet Réincarnation, puis sur 'Réincarnation'." +
                            " N'oublie pas d'acheter des améliorations après la réincarnation, surtout <color=orange>Expérience Innée</color>. \n<color=yellow>- Pour plus d'informations, Aide > [Réincarnation].</color>"; ;
                        condition = "Effectue une Réincarnation de Classe 1 avec n'importe quel héros";
                        reward = "Bénédiction de Gain d'EXP (Durée 30 mins)\n- Débloque l'onglet [ Défi ]";
                        break;
                    case QuestKindGlobal.Challenge:
                        name = "Tutoriel 11 : Défi";
                        client = "Hitan";
                        description = optStr + "Oh, on dirait qu'un horrible monstre est apparu ! Va dans l'onglet <color=orange>Défi</color> pour vaincre <color=orange>Florzporbe</color>." +
                            " Dans un Combat de Raid de Boss, tous les héros couramment actifs vont rejoindre le combat." +
                            " Comme tu t'es réincarné, tu peux recevoir le titre Preuve de Réincarnation à travers sa quête, ce qui permet d'activer le héos en arrière-plan." +
                            " Le monstre boss est très puissant, donc regroupe les membres actifs de la guilde pour combattre ensemble et prépare-toi bien avant le combat !\n<color=yellow>- Pour plus d'informations, Aide > [Défi].</color>";
                        condition = "Complète le Combat de Raid de Boss [ Florzporbe Nv 100 ]";
                        reward = "Débloque l'onglet [ Expédition ]\n- Débloque l'Auto Ajouteur de Point d'Abilité";
                        break;
                    case QuestKindGlobal.Expedition:
                        name = "Tutoriel 12 : Expédition";
                        client = "Hitan";
                        description = optStr + "Tu as débloqué la possibilité d'envoyer tes familiers dans une expédition ! Si tu vas dans l'onglet Expédition, tu pourras choisir quels familiers ajouter dans ta première équipe d'expédition. Après ça, tu peux choisir l'expédition en cliquant sur la liste déroulante et en choisissant l'une des expéditions pour acquérir des matériaux de ville. Choisis une durée et clique sur Commencer. Reviens sur cet onglet lorsque ta première expédition sera complétée !\n<color=yellow>- Pour plus d'informations, Aide > [Expédition].</color>";
                        condition = "Complète n'importe quelle expédition";
                        reward = "Débloque l'onglet [ Ascension Monde ]\n- Débloque 1 Equipe d'Expédition";
                        break;
                    case QuestKindGlobal.WorldAscension:
                        name = "Tutoriel 13 : Ascension Monde";
                        client = "Hitan";
                        description = optStr + "Ok, le prochain tutoriel est... hein ? Tu penses que ce tutoriel est trop long ? Allons, ce n'est que le début de ce jeu. Excitant, non ?" +
                            " Cependant, atteindre le prochain objectif, l'<color=orange>Ascension Monde</color>, te prendra du temps. Essaye de compléter les paliers dans l'onglet Ascension Monde et effectue une Ascension Monde. Certains aspects du monde seront réinitialisés, ce qui te permettra de progresser encore plus vite par la suite." +
                            " À toi de choisir quand effectuer l'Ascension Monde !\n<color=yellow>- Pour plus d'informations, Aide > [Ascension Monde].</color>";
                        condition = "Effectue une Ascension Monde de Classe 1";
                        reward = "Emplacement d'Inventaire d'Équipement + 10\n- Emplacement d'Inventaire d'Enchantement + 5\n- Emplacement d'Inventaire d'Utilitaire + 5";
                        break;
                    case QuestKindGlobal.AreaPrestige:
                        name = "Tutoriel 14 : Prestige de Zone";
                        client = "Hitan";
                        description = optStr + "Bravo ! Après une Ascension Monde, chaque zone du monde a aussi la possibilité d'avoir un prestige. Tu peux gagner des <color=orange>Points de Prestige de Zone</color> dépendant du # de complétions de la zone. Tu peux voir le prochain # de complétions pour gagner des points dans les infos de la zone." +
                            " Une fois que le niveau de l'amélioration <color=orange>[ Prestige de Zone ]</color> est augmenté, tu peux changer la difficulté de la zone. La chance d'apparition de l'équipement unique de la zone et la récompense de sa complétion augmente avec la difficulté, tandis que le niveau des monstres et le # de vagues à compléter augmente aussi." +
                            " Tu peux aussi compléter les mêmes missions de la zone dans les différentes difficultés, donc tu peux aussi gagner plus de Pièces Épiques et augmenter le Nombre de Missions de Zone complétées.\n<color=yellow>- Pour plus d'informations, Aide > [Carte Monde].</color>";
                        condition = "Atteindre le Nv 1 de l'Amélioration de Zone [ Prestige de Zone ] de la Zone 1 du " + AreaName(AreaKind.SlimeVillage);
                        break;

                    //Upgrade
                    case QuestKindGlobal.Upgrade1:
                        name = "Meilleure Collecte 1";
                        client = "Yuni";
                        description = "Tu sais, les Ressources telles que les pierres bleues sont utiles pour augmenter le rang des capacités et pour augmenter la limite d'or. Tu peux augmenter le gain de ressources dans l'onglet Amélioration. Pour recevoir des ressources plus efficacement, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 50 !";
                        condition = "Atteindre le Nv 50 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 3 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade2:
                        name = "Meilleure Collecte 2";
                        client = "Yuni";
                        description = "Bon travail ! Pour continuer, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 100 !";
                        condition = "Atteindre le Nv 100 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 4 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade3:
                        name = "Meilleure Collecte 3";
                        client = "Yuni";
                        description = "Bien joué ! Pour continuer, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 150 !";
                        condition = "Atteindre le Nv 150 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 5 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade4:
                        name = "Meilleure Collecte 4";
                        client = "Yuni";
                        description = "Très bon travail ! Pour continuer, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 200 !";
                        condition = "Atteindre le Nv 200 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 6 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade5:
                        name = "Meilleure Collecte 5";
                        client = "Yuni";
                        description = "Super travail ! Pour continuer, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 250 !";
                        condition = "Atteindre le Nv 250 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 7 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade6:
                        name = "Meilleure Collecte 6";
                        description = "Quel effort ! Pour continuer, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 300 !";
                        client = "Yuni";
                        condition = "Atteindre le Nv 300 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 8 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade7:
                        name = "Meilleure Collecte 7";
                        client = "Yuni";
                        description = "Parfait ! Pour continuer, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 400 !";
                        condition = "Atteindre le Nv 400 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 9 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade8:
                        name = "Meilleure Collecte 8";
                        client = "Yuni";
                        description = "Magnifique ! Pour continuer, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 500 !";
                        condition = "Atteindre le Nv 500 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 10 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade9:
                        name = "Meilleure Collecte 9";
                        client = "Yuni";
                        description = "Formidable ! Pour continuer, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 600 !";
                        condition = "Atteindre le Nv 600 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 11 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade10:
                        name = "Meilleure Collecte 10";
                        client = "Yuni";
                        description = "Fantastique ! Pour continuer, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 700 !";
                        condition = "Atteindre le Nv 700 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 12 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade11:
                        name = "Meilleure Collecte 11";
                        client = "Yuni";
                        description = "Quel trvail gargantuesque ! Pour continuer, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 800 !";
                        condition = "Atteindre le Nv 800 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 13 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade12:
                        name = "Meilleure Collecte 12";
                        client = "Yuni";
                        description = "Incroyable ! Pour continuer, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 900 !";
                        condition = "Atteindre le Nv 900 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 14 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade13:
                        name = "Meilleure Collecte 13";
                        client = "Yuni";
                        description = "Quel travail astronomique ! Pour continuer, augmente l'amélioration Gain de Ressources 1 jusqu'au Nv 1000 !";
                        condition = "Atteindre le Nv 1000 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 15 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade14:
                        name = "Meilleure Collecte 14";
                        client = "Yuni";
                        description = "";
                        condition = "Atteindre le Nv 1100 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 16 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade15:
                        name = "Meilleure Collecte 15";
                        client = "Yuni";
                        description = "";
                        condition = "Atteindre le Nv 1250 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 17 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade16:
                        name = "Meilleure Collecte 16";
                        client = "Yuni";
                        description = "";
                        condition = "Atteindre le Nv 1500 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 18 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade17:
                        name = "Meilleure Collecte 17";
                        client = "Yuni";
                        description = "";
                        condition = "Atteindre le Nv 1750 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 19 ]" +
                            "\n- File d'Améliorations + 5";
                        break;
                    case QuestKindGlobal.Upgrade18:
                        name = "Meilleure Collecte 18";
                        client = "Yuni";
                        description = "";
                        condition = "Atteindre le Nv 2000 pour l'Amélioration [ Gain de Ressources 1 ]";
                        reward = "Débloque l'Amélioration [ Gain de Ressources 20 ]" +
                            "\n- File d'Améliorations + 5";
                        break;

                    case QuestKindGlobal.Nitro1:
                        name = "Fan de Nitro 1";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "Qu'est-ce qu'il y a ? Pourquoi tu m'interromps ? Tu vois pas que je suis occupé, là ? Oh, tu es curieux à propos de la Nitro, c'est ça ? Est-ce que tu l'as déjà essayée, au moins ? Va et utilise un peu de Nitro (L'icône de TNT en haut de ton écran) avant de revenir me casser les pieds.";
                        condition = "Active le Boosteur de Nitro";
                        break;
                    case QuestKindGlobal.Nitro2:
                        name = "Fan de Nitro 2";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "Qui es-tu ?! Oh, c'est encore toi... T'as essayé la Nitro, c'est ça ? C'est un super truc. Je l'utilise quand j'ai besoin de me concentrer et de terminer la construction de mes contraptions et d'autres trucs, mais je suppose que ça marche aussi pour des aventuriers comme toi. Tiens, reviens me voir une fois que tu en as utilisé 5000 et je te montrerai comment en porter plus.";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / 5000";
                        reward = "Limite de Nitro + 1000";
                        break;
                    case QuestKindGlobal.Nitro3:
                        name = "Fan de Nitro 3";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "Tu vois quelque chose passer en un clin d'oeil dans l'atelier, avant de finalement prendre la forme d'un vieux nain grincheux. \"Qui es-tu et pourquoi es-tu dans mon atelier ?!\" Il ajuste les dix-sept verres de ses étranges lunettes avant de t'examiner à nouveau. \"Oh, salut. Donc tu as utilisé un peu plus de Nitro qu'avant, c'est ça ? Comme tu as pu le voir, j'adore ce truc. Oh, tu veux savoir comment transporter encore plus de Nitro ? Ok, je t'en donnerai une extension une fois que t'en auras utilisé 30 000, ok ? Maintenant va-t'en, j'ai du travail à faire.\"";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(30000);
                        reward = "Limite de Nitro + 2000";
                        break;
                    case QuestKindGlobal.Nitro4:
                        name = "Fan de Nitro 4";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "Une grosse explosion peut être entendue provenant d'un atelier bancal. En regardant à l'intérieur, tu es surpris de voir que le bâtiment n'a aucun signe qu'une explosion vient d'arriver ici. Dès que tu rentres, tu es accueilli par un vieux nain excentrique, visiblement à bout de souffle. \"Fiou, expérience Z17S34.1 a échouée. Excellent, excellent. Alors...\" Il sort la tête de son journal, se bloquant sur un contact visuel avec toi par pur surprise. \"Oh mes stalactites sulfureuses !! Ne surprends pas un homme agé comme ça. Fiou... mon coeur... écoute, si tu es là pour une autre extension de Nitro, va en utiliser " + tDigit(150000) + " de plus et je t'en donnerai une autre. Si t'as rien d'autre à faire, va-t'en.\" Après cela, il t'ignore et continue d'écrire dans son journal.";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(150000);
                        reward = "Limite de Nitro + 3000";
                        break;
                    case QuestKindGlobal.Nitro5:
                        name = "Fan de Nitro 5";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "Aussi vite que tu t'approches de l'atelier du nain, quelque chose passe à toute vitesse à côté de toi, vers l'intérieur du bâtiment. Après cela, il sort en trombe, s'arrêtant juste deux pas en face de toi. \"T'es revenu, à ce que je vois. Désolé, mais personne ne peut visiter mon atelier pour le moment. Je suis sur le point de faire une découverte incoyable ! Si tu veux une autre extension de Nitro, je suis trop occupé pour t'aider, donc dégage.\" Ta tête s'affaisse un peu après avoir entendu ces mots et tu commence à partir. \"D'accord, d'accord. Sois pas comme ça. Va utiliser " + tDigit(500000) + " Nitro et je te donnerai une autre extension. Je peux pas faire ça jusqu'à la nuit des temps, donc n'attends pas d'autres exceptions.\" Il y a un courant d'air bref lorsque la forme du petit nain disparaît, laissant une trainée menant vers l'atelier, terminant avec une fermeture bruyante de la prte de l'atelier.";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(500000);
                        reward = "Limite de Nitro + 4000";
                        break;
                    case QuestKindGlobal.Nitro6:
                        name = "Fan de Nitro 6";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "Tu reviens vers l'atelier du nain, sauf que tout ce que tu trouves est un énorme cratère là où le bâtiment était auparavent. Au centre de celui-ci est assis un nain noir, couvert de cendres, qui a l'air un peu déprimé. Lorsque tu t'approches, il te regarde avec un air un peu embarrassé. \"J'ai réussi. J'ai percé la barrière du Nitro.\" Il essuie une petite larme dans son oeil, étalant les cendres sur son visage déjà sale. \"Donc voilà, le travail de toute ma vie est terminé. aucune idée de ce que je vais faire maintenant. Je suis sûr que t'es là pour une autre extension de Nitro ? D'accord, mais c'est la dernière fois. Je vais bientôt retourner dans ma contrée natale pour faire un rapport de mes trouvailles, et j'espère y trouver de l'inspiration pour commencer une autre projet. Eh bien, qu'est-ce que tu fais encore ici ? Va utiliser " + tDigit(1000000) + " de Nitro et dis-moi quand tu as fini. J'ai encore quelques affaires à régler avant de partir, donc j'attendrai ton retour.\"";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(1000000);
                        reward = "Limite de Nitro + 5000";
                        break;
                    case QuestKindGlobal.Nitro7:
                        name = "Fan de Nitro 7";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "Quelque temps plus tard, en passant à travers la zone où l'atelier du gnome se trouvait autrefois, un autre bâtiment est apparu, juste à côté du cratère que le premier atelier a créé, ressemblant beaucoup à celui-ci. Lorsque tu rentres dans ce bâtiment, à ta surprise, Thuldek t'accueille, visiblement dans une bonne humeur. \"C'est toi ! Une inspiration soudaine m'est venue alors que je revenais vers ma contrée, et je pense avoir une piste pour atteindre une technologie encore plus impressionnante liée à la Nitro, mais j'ai besoin de ton aide ! J'étais en train de bidouiller une extension de Nitro et je pense avoir fait une nouvelle percée dans le milieu. Cependna,t j'ai besoin que quelqu'un teste tout ça avant de déployer ça dans une grande échelle. Si tu peux utiliser " + tDigit(5000000) + " Nitro pour moi, je te laisserai tester ma nouvelle expérience.\" Tu sais que ce ne sera pas une tâche aisée, mais l'opportunité d'être le premier à tester une nouvelle invention est trop bonne pour la passer.";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(5000000);
                        reward = "Limite de Nitro + 6000";
                        break;
                    case QuestKindGlobal.Nitro8:
                        name = "Fan de Nitro 8";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "Une explosion peut être entendue assez près, ton estomac pointant vers l'atelier du nain. Lorsque tu t'y approche, Thuldek s'échappe de l'atelier, auquel il manque une grande partie de son toit. Il te dépasse en un instant et se dirige vers une zone avec un sol ardent proche d'ici. Après avoir récupéré quelque chose dans un morceau de métal fondu, il marche vers toi, murmurant quelque chose. \"Pignons et Cristaux ! Pourquoi est-ce que ça n'a pas marche ? Si j'ajuste la rune thermomagique ça... Oh, qu'est-ce que tu fais ici ?\" Il te regarde pendant un moment avant que ses yeux ne s'agrandissent, pétillant soudainement. \"Oh, bien sûr ! Ca doit être le Relai de la Matrice Pyrokinétique. Toi, t'es celui qui m'a aidé, non ? J'ai besoin que tu utilises plus de Nitro pour moi pour tester la configuration du relai de la matrice. Je dirais que t'as besoin d'avoir utilisé " + tDigit(10000000) + " Nitro pour que je puisse avoir les données dont j'ai besoin. Allons, allons ! Ces données vont pas se collecter par elles-même !\" Tu n'as aucune idée de ce qui vient d'arriver, mais il t'a donné des récompenses dans le passé, donc autant s'y mettre encoure une fois.";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(10000000);
                        reward = "Limite de Nitro + 7000";
                        break;
                    case QuestKindGlobal.Nitro9:
                        name = "Fan de Nitro 9";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(20000000);
                        reward = "Limite de Nitro + 8000";
                        break;
                    case QuestKindGlobal.Nitro10:
                        name = "Fan de Nitro 10";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(30000000);
                        reward = "Limite de Nitro + 9000";
                        break;
                    case QuestKindGlobal.Nitro11:
                        name = "Fan de Nitro 11";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(50000000);
                        reward = "Limite de Nitro + 10000";
                        break;
                    case QuestKindGlobal.Nitro12:
                        name = "Fan de Nitro 12";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(100000000);
                        reward = "Limite de Nitro + 20000";
                        break;
                    case QuestKindGlobal.Nitro13:
                        name = "Fan de Nitro 13";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(300000000);
                        reward = "Limite de Nitro + 30000";
                        break;
                    case QuestKindGlobal.Nitro14:
                        name = "Fan de Nitro 14";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(500000000);
                        reward = "Limite de Nitro + 40000";
                        break;
                    case QuestKindGlobal.Nitro15:
                        name = "Fan de Nitro 15";
                        client = "Thuldek Bricolapat, l'Ingénieur Nain";
                        description = "";
                        condition = "Total de Nitro Consommé : " + tDigit(main.S.nitroConsumed) + " / " + tDigit(1000000000);
                        reward = "Limite de Nitro + 50000";
                        break;

                    case QuestKindGlobal.Capture1:
                        name = "Capture de Monstre 1";
                        client = "Ringold";
                        description = "Dans le <color=orange>Magasin</color>, il y a un onglet dans lequel tu peux trouver tous les types de pièges couramment débloqués. Le premier piège qui est débloqué est le <color=orange>Filet de Capture</color>, qui est SEULEMENT capable de capturer des monstres de <color=orange>Type 'Normal'</color>. Garde aussi en^tête que la <color=orange>Quête de Titre [ Etude de Monstre 1 ]</color> doit aussi être complétée afin de pouvoir utiliser des Pièges. Les Pièges peuvent être équipés dans un <color=orange>Emplacement d'Utilitaire</color>, qui permet d'effectuer un <color=orange>Clic Droit</color> sur un monstre. Tu dois avoir le bon type de piège équipé et un niveau de monstre capturable suffisant afin de pouvoir capturer le monstre choisi.";
                        description += "\n- Tu peux déplacer ta souris sur un piège pour voir le niveau maximum de monstre capturable. Pour augmenter ce niveau, tu peux augmenter le Niveau du Héros, compléter des quêtes de titre Etude de Monstre, et augmenter le niveau d'un bâtiment de ville spécifique.";
                        description += "\n- Les monstres capturés, ou Familiers, donnent une variété de bonus spéciaux qui permettent non seulement d'automatiser certains aspects du jeu, mais aussi de donner des boosts passifs sur de nombreuses statistiques.";
                        description += "\n<color=yellow>Pour plus d'informations, Aide > [Capture].</color>";
                        condition = "# Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(10);
                        reward = "Gain de Points de Domptage + 10%";
                        break;
                    case QuestKindGlobal.Capture2:
                        name = "Capture de Monstre 2";
                        client = "Dirge Suebe, l'Eleveur de Monstres";
                        description = "Eh salut ! T'dois chercher comment entraîner et gérer d'monstrueux, non ? Cherche pas plus loin, j'serais content de t'apprendre ça. D'bord, t'dois avoir un piège. Va au Magasin, achète des pièges et capture des monstrueux, puis reviens me voir. J't'attendrai ici.";
                        condition = "# Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(1000);
                        reward = "Gain de Points de Domptage + 20%";
                        break;
                    case QuestKindGlobal.Capture3:
                        name = "Capture de Monstre 3";
                        client = "Dirge Suebe, l'Eleveur de Monstres";
                        description = "Hé ! T'là ! On d'rait que t'dégoté des pièges et que t'sû les utiliser, c'vrai. T'comme un magicien maintenant ! Comme t'sais t'débrouiller avec l'monstrueux maintenant, et t'vu comment l'faire devenir des animaux d'compagnie tout mimi, eh oui, t'peut-être pu voir que seul un certain nombre peut t'suivre à la fois. T'dois continuer à améliorer l'bâtiment Trappeur ! Oh, et comme on est potes, j't'dirai un petit secret qui t'sera utile. Cherche un monstrueux qui t'aides pour l'capture.";
                        condition = "# Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(10000);
                        reward = "Gain de Points de Domptage + 30%";
                        break;
                    case QuestKindGlobal.Capture4:
                        name = "Capture de Monstre 4";
                        client = "Dirge Suebe, l'Eleveur de Monstres";
                        description = "Eh bien s'lut ! Ce p'ti gars à huit pattes a bien aidé, non ? J'suis sûr que oui ! Maintenant s't'veux faire ça plus sérieusement, t'dois étendre la sélection de pièges dans l'Magasin ! Pour ça y faut réparer le bâtiment Trappeur bien comme il faut, c'vrai. Reviens m'voir quand l'Magasin vend d'pièges pour l'monstrueux rouges !";
                        condition = "# Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(100000)
                            + "\n- Rang 3 pour le Bâtiment de Ville [Trappeur]";
                        reward = "Gain de Points de Domptage + 40%";
                        break;
                    case QuestKindGlobal.Capture5:
                        name = "Capture de Monstre 5";
                        client = "Dirge Suebe, l'Eleveur de Monstres";
                        condition = "# Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(1000000);
                        reward = "Gain de Points de Domptage + 50%";
                        break;
                    case QuestKindGlobal.Capture6:
                        name = "Capture de Monstre 6";
                        client = "Dirge Suebe, l'Eleveur de Monstres";
                        condition = "# Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(10000000);
                        reward = "Gain de Points de Domptage + 75%";
                        break;
                    case QuestKindGlobal.Capture7:
                        name = "Capture de Monstre 7";
                        client = "Dirge Suebe, l'Eleveur de Monstres";
                        condition = "# Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(50000000);
                        reward = "Gain de Points de Domptage + 100%";
                        break;
                    case QuestKindGlobal.Capture8:
                        name = "Capture de Monstre 8";
                        client = "Dirge Suebe, l'Eleveur de Monstres";
                        condition = "# Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(100000000);
                        reward = "Gain de Points de Domptage + 200%";
                        break;
                    case QuestKindGlobal.Capture9:
                        name = "Capture de Monstre 9";
                        client = "Dirge Suebe, l'Eleveur de Monstres";
                        condition = "# Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(300000000);
                        reward = "Gain de Points de Domptage + 300%";
                        break;
                    case QuestKindGlobal.Capture10:
                        name = "Capture de Monstre 10";
                        client = "Dirge Suebe, l'Eleveur de Monstres";
                        condition = "# Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(500000000);
                        reward = "Gain de Points de Domptage + 500%";
                        break;
                    case QuestKindGlobal.Capture11:
                        name = "Capture de Monstre 11";
                        client = "Dirge Suebe, l'Eleveur de Monstres";
                        condition = "# Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(1000000000);
                        reward = "Gain de Points de Domptage + 1000%";
                        break;
                    case QuestKindGlobal.Capture12:
                        name = "Capture de Monstre 12";
                        client = "Dirge Suebe, l'Eleveur de Monstres";
                        condition = "# Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum()) + " / " + tDigit(5000000000);
                        reward = "Gain de Points de Domptage + 5000%";
                        break;

                    case QuestKindGlobal.Alchemy1:
                        name = "Route vers l'Alchimie 1";
                        client = "Archimède, le Vieil Ermite";
                        description = "\"Bonjour et bienvenue dans ma hutte ! Voulez-vous une potion ? ...Oh, vous voulez en savoir plus sur l'alchimie ? Ah, vous avez bien de la chance, car je cherchais justement un apprenti. Pour commencer, allez dans votre laboratoire et... vous n'avez pas de laboratoire, vous dites ? Très bien, utilisez le mien... vous devez sélectionner un catalyseur puis l'essence que vous voulez synthétiser. C'est assez rudimentaire. Une fois que vous avez collecté assez d'essence, vous pouvez commencer à fabriquer des potions ! Les améliorer est nécessaire, donc revenez vers moi après en avoir amélioré quelques unes.\"";
                        description += "\n- Lorsque vous fabriquez des potions, vous gagnez des <color=orange>Points d'Alchimie</color>, qui peuvent être utilisés pour acheter des <color=orange>Améliorations d'Alchimie</color> ou pour améliorer vos potions, ce qui augmentera leur effet et leur valeur de désassemblage. Utilisez ces points pour gagner un nombre cumulatif de 100 niveaux pour passer à la prochaine quête.";
                        description += "\n- Il vous sera utile de passer quelque temps à <color=orange>étendre votre limite d'Eau Mystérieuse</color>, car cela sera nécessaire pour améliorer vos <color=orange>Catalyseurs</color> et pour augmenter votre production d'Eau Mystérieuse.";
                        condition = "Niveau de Potion Total " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 100";
                        reward = "Multiplie la Chance Critique de Catalyseur par 125%";
                        break;
                    case QuestKindGlobal.Alchemy2:
                        name = "Route vers l'Alchimie 2";
                        client = "Archimède, le Vieil Ermite";
                        description = "\"Oh, euh, vous voilà ! J'allais tout juste venir pour voir vos progrès avec l'Alchimie. Il semblerait que vous ayez les bases. Bien, bien, c'est très bien. Maintenant, je vous donne la tâche de continuer cela un peu plus, avant de rentrer dans une partie un peu moins élémentaire.\"";
                        description += "\n- Continuez d'utiliser vos Points d'Alchimie pour monter le niveau de vos potions jusqu'à ce qu'elles atteignent un nombre cumulatif de 200 niveaux de potion.";
                        description += "\n- Il y a une façon plus facile de Désassembler les potions pour des Points d'Alchimie et de l'or. Cherchez votre Bestiaire pour voir quel monstre peut vous aider avec ça.";
                        description += "\n- En utilisant ce familier, faites en sorte de changer le multiplicateur en haut à gauche pendant la fabrication.";
                        condition = "Niveau de Potion Total " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 200";
                        reward = "Limite d'Eau Mystérieuse Max + 100";
                        break;
                    case QuestKindGlobal.Alchemy3:
                        name = "Route vers l'Alchimie 3";
                        client = "Archimède, le Vieil Ermite";
                        description = "\"Eh bien, vous progressez bien plus vite que tous mes anciens élèves. Que c'est merveilleux ! Bien, bien, bien. Ok, maintenant que vous avez maîtrisé les bases, il est temps de tester votre aptitude un peu plus. Oui, continuez d'améliorer vos potions, mais je veux aussi que vous compreniez assez certaines potions pour pouvoir continuer votre formation...\"";
                        description += "\n- Vous devez non seulement atteindre un niveau de potion cumulatif de 300, mais vous devez aussi collecter des matériaux critiques qui peuvent être rarement gagnés lorsqu'une essence est produite.";
                        condition = "Niveau de Potion Total " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 300";
                        reward = "Limite de Niveau de Potion + 25";
                        break;
                    case QuestKindGlobal.Alchemy4:
                        name = "Route vers l'Alchimie 4";
                        client = "Archimède, le Vieil Ermite";
                        description = "\"Ca m'a l'air bon, oui. Vous avez fait un bon travail avec les potions de santé et de ressource. Je suis fier de vous. Maintenant, continuons à aller de l'avant ! J'espère que vous avez découvert les catalyseurs élémentaires de Feu, Glace, et d'Electricité. J'aimerais voir dix de chacun de leur matériaux spéciaux qu'ils produisent de temps en temps lorsque vous synthétisez leurs essences. Cela me permettra de voir que vous avez expérimenté avec ces catalyseurs. De plus, j'en ai besoin pour une potion que je suis en train de développer, donc j'espère que vous ne vous souciez pas qu'on puisse tous deux profiter de cet apprentissage.\"";
                        description += "\n- Vous devez non seulement atteindre un niveau de potion cumulatif de 500, mais vous devez aussi collecter des matériaux critiques qui peuvent être rarement gagnés lorsqu'une essence est produite.";
                        condition = "Niveau de Potion Total " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 500";
                        reward = "Limite de Niveau de Catalyseur + 25";
                        break;
                    case QuestKindGlobal.Alchemy5:
                        name = "Route vers l'Alchimie 5";
                        client = "Archimède, le Vieil Ermite";
                        description = "\"Oh, ceux-ci sont de merveilleux spécimens. Bien joué, mon élève ! Je dois dire qu'ils sont assez rares, comme vous avez sans doute pu le constater, donc faites de votre mieux pour en collecter le plus possible. Au tour de la prochaine tâche. L'apprentissage de l'alchimie est bien plus que juste mixer des potions, vous savez ? C'est aussi l'apprentissage du monde et des substances qui le compose. Bien que basique, l'Eau Mystérieuse, comme vous avez pu le constater, peut être convertie en n'importe quoi tant que vous appliquez vos connaissances à la lettre. Collectez-en une grande quantité, car nous en aurons besoin pour de futures lessons !\"";
                        description += "\n- Vous devez non seulement atteindre un niveau de potion cumulatif de 750, mais vous devez aussi étendre votre limite d'Eau Mystérieuse jusqu'à 300.";
                        condition = "Niveau de Potion Total " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 750\n- Limite d'Eau Mystérieuse " + tDigit(game.alchemyCtrl.mysteriousWaterCap.Value()) + " / 300";
                        reward = "Réduction des coûts de montée de niveau des Catalyseurs par 25%";
                        break;
                    case QuestKindGlobal.Alchemy6:
                        name = "Route vers l'Alchimie 6";
                        client = "Archimède, le Vieil Ermite";
                        description = "\"Vous m'impressionnez toujours avec la vitesse à laquelle vous effectuez les tâches que je vous donne. Vous me rappelez moi-même à mes débuts, maintenant que j'y pense. Bref, remettons-nous y, d'accord ? Voyons voir, vous avez fait ça... ok, et ça aussi... excellent. Très bien, maintenant, j'imerais que vous exploriez les mystères plus profonds de l'alchimie. Collectez 30 Ectoplasmes et dites-moi lorsque vous les avez sur vous.\"";
                        description += "\n- Vous devez non seulement atteindre un niveau de potion cumulatif de 1000, mais vous devez aussi collecter 30 Ectoplasmes pour les donner à Archimède pour continuer.";
                        condition = "Niveau de Potion Total " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 1000";
                        reward = "Multiplication de la Chance Critique de Catalyseur par 125%" +
                            "\n- Limite d'Eau Mystérieuse Max + 250";
                        break;
                    case QuestKindGlobal.Alchemy7:
                        name = "Route vers l'Alchimie 7";
                        client = "Archimède, le Vieil Ermite";
                        description = "\"C'est un miracle, cet Ectoplasme, vraiment. Il ne devrait normalement pas exister, car il appartient à un autre monde, et pourtant le voici. Maintenant, nous allons plonger encore plus profondément, car ce mystère est dépassé par un autre. Maintenant, vous devez collecter l'essence concentrée des étoiles et m'apporter 100 Poussières d'Etoile. Seuls les magiciens les plus puissants ont atteint les étoiles, mais il est parfois possible d'en synthétiser avec un Catalyseur du Soleil. Revenez me voir lorsque vous les avez en votre possession.\"";
                        description += "\n- Vous devez non seulement atteindre un niveau de potion cumulatif de 1500, mais vous devez aussi collecter 100 Poussières d'Etoile pour les donner à Archimède pour continuer.";
                        condition = "Niveau de Potion Total " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 1500";
                        reward = "Limite de Niveau de Potion + 25" +
                            "\n- Limite de Niveau de Catalyseur + 25";
                        break;
                    case QuestKindGlobal.Alchemy8:
                        name = "Route vers l'Alchimie 8";
                        client = "Archimède, le Vieil Ermite";
                        description = "\"Malheureusement, je savais que ce jour arriverait. Vous êtes sur le point d'être diplômé de ma tutelle, donc je vais vous mettre au défi dedécouvrir l'un des derniers secrets de l'Alchimie. Au-delà de notre montre, même au-delà du voile de la réalité lui-même se trouve un royaume seulement connu comme le Vide. Aucune des personnes ne s'y étant aventuré n'en est revenue, mais nous avons trouvé des traces de celui-ci dans d'étranges objets nommés les Oeufs du Vide qui sont parfois laissés après qu'un portail vers le Vide se ferme. Nous avons trouvé comment en synthétiser par nous-mêmes, à travers l'utilisation du Catalyseur du Vide. Pour la dernière fois, je vais devoir vous demander l'en apporter 1000, et je partagerai avec vous les dernières pépites d'information que je peux vous donner.\"";
                        description += "\n- Vous devez non seulement atteindre un niveau de potion cumulatif de 2000, mais vous devez aussi collecter 1000 Oeufs du Vide pour les donner à Archimède.";
                        condition = "Niveau de Potion Total " + tDigit(game.potionCtrl.TotalPotionLevel()) + " / 2000";
                        reward = "Gain de Points d'Alchimie + 100%" +
                            "\n- Réduction des coûts de montée de niveau des Catalyseurs par 25%";
                        break;
                }
                break;
            case QuestKind.Daily:
                switch (kindDaily)
                {
                    case QuestKindDaily.EC1:
                        name = "Pièce Épique 1 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "La Guilde des Aventuriers";
                        description = "La Guilde des Aventuriers a posté une quête " + DailyQuestRarityName(quest.dailyQuestRarity) + " pour vaincre " + tDigit(quest.defeatRequredDefeatNum()) + " " + MonsterSpeciesName(quest.dailyTargetMonsterSpecies) + " qui terrorisent les villageois vivant près de la région " + AreaName(quest.questingArea.kind) + ". Revenez ici lorsque la tâche est complétée.";
                        break;
                    case QuestKindDaily.EC2:
                        name = "Pièce Épique 2 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "L'Association des Trappeurs";
                        description = "L'Association des Trappeurs a posté une quête " + DailyQuestRarityName(quest.dailyQuestRarity) + " pour capturer " + tDigit(quest.captureRequiredNum()) + " " + MonsterSpeciesName(quest.dailyTargetMonsterSpecies) + " pour une analyse et étude approfondie. Revenez ici lorsque la tâche est complétée.";
                        break;
                    case QuestKindDaily.EC3:
                        name = "Pièce Épique 3 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "La Guilde des Aventuriers";
                        description = "La Guilde des Aventuriers a posté une quête " + DailyQuestRarityName(quest.dailyQuestRarity) + " pour vaincre " + tDigit(quest.defeatRequredDefeatNum()) + " " + MonsterSpeciesName(quest.dailyTargetMonsterSpecies) + " qui terrorisent les villageois vivant près de la région " + AreaName(quest.questingArea.kind) + ". Revenez ici lorsque la tâche est complétée.";
                        break;
                    case QuestKindDaily.EC4:
                        name = "Pièce Épique 4 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "L'Association des Trappeurs";
                        description = "L'Association des Trappeurs a posté une quête " + DailyQuestRarityName(quest.dailyQuestRarity) + " pour capturer " + tDigit(quest.captureRequiredNum()) + " " + MonsterSpeciesName(quest.dailyTargetMonsterSpecies) + " pour une analyse et étude approfondie. Revenez ici lorsque la tâche est complétée.";
                        break;
                    case QuestKindDaily.Cartographer1:
                        name = "Cartographeur 1 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "La Conférence des Cartographeurs";
                        description = "La Conférence des Cartographeurs aimerait envoyer quelques cartographeurs dans la région " + AreaName(quest.completeTargetArea.kind) + " pour collecter plus de données et inspecter tout changement dans le paysage ou dans l'écosystème de créatures s'y trouvant. Veuillez les escorter pendant leur travail. Vu que cette quête est " + DailyQuestRarityName(quest.dailyQuestRarity) + ", vous devez donc compléter la zone " + quest.completeTargetArea.Name(true, false) + " au moins " + tDigit(quest.areaRequredCompletedNum()) + " fois avant que les Cartographeurs aient terminé leur tâche.";
                        break;
                    case QuestKindDaily.Cartographer2:
                        name = "Cartographeur 2 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "La Conférence des Cartographeurs";
                        description = "La Conférence des Cartographeurs aimerait envoyer quelques cartographeurs dans la région " + AreaName(quest.completeTargetArea.kind) + " pour collecter plus de données et inspecter tout changement dans le paysage ou dans l'écosystème de créatures s'y trouvant. Veuillez les escorter pendant leur travail. Vu que cette quête est " + DailyQuestRarityName(quest.dailyQuestRarity) + ", vous devez donc compléter la zone " + quest.completeTargetArea.Name(true, false) + " au moins " + tDigit(quest.areaRequredCompletedNum()) + " fois avant que les Cartographeurs aient terminé leur tâche.";
                        break;
                    case QuestKindDaily.Cartographer3:
                        name = "Cartographeur 3 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "La Conférence des Cartographeurs";
                        description = "La Conférence des Cartographeurs aimerait envoyer quelques cartographeurs dans la région " + AreaName(quest.completeTargetArea.kind) + " pour collecter plus de données et inspecter tout changement dans le paysage ou dans l'écosystème de créatures s'y trouvant. Veuillez les escorter pendant leur travail. Vu que cette quête est " + DailyQuestRarityName(quest.dailyQuestRarity) + ", vous devez donc compléter la zone " + quest.completeTargetArea.Name(true, false) + " au moins " + tDigit(quest.areaRequredCompletedNum()) + " fois avant que les Cartographeurs aient terminé leur tâche.";
                        break;
                    case QuestKindDaily.Cartographer4:
                        name = "Cartographeur 4 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "La Conférence des Cartographeurs";
                        description = "La Conférence des Cartographeurs aimerait envoyer quelques cartographeurs dans la région " + AreaName(quest.completeTargetArea.kind) + " pour collecter plus de données et inspecter tout changement dans le paysage ou dans l'écosystème de créatures s'y trouvant. Veuillez les escorter pendant leur travail. Vu que cette quête est " + DailyQuestRarityName(quest.dailyQuestRarity) + ", vous devez donc compléter la zone " + quest.completeTargetArea.Name(true, false) + " au moins " + tDigit(quest.areaRequredCompletedNum()) + " fois avant que les Cartographeurs aient terminé leur tâche.";
                        break;
                    case QuestKindDaily.Cartographer5:
                        name = "Cartographeur 5 : " + DailyQuestRarityName(quest.dailyQuestRarity);
                        client = "La Conférence des Cartographeurs";
                        description = "La Conférence des Cartographeurs aimerait envoyer quelques cartographeurs dans la région " + AreaName(quest.completeTargetArea.kind) + " pour collecter plus de données et inspecter tout changement dans le paysage ou dans l'écosystème de créatures s'y trouvant. Veuillez les escorter pendant leur travail. Vu que cette quête est " + DailyQuestRarityName(quest.dailyQuestRarity) + ", vous devez donc compléter la zone " + quest.completeTargetArea.Name(true, false) + " au moins " + tDigit(quest.areaRequredCompletedNum()) + " fois avant que les Cartographeurs aient terminé leur tâche.";
                        break;

                }
                break;
            case QuestKind.Title:
                switch (kindTitle)
                {
                    case QuestKindTitle.SkillMaster1:
                        name = Title(TitleKind.SkillMaster) + " 1";
                        client = "Gamin Asiatique Condescendant";
                        description = "\"Eh toi ! Le nouveau ! Oui, bien sûr que je te parle à toi, le 'Héros' qui a l'air d'entraîner ses katas de ceinture blanche mais qui oublie toujours la prochaîne étape. Je vois que t'as du potentiel mais c'est seulement parce que j'ai une super bonne vue ! Tu dois d'abord apprendre à marcher avant de courir, donc je te suggère d'entraîner tes coups basiques jusqu'à que tu aies la bonne technique et que tu puisses les lancer instinctivement. Quand tu as fini, reviens vers moi et je te montrerai un double combo facile.\"";
                        description += "\n- Les capacités gagnent de la <color=orange>Maîtrise</color> à chaque fois qu'elles sont utilisées, et elles gagnent des niveaux tout comme votre Héros. Chaque Héros collecte un type de Ressource qui peut être dépensé pour augmenter le <color=orange>Rang des Capacités</color>, ce qui augmente le niveau maximum des Capacités.";
                        description += "\n- La complétion de cette quête donne le Titre <color=orange>Maître de Capacité</color>, donne un <color=orange>Emplacement de Capacité de Classe</color>. Après avoir gagné un nouvel emplacement de Capacité de Classe, vous pouvez cliquer sur l'icône d'une capacité dans l'onglet Capacité pour l'équipper/l'enlever. La Capacité d'Attaque de Base ne peut pas être enlevée.";
                        condition = "Atteindre le Nv 7 avec la Capacité " + SkillName(heroKind, 0);
                        break;
                    case QuestKindTitle.SkillMaster2:
                        name = Title(TitleKind.SkillMaster) + " 2";
                        client = "Gamin Asiatique Condescendant";
                        description = "Tu peux voir l'enfant d'avant entraînant son Tai Chi. Ses yeux fermés, il se déplace aisément d'une position à une autre, sa respiration en rythme avec ses déplacements. Il commence à parler sans ouvrir ses yeux alors qu'il continue son entraînement. \"Salut, le nouveau. Tu t'es amélioré, mais j'ai peur de dire qu'on n'y est pas encore. Tu ne peux pas contruire une maison sans une solide fondation, et ta fondation est aussi faible que le thé d'hier. Renforce tes bases et travaille ton équilibre jusqu'à que tu puisses dancer une valse sans trébucher sur tes propres pieds.\"";
                        condition = "Atteindre le Nv 50 avec la Capacité " + SkillName(heroKind, 0);
                        break;
                    case QuestKindTitle.SkillMaster3:
                        name = Title(TitleKind.SkillMaster) + " 3";
                        client = "Gamin Asiatique Condescendant";
                        description = "L'enfant entraîne toujours son Tai Chi, mais cette fois il tient une bouteille en équilibre sur les paumes de chacune de ses mains. Il transitionne rapidement entre ses positions, mais l'eau n'ondule même pas. Il se retourne et te fige du regard alors qu'il continue de bouger avec la grâce d'un chat. \"Salut, le nouveau. Tu t'améliores, je t'ai vu presque garder le contrôle de tes coups là-bas. Presque, en tout cas. Continue de travailler sur ton contrôle et ta technique et tu auras enfin l'air de savoir ce que tu fais avant de dire ouf !\"";
                        condition = "Atteindre le Nv 250 avec la Capacité " + SkillName(heroKind, 0);
                        break;
                    case QuestKindTitle.SkillMaster4:
                        name = Title(TitleKind.SkillMaster) + " 4";
                        client = "Condescending Asian Kid";
                        description = "Tu vois l'enfant s'entraîner avec une douzaine d'hommes et femmes. Ou, du moins, une douzaine d'hommes et de femmes essayant de s'entraîner avec lui mais il dance autour d'eux, réfléchissant leurs coups avec des mouvements fins, tout en equivant toutes leurs tentatives. Il te voit observer son entraînement et t'interpelle. \"Salut le nouveau, on dirait que t'as pu former une fondation solide, après tout. Malheureusement, ça veut dire que je dois un billet de 50 à Régis. Fais-toi pardonner, d'accord ? Je vais lui miser quitte ou double sur le fait que tu maitrises tout ton art. Je t'y ferais même profiter si tu y arrives.\"";
                        condition = "Atteindre le Nv 250 avec Toutes les Capacités du héros " + Hero(heroKind);
                        break;
                    case QuestKindTitle.MonsterDistinguisher1:
                        name = Title(TitleKind.MonsterDistinguisher) + " 1";
                        client = "Nico le Garde Forestier";
                        description = "Oh, salut toi, tu veux devenir un scout ? Je pourrais t'en apprendre plus sur les monstres, leurs habitudes, leur alimentation, et tout ça... oh, tu viens juste pour savoir comment attrapper des monstres plus efficacement ? Je suppose que ça peut aussi t'aider pour ça. D'accord, tout d'abord, va explorer et vaincre 20 slimes normaux en combat ! Essaye d'examiner leur comportement tant que tu y es, et tu devriendras un vrai scout lorsque tu auras fini.";
                        break;
                    case QuestKindTitle.MonsterDistinguisher2:
                        name = Title(TitleKind.MonsterDistinguisher) + " 2";
                        client = "Nico le Garde Forestier";
                        description = "L'étude de monstre est amusante, non ? Plus tu en sais à propos d'eux, plus tu pourras attraper des ennemis plus puissants ! Maintenant, allons étudier un monstre différent. Va vaincre 100 Slimes Bleus et reviens me voir quand tu auras terminé. J'ai hate d'entendre tout ce que tu auras appris !";
                        break;
                    case QuestKindTitle.MonsterDistinguisher3:
                        name = Title(TitleKind.MonsterDistinguisher) + " 3";
                        client = "Nico le Garde Forestier";
                        description = "As-tu déjà senti le pincement d'une décharge éléectrique ? Si tu veux l'éviter dans la nature, tu auras besoin de rencontrer des slimes jaunes et de comprendre comment éviter leur fluide qui est chargé électriquement. Apprendre comment gérer les forces de ces monstres te donnera un avantage lorsque tu essayeras de les capturer. Maintenant va vaincre à peu près 250 Slimes Jaunes puis reviens me voir.";
                        break;
                    case QuestKindTitle.MonsterDistinguisher4:
                        name = Title(TitleKind.MonsterDistinguisher) + " 4";
                        client = "Nico le Garde Forestier";
                        description = "Cette fois-ci, essayons quelque chose de nouveau, car je ne pense pas que tu puisses apprendre beaucoup plus en ne combattant que des slimes. Cette fois, je veux que tu étudies les habitudes des araignées bleues. Certaines personnes ont extrêmement peurs des araignées, auquel cas c'est une bonne chose de dépasser sa peur en les confrontant directement ! Fais juste attention et fais de ton mieux ! Tiens-moi au courant quand tu auras vaincu 1000 Araignées Bleues.";
                        break;
                    case QuestKindTitle.MonsterDistinguisher5:
                        name = Title(TitleKind.MonsterDistinguisher) + " 5";
                        client = "Nico le Garde Forestier";
                        description = "Il y a des monstres assez intéressants dans ce monde, n'est-ce pas ? Parmi eux, que penses-tu d'un qui peut litéralement te ralentir ? Comment peux-tu gérer un cas où tu ne peux pas te déplacer aussi vite que d'habitude ? Tu t'adaptes et fais en sorte que chaque mouvement compte ! Va étudier les Fées Rouges, en vaincre à peu près 5000 t'aidera à comprendre comment apprivoiser leurs forces et augmenter ton aptitude de capture de monstre.";
                        break;
                    case QuestKindTitle.MonsterDistinguisher6:
                        name = Title(TitleKind.MonsterDistinguisher) + " 6";
                        client = "Nico le Garde Forestier";
                        description = "Bon, je ne sais pas si j'ai grand chose d'autre à t'apprendre, mais je dois te demander, es-tu déjà parti à la pêche ? C'est un sacré sport pour ceux qui ont la patience de s'y atteler. Donc, ma prochaine leçon t'apprendra la pêche ! Va vaincre " + tDigit(50000) + " Poissons-Démon Verts puis reviens me voir. Rappelle-toi que c'est un exercice pour améliorer ta patience, mais il t'aidera à grandement augmenter ton aptitude de capture de monstre, je te le garantis !";
                        break;
                    case QuestKindTitle.MonsterDistinguisher7:
                        name = Title(TitleKind.MonsterDistinguisher) + " 7";
                        client = "Nico le Garde Forestier";
                        description = "Est-ce que tu sais comment distinguer les arbres normaux des tréants ? C'est facile de les différencier lorsque les tréants bougent, mais même les identificateurs de monstre professionnels ont du mal à différencier les tréants immobiles des arbres normaux. C'est dangeureux d'approcher un tréant lorsque tu penses que c'est un arbre normal, donc je pense que je vais te donner la tâche d'en vaincre jusqu'à que tu puisses parfaitement distinguer l'un de l'autre. Peut-être que si tu en vaincs 1 million, tu ne pourras plus faire d'erreurs. Tu peux penser que c'est trop, mais une fois que tu auras fini, tu seras reconnu comme un identificateur de monstre professionnel qui sait reconnaitre les tréants !";
                        break;
                    case QuestKindTitle.MonsterDistinguisher8:
                        name = Title(TitleKind.MonsterDistinguisher) + " 8";
                        client = "Nico le Garde Forestier";
                        description = "Salut, aventurier. As-tu déjà entendu parler des Tigres de Feu ? Ce sont de redoutables monstres qui parcourent le volcan dans cette région. Je les étudie depuis un moment, mais j'ai besoin de ton aide pour une recherche sur le terrain. J'ai besoin que tu ailles là-bas et vaincs 10 millions de Tigres de Feu Violets. Ramène-moi leurs fourrures et je serais capable d'en apprendre plus sur eux. Hé, j'ai vu ta tête lorsque j'ai dit 10 millions. Je sais que c'est beaucoup, mais je ferais en sorte que ça vaille le coup pour toi ! Bonne chance, et sois prudent.";
                        break;
                    case QuestKindTitle.EquipmentSlotWeapon1:
                        name = Title(TitleKind.EquipmentSlotWeapon) + " 1";
                        client = "Tsuba, le Maître d'Armes";
                        description = "Bienvenue, débutant. Viens-tu demander une éducation au sujet de la maîtrise d'arme ? Très bien. Tout d'abord, équipe une arme et essaye juste de l'utiliser. Pendant cela, tu pourras voir que ta compétence avec cette arme augmente jusqu'à ce qu'elle augmente de niveau, ce qui augmentera les effets qu'elle t'octroie. Reviens me voir lorsque tu auras atteint le Niveau 10 avec au moins une arme, et je te montrerai comment manier plus d'armes à la fois.";
                        condition = "Atteindre le Nv 10 avec 1 Arme avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Weapon)) + " / 1";
                        break;
                    case QuestKindTitle.EquipmentSlotWeapon2:
                        name = Title(TitleKind.EquipmentSlotWeapon) + " 2";
                        client = "Tsuba, le Maître d'Armes";
                        description = "Tu as sû prouver ta volonté, débutant. Fais-le encore une fois, mais cette fois-ci atteint le Niveau 10 avec au moins cinq armes différentes, et je t'aiderai à en manier encore plus !";
                        condition = "Atteindre le Nv 10 avec 5 Armes avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Weapon)) + " / 5";
                        break;
                    case QuestKindTitle.EquipmentSlotWeapon3:
                        name = Title(TitleKind.EquipmentSlotWeapon) + " 3";
                        client = "Tsuba, le Maître d'Armes";
                        description = "On dirait que je ne plus t'appeler un débutant, car tu as sû me montrer ton aptitude en utilisant une variété d'armes. Maintenant, adepte, si tu veux continuer à être sous ma tutelle, je dois voir que tu as attent le Niveau 10 avec 15 armes différentes !";
                        condition = "Atteindre le Nv 10 avec 15 Armes avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Weapon)) + " / 15";
                        break;
                    case QuestKindTitle.EquipmentSlotWeapon4:
                        name = Title(TitleKind.EquipmentSlotWeapon) + " 4";
                        client = "Tsuba, le Maître d'Armes";
                        description = "Bien joué, adepte. Encore une fois, cette fois-ci avec 30 armes. Montre-moi que tu as l'étoffe de devenir un maître d'armes !";
                        condition = "Atteindre le Nv 10 avec 30 Armes avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Weapon)) + " / 30";
                        break;
                    case QuestKindTitle.EquipmentSlotWeapon5:
                        name = Title(TitleKind.EquipmentSlotWeapon) + " 5";
                        client = "Tsuba, le Maître d'Armes";
                        description = "Je suis impressionné, adepte. Maintenant, essayons quelque chose de plus difficile. Je veux te voir manier au moins 20 armes qui sont au moins au Niveau 15. Pousse les limites de l'ordinaire et commence à atteindre une nouvelle grandeur !";
                        condition = "Atteindre le Nv 15 avec 20 Armes avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Weapon, 15)) + " / 20";
                        break;
                    case QuestKindTitle.EquipmentSlotWeapon6:
                        name = Title(TitleKind.EquipmentSlotWeapon) + " 6";
                        client = "Tsuba, le Maître d'Armes";
                        description = "Il ne me reste plus grand chose à t'apprendre, donc je vais te donner un dernier défi. Atteint le Niveau 20 avec 50 armes différentes, et je te divulgerai mes derniers secrets.";
                        condition = "Atteindre le Nv 20 avec 50 Armes avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Weapon, 20)) + " / 50";
                        break;
                    case QuestKindTitle.EquipmentSlotArmor1:
                        name = Title(TitleKind.EquipmentSlotArmor) + " 1";
                        client = "Koutetsu, le Maître d'Armures";
                        description = "Le chemin vers la maîtrise d'armure commence ici, avec ta requête d'accéder à ces connaissances. Prouve-moi que tu veux en savoir plus en atteingant le Niveau 10 avec n'importe quelle armure.";
                        condition = "Atteindre le Nv 10 avec 1 Armure avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Armor)) + " / 1";
                        break;
                    case QuestKindTitle.EquipmentSlotArmor2:
                        name = Title(TitleKind.EquipmentSlotArmor) + " 2";
                        client = "Koutetsu, le Maître d'Armures";
                        description = "Ah, excellent. Ta poursuite du savoir de la maîtrise d'armure est noble, mon cher débutant. Maintenant, prends ce que tu as appris et fais-le cinq fois ! Plus tu t'entraîneras, plus tu comprendras l'âme des armures, ce qui te permettra d'en porter plus sans t'encombrer.";
                        condition = "Atteindre le Nv 10 avec 5 Armures avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Armor)) + " / 5";
                        break;
                    case QuestKindTitle.EquipmentSlotArmor3:
                        name = Title(TitleKind.EquipmentSlotArmor) + " 3";
                        client = "Koutetsu, le Maître d'Armures";
                        description = "Travail remarquable, mon débutant assidu. Ton zèle pour l'apprentissage est admirable, mais tu dois pousser plus loin si tu veux atteindre la clarté que tu recherches. Amène-moi 15 armures au Niveau 10 et je t'illuminerai sur l'équipement d'armure efficace.";
                        condition = "Atteindre le Nv 10 avec 15 Armures avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Armor)) + " / 15";
                        break;
                    case QuestKindTitle.EquipmentSlotArmor4:
                        name = Title(TitleKind.EquipmentSlotArmor) + " 4";
                        client = "Koutetsu, le Maître d'Armures";
                        description = "On dirait que tu es devenu un adepte, donc maintenant mon jeune adepte, si tu peux m'apporter 30 armures au niveau 10, je t'entraînerai à bouger facilement en portant encore plus d'armures.";
                        condition = "Atteindre le Nv 10 avec 30 Armures avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Armor)) + " / 30";
                        break;
                    case QuestKindTitle.EquipmentSlotArmor5:
                        name = Title(TitleKind.EquipmentSlotArmor) + " 5";
                        client = "Koutetsu, le Maître d'Armures";
                        description = "Parfois, il arrive que ce que nous pensons être le haut d'un sommet n'est qu'un nouveau début. Cette fois je te demande de dépasser tes limites et de m'apporter 20 armures au Niveau 15, puis nous pourrons continuer ton entraînement sur ta capacité à porter des armures.";
                        condition = "Atteindre le Nv 15 avec 20 Armures avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Armor, 15)) + " / 20";
                        break;
                    case QuestKindTitle.EquipmentSlotArmor6:
                        name = Title(TitleKind.EquipmentSlotArmor) + " 6";
                        client = "Koutetsu, le Maître d'Armures";
                        description = "Tu as presque atteint mon niveau, mon cher adepte. La dernière tâche que j'ai à te donner est d'atteindre le Niveau 20 avec 50 armures différentes. Je t'apprendrai la dernière technique secrète que j'ai pu apprendre au fil de ma longue vie à ton retour.";
                        condition = "Atteindre le Nv 20 avec 50 Armures avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Armor, 20)) + " / 50";
                        break;
                    case QuestKindTitle.EquipmentSlotJewelry1:
                        name = Title(TitleKind.EquipmentSlotJewelry) + " 1";
                        client = "Joudama, le Maître des Bijoux";
                        description = "Bien le bonjour, es-tu intéressé par les bijoux ? Ah, tu es comme un diamant brut, mon cher, mais c'est quelque chose qu'on peut arranger. Ramène-moi un accessoire que tu as monté au Niveau 10 et nous pourrons voir comment raffiner ton apparance. J'ai hâte de voir ce que ça donnera.";
                        condition = "Atteindre le Nv 10 avec 1 Bijou avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Jewelry)) + " / 1";
                        break;
                    case QuestKindTitle.EquipmentSlotJewelry2:
                        name = Title(TitleKind.EquipmentSlotJewelry) + " 2";
                        client = "Joudama, le Maître des Bijoux";
                        description = "Ohh, quelle merveille, en effet. Il n'y a rien de tel qu'une gemme fraîchement polie dans ses mains, et toi, mon cher, tu es cette gemme pour moi. Cependant, notre travail ne vient que de commencer. Va et reviens me voir une fois que 5 accessoires ont atteint le Niveau 10. Je penserai à toi jusqu'à qu'on se rencontre de nouveau !";
                        condition = "Atteindre le Nv 10 avec 5 Bijoux avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Jewelry)) + " / 5";
                        break;
                    case QuestKindTitle.EquipmentSlotJewelry3:
                        name = Title(TitleKind.EquipmentSlotJewelry) + " 3";
                        client = "Joudama, le Maître des Bijoux";
                        description = "Mon coeur s'enflamme, très bon travail ! Tu es vraiment un diamant brut, mon cher. Continuouns à te raffiner et exposer LA beauté enchantante que tu es ! Ramène-moi 15 accessoires que tu as monté au Niveau 10 et je te montrerai comment briller de mille feux !";
                        condition = "Atteindre le Nv 10 avec 15 Bijoux avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Jewelry)) + " / 15";
                        break;
                    case QuestKindTitle.EquipmentSlotJewelry4:
                        name = Title(TitleKind.EquipmentSlotJewelry) + " 4";
                        client = "Joudama, le Maître des Bijoux";
                        description = "Puis-je dire que les étoiles brillent moins que toi ? Peut-être pas pour le moment, mais tu es bel et bien une lueur d'espoir en ce moment. On ne peut qu'arriver jusqu'à un certain point avec le raffinement, mais maintenant il est temps d'exposer la vraie beauté de la pièrre précieuse que je vois en toi. Ramène-moi 30 accessoires au Niveau 10, et je te montrerai comment briller comme un diamant !";
                        condition = "Atteindre le Nv 10 avec 30 Bijoux avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Jewelry)) + " / 30";
                        break;
                    case QuestKindTitle.EquipmentSlotJewelry5:
                        name = Title(TitleKind.EquipmentSlotJewelry) + " 5";
                        client = "Joudama, le Maître des Bijoux";
                        description = "Tu ne m'as pas déçu une seule fois, me chère gemme exquise. Le perfection réelle n'est qu'un but, cependant je vois quelque chose qui s'en rapproche en toi. Pour atteindre le prochain niveau, tu dois atteindre le Niveau 15 avec 20 accessoires différents. On ne peut que briller encore plus en supassant ses limites.";
                        condition = "Atteindre le Nv 15 avec 20 Bijoux avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Jewelry, 15)) + " / 20";
                        break;
                    case QuestKindTitle.EquipmentSlotJewelry6:
                        name = Title(TitleKind.EquipmentSlotJewelry) + " 6";
                        client = "Joudama, le Maître des Bijoux";
                        description = "Mon cher, dire que tu es resplandissant est un euphémisme. Malheureusement, notre petit projet approche à sa fin. Je vais manquer de voir ta petite bouille parfaite avec ce regard éblouissant qui se fige sur moi lorsque je te retourne un regard. Je ne me mettrai pas en travers de ta route vers une beauté inimaginable, mais je vais te mettre sur le chemin pour l'atteindre. Ramène-moi 50 accessoires au Niveau 20 et je partagerai avec toi les dernières bribes de savoir qu'il me reste.";
                        condition = "Atteindre le Nv 20 avec 50 Bijoux avec le héros " + Hero(heroKind) + " : " + tDigit(game.equipmentCtrl.LevelMaxedNum(heroKind, EquipmentPart.Jewelry, 20)) + " / 50";
                        break;

                    case QuestKindTitle.PotionSlot1:
                        name = Title(TitleKind.PotionSlot) + " 1";
                        client = "Flandre, le Gourou d'Alchimie";
                        description = "Hmmm ? Qui es-tu et pourquoi es-tu dans mon laboratoire ? Oh, tu viens pour quelques conseils sur l'Alchimie, c'est ça ? Hmm, je ne suis pas du genre à partager mes secrets d'alchimie comme ça, mais je peux te montrer comment être plus efficae avec tes potions. Ramène-moi ces objets et on pourra en parler plus.";
                        break;
                    case QuestKindTitle.PotionSlot2:
                        name = Title(TitleKind.PotionSlot) + " 2";
                        client = "Flandre, le Gourou d'Alchimie";
                        description = "Est-ce qu'on se connaît ? Oh, c'est vrai, tu viens pour demander des connaissances alchimiques. Encore une fois, désolé, mais je ne partagerai pas ce genre de savoir avec quelqu'un qui vient de nulle part. Cependant, j'ai besoin que quelqu'un aille me chercher plus d'ingrédients. Si tu vas m'en chercher, je te montrarai comment étendre tes capacités de manipulation de potion.";
                        break;
                    case QuestKindTitle.PotionSlot3:
                        name = Title(TitleKind.PotionSlot) + " 3";
                        client = "Flandre, le Gourou d'Alchimie";
                        description = "Je ne me rappelle pas avoir commandé une pizza... Ah, désolé, tu as la tête de quelqu'un qui cherche toujours à faire des courses pour les autres. En parlant de ça, j'ai besoin de plus d'ingrédients. Si tu es assez sympa pour m'en récupérer, je t'apprendrai comment utiliser une potion de plus à la fois, mais après ça je vais devoir partir en voyage à travers le monde. Et, s'il te plaît, arrête de me demander mes recettes alchimiques - je ne peux vraiment pas les partager avec toi.";
                        break;

                    case QuestKindTitle.Porter1: //TODO
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
                    case QuestKindTitle.Alchemist1: //TODO
                        name = Title(TitleKind.Alchemist) + " 1";
                        client = "Mia the alchemist";
                        description = "An alchemist's job is to create what the world wants. There are alchemists who pursue what they want to create, but I am not interested in that. Oh! You say you want to learn Alchemy under me? Well, go ahead. I've compiled a list of things that are easy for beginners to make, so you can gather the materials yourself.";
                        break;
                    case QuestKindTitle.Alchemist2: //TODO
                        name = Title(TitleKind.Alchemist) + " 2";
                        client = "Mia the Alchemist";
                        description = "My family has been a famous family of alchemists for generations. Everyone comes to us requesting potions among other things. It's an easy job since everyone is satisfied as long as we make what they want. Oh, you've already finished making everything on the list? Why don't you create something you'd like to make yourself next?";
                        break;
                    case QuestKindTitle.Alchemist3: //TODO
                        name = Title(TitleKind.Alchemist) + " 3";
                        client = "Mia the Alchemist";
                        description = "Why don't I try my hand at making what I want to make? As I've said many times, I'm not interested in that. But it made me happy to see you using alchemy to make the things you want to make. Next, I'd like you to do me a favor and get me the materials I need for my work. Thank you.";
                        break;
                    case QuestKindTitle.Alchemist4: //TODO
                        name = Title(TitleKind.Alchemist) + " 4";
                        client = "Mia the Alchemist";
                        description = "Thanks for bringing me the materials. You're looking great as an alchemist! Seeing you working so happily on your alchemy has made me interested in doing research to create what I want to create. I thought the day would never come when I would feel this way, so it's kind of strange. Now I need you to bring me the materials I need for my research. Thank you.";
                        break;
                    case QuestKindTitle.Alchemist5: //TODO
                        name = Title(TitleKind.Alchemist) + " 5";
                        client = "Mia the Alchemist";
                        description = "I never realized how much fun it was to use alchemy to create what I wanted to create...! I wouldn't have realized it without you. Thank you. My research is still incomplete, so I'll try to face this research from now on. I will continue to work as usual, so I will be too busy to take care of you. But you are a full-fledged alchemist now, and you can do just fine as an alchemist without me! I just want to try alchemy with you one last time. After this, we'll say goodbye. Come on, let's go gather materials together!";
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

                    case QuestKindTitle.MetalHunter1: //TODO
                        name = Title(TitleKind.MetalHunter) + " 1";
                        client = "Metallic Nuts";
                        description = "Did you know that there are metal monsters in this world? You have a rare chance of spotting them. In the Slime dungeons, there are metal Slimes for instance. Their bodies are so hard that you can only deal 1 damage to them. However, if you defeat them, you'll get a bunch of EXP. First of all, I want you to go kill one Metal Slime. Once you've done that, I'm sure you'll be a little better at killing Metal Slimes.";
                        break;
                    case QuestKindTitle.MetalHunter2: //TODO
                        name = Title(TitleKind.MetalHunter) + " 2";
                        client = "Metallic Nuts";
                        description = "I see you've defeated the metal Slime! It looks like you've learned a bit how to destroy metal monsters. Keep it up and you'll learn how to hunt metal monsters more efficiently. For the next hunt, make sure you don't confuse between a Metal Slime and a Metal Magicslime.  Hunt down 2 Metal Magicslimes.";
                        break;
                    case QuestKindTitle.MetalHunter3: //TODO
                        name = Title(TitleKind.MetalHunter) + " 3";
                        client = "Metallic Nuts";
                        description = "I see you were able to defeat a few Metal Magicslimes too! Are you getting used to breaking metal bodies? Let's keep on defeating metal monsters and earning EXP. The next hunt will be for some Metal Spiders";
                        break;
                    case QuestKindTitle.MetalHunter4: //TODO
                        name = Title(TitleKind.MetalHunter) + " 4";
                        client = "Metallic Nuts";
                        description = "I can't believe you beat Metal Spiders too. You've got a knack for breaking metal bodies! We need you to take down the Metal Bats next, and if you can accomplish this, you will be a pro at Metal hunting.";
                        break;
                    case QuestKindTitle.MetalHunter5: //TODO
                        name = Title(TitleKind.MetalHunter) + " 5";
                        client = "Metallic Nuts";
                        description = "";
                        break;
                    case QuestKindTitle.MetalHunter6: //TODO
                        name = Title(TitleKind.MetalHunter) + " 6";
                        client = "Metallic Nuts";
                        description = "";
                        break;
                    case QuestKindTitle.MetalHunter7: //TODO
                        name = Title(TitleKind.MetalHunter) + " 7";
                        client = "Metallic Nuts";
                        description = "";
                        break;
                    case QuestKindTitle.MetalHunter8: //TODO
                        name = Title(TitleKind.MetalHunter) + " 8";
                        client = "Metallic Nuts";
                        description = "";
                        break;
                    case QuestKindTitle.MetalHunter9: //TODO
                        name = Title(TitleKind.MetalHunter) + " 9";
                        client = "Metallic Nuts";
                        description = "";
                        break;

                    case QuestKindTitle.FireResistance1: //TODO
                        name = Title(TitleKind.FireResistance) + " 1";
                        client = "Yayoi, the Fireworks Master";
                        description = "When launching fireworks, you wonder if it gets hot, right? I've been doing this job for many years, so I'm used to it. Do you want to be able to withstand the heat of the flames too? If so, why don't you touch hot things constantly until you get used to the heat?";
                        break;
                    case QuestKindTitle.FireResistance2: //TODO
                        name = Title(TitleKind.FireResistance) + " 2";
                        client = "Yayoi, the Fireworks Master";
                        description = "Ah! Hey, we meet again! Are you used to the heat since then? Well, I have a favor to ask you... We have a vacancy in our fireworks crew for the upcoming fireworks show, and I'm looking for a replacement. I need your help if you don't mind. But I don't know if you can handle the heat of the fireworks right now.... So, you need to get a little more heat tolerance!";
                        break;
                    case QuestKindTitle.FireResistance3: //TODO
                        name = Title(TitleKind.FireResistance) + " 3";
                        client = "Yayoi, the Fireworks Master";
                        description = "Oh! You look much better now! I think I can trust you to set off fireworks now! You'll be practicing setting off fireworks with me for a while! But first, I need you to bring me the items I need for the fireworks. Sorry for all the requests, but I'm counting on you!";
                        break;
                    case QuestKindTitle.FireResistance4: //TODO
                        name = Title(TitleKind.FireResistance) + " 4";
                        client = "Yayoi, the Fireworks Master";
                        description = "Thanks to the items you have collected, I have successfully finished making fireworks balls! But fireworks are only complete when they are launched into the sky! The fireworks show is tonight! Oh no, the monsters have gathered to see the fireworks... Let's get rid of the monsters during the day so our guests can watch the fireworks in peace!";
                        break;
                    case QuestKindTitle.FireResistance5: //TODO
                        name = Title(TitleKind.FireResistance) + " 5";
                        client = "Yayoi, the Fireworks Master";
                        description = "Oh man! The firework show was a blast! Thanks to your help, it was a great success! Wasn't it hot when you set off the fireworks? From the look on your face, I'd say you had plenty of time to spare. With that fiery spirit, I'm sure you'll get through anything! It's a shame to say goodbye, so will you do me one last favor? I need to gather materials for next year's fireworks show, so help me gather them together!";
                        break;
                    case QuestKindTitle.IceResistance1: //TODO
                        name = Title(TitleKind.IceResistance) + " 1";
                        client = "Len, the Ice Swordsman";
                        description = "You want something from me...? ─ ─ Hmmm. You want ice resistance? It is true that you are not resistant to ice damage at all now. In fact, you are frozen by my cold air. It can't be helped. I will teach you how to handle ice. Come with me.";
                        break;
                    case QuestKindTitle.IceResistance2: //TODO
                        name = Title(TitleKind.IceResistance) + " 2";
                        client = "Len, the Ice Swordsman";
                        description = "That's a little better. To gain ice resistance, you need an icy spirit. You can't melt it, and you can't shatter it. It is important to maintain a firm spirit. Now, hone your icy spirit in the fight.";
                        break;
                    case QuestKindTitle.IceResistance3: //TODO
                        name = Title(TitleKind.IceResistance) + " 3";
                        client = "Len, the Ice Swordsman";
                        description = "Hmmm. Looks like you were able to acquire the spirit of ice. You probably don't even notice my cold air anymore. But you are not perfect yet. To handle ice, you need to know more about it. Learn ice in the fight.";
                        break;
                    case QuestKindTitle.IceResistance4: //TODO
                        name = Title(TitleKind.IceResistance) + " 4";
                        client = "Len, the Ice Swordsman";
                        description = "You seem to have mastered ice. Hmmm. You remember things better than I thought you would. If you've come this far, you should be able to develop resistance to ice with a little more training. I have no intention of slacking off in my training until the end. Prepare yourself and work hard.";
                        break;
                    case QuestKindTitle.IceResistance5: //TODO
                        name = Title(TitleKind.IceResistance) + " 5";
                        client = "Len the Ice Swordsman";
                        description = "You have arrived here well. It is safe to say that your ice resistance has almost reached perfection. Keep up the icy spirit so that I won't be disappointed the next time we meet. Now, let's put the finishing touches on it. Don't get carried away and cut corners.";
                        break;
                    case QuestKindTitle.ThunderResistance1: //TODO
                        name = Title(TitleKind.ThunderResistance) + " 1";
                        client = "Amadeus, the guitarist";
                        description = "You want to build a body that can withstand lightning? You don't say that with half a mind, do you? Can't you swear on your rock soul? Hmmm. Doesn't seem like you're just joking around. All right then! I'll teach you how to handle lightning! First, let's take down some monsters around here!";
                        break;
                    case QuestKindTitle.ThunderResistance2: //TODO
                        name = Title(TitleKind.ThunderResistance) + " 2";
                        client = "Amadeus, the guitarist";
                        description = "You rock! I like it a lot! But you're not ready to control the power of the thunder yet. You need to let out more of what you've been holding inside! Then the lightning will respond to your heart! Let's go, let's go, let's go!";
                        break;
                    case QuestKindTitle.ThunderResistance3: //TODO
                        name = Title(TitleKind.ThunderResistance) + " 3";
                        client = "Amadeus, the guitarist";
                        description = "Good God, good God! Your heart shouts have reached my heart! At this rate, you'll soon be able to control the power of thunder! You've got potential! Maybe you also have talent as a rock musician? Well, that aside, let's go hunting some monsters!";
                        break;
                    case QuestKindTitle.ThunderResistance4: //TODO
                        name = Title(TitleKind.ThunderResistance) + " 4";
                        client = "Amadeus, the guitarist";
                        description = "You're pretty much finished! How's it going? You're getting a feel for it, aren't you? You feel a numbness inside your body, don't you? If you can completely own that numbness, you'll build up your tolerance to lightning! Now, it's time for the last spurt! Make your own noise!";
                        break;
                    case QuestKindTitle.ThunderResistance5: //TODO
                        name = Title(TitleKind.ThunderResistance) + " 5";
                        client = "Amadeus, the guitarist";
                        description = "This rocks! You could get hit by lightning and not even flinch! I'm impressed with the way you face the lightning! Lastly, I want to have a session with you now that you're perfect! Come with me! Come on, let's go wild!";
                        break;
                    case QuestKindTitle.LightResistance1: //TODO
                        name = Title(TitleKind.LightResistance) + " 1";
                        client = "The Ladyship Lapidus";
                        description = "Oh, you wanted to see me? I see, you want to obtain the blessing of light? Very well. I am here to help you grow. I will spare no pains to help you on your path of light. Now, let's go and kill some monsters!";
                        break;
                    case QuestKindTitle.LightResistance2: //TODO
                        name = Title(TitleKind.LightResistance) + " 2";
                        client = "The Ladyship Lapidus";
                        description = "You're doing well! You have some potential. It's said that the protection of light is given to those with a pure heart. Try to face the monsters with a clear mind. If you do that, I think you'll grow faster!";
                        break;
                    case QuestKindTitle.LightResistance3: //TODO
                        name = Title(TitleKind.LightResistance) + " 3";
                        client = "The Ladyship Lapidus";
                        description = "Your heart has been filled with light since we met. I sensed that you kept a pure heart even while confronting the monster. Please remember that awareness. Next time, try to fight with the image of wearing the light. It will be easier to receive the blessings of the light!";
                        break;
                    case QuestKindTitle.LightResistance4: //TODO
                        name = Title(TitleKind.LightResistance) + " 4";
                        client = "The Ladyship Lapidus";
                        description = "You are gaining the blessing of light well! I think if you work a little harder you will get the blessing completely. I have seen many people who aspire to the path of light, but many of them fail because they can't get a sense of it. So I'm glad you haven't given up this far and are willing to give it a shot...! Now, let's head out to defeat them again!";
                        break;
                    case QuestKindTitle.LightResistance5: //TODO
                        name = Title(TitleKind.LightResistance) + " 5";
                        client = "The Ladyship Lapidus";
                        description = "You have gained the blessing of light almost completely. I think that your strong desire for the light has borne fruit. I, too, am honored to have supported you! I hope you will continue to follow the path of light. Now, let's get on with the final touches!";
                        break;
                    case QuestKindTitle.DarkResistance1: //TODO
                        name = Title(TitleKind.DarkResistance) + " 1";
                        client = "Dark Dragon Bite Amatsu";
                        description = "My name is 'Dark Dragon Bite Amatsu'. I am the one who controls the principles of darkness.If you seek the power of darkness, then I shall grant you the true darkness.But you must have the strength to withstand the darkness. First, defeat the hidden monsters of darkness.";
                        break;
                    case QuestKindTitle.DarkResistance2: //TODO
                        name = Title(TitleKind.DarkResistance) + " 2";
                        client = "Dark Dragon Bite Amatsu";
                        description = "Thou hast become a vessel of darkness through war. The power of darkness will raise your soul as a foundation. Therefore, the darkness that sleeps deep within you will awaken. Absorb the darkness from the hidden demon monsters and awaken your own darkness.";
                        break;
                    case QuestKindTitle.DarkResistance3: //TODO
                        name = Title(TitleKind.DarkResistance) + " 3";
                        client = "Dark Dragon Bite Amatsu";
                        description = "The darkness within you has awakened only slightly from its slumber in the depths. Your darkness is a beautiful one, a pure darkness free of impurities. If it is you, then you will likely gain strong dark abilities. Now, let us resume our hunt for monsters.";
                        break;
                    case QuestKindTitle.DarkResistance4: //TODO
                        name = Title(TitleKind.DarkResistance) + " 4";
                        client = "Dark Dragon Bite Amatsu";
                        description = "You have fully awakened to the power of darkness. You should now have complete control over its abilities. Your growth has been accelerated due to my influence. I am grateful for the opportunity to teach you about the darkness. The training is almost complete, but do not let your guard down.";
                        break;
                    case QuestKindTitle.DarkResistance5: //TODO
                        name = Title(TitleKind.DarkResistance) + " 5";
                        client = "Dark Dragon Bite Amatsu";
                        description = "You now possess the power of darkness. You are now capable of neutralizing most forms of darkness. However, this power is strong, so be careful when using it. I will teach you how to control it. This is the final training.";
                        break;
                    case QuestKindTitle.Survival1: //TODO
                        name = Title(TitleKind.Survival) + " 1";
                        client = "Matsuzo, the hot-blooded instructor";
                        description = "You there! It's me! Survival! I'm going to teach you the secrets of survival! Don't hold back! I'll teach you everything from 1 to 100, from A to Z! The basics of survival is all about your spirit! Anyway, keep your spirits up and you'll make it through! Now, go get 'em!";
                        if (!quest.isAccepted) condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(500);
                        else condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(Main.main.SR.survivalNumQuestTitle[(int)quest.heroKind]) + " / " + tDigit(500);
                        break;
                    case QuestKindTitle.Survival2: //TODO
                        name = Title(TitleKind.Survival) + " 2";
                        client = "Matsuzo, the hot-blooded instructor";
                        description = "Well done! You made it back alive! How was that? Have you learned the importance of Kiatsu? You can do anything if you have Ki! Next to Ki, the most important thing is a strong body! Come on! Fight the monsters! And you've got to get better! Polish it up!";
                        if (!quest.isAccepted) condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(5000);
                        else condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(Main.main.SR.survivalNumQuestTitle[(int)quest.heroKind]) + " / " + tDigit(5000);
                        break;
                    case QuestKindTitle.Survival3: //TODO
                        name = Title(TitleKind.Survival) + " 3";
                        client = "Matsuzo, the hot-blooded instructor";
                        description = "Oh! You've transformed! What an amazing body! With this, you can withstand even more hardships! Next, let's work on building your stamina! No matter how tough things get, with stamina, you can make it through! Go! Build up your stamina!";
                        if (!quest.isAccepted) condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(50000);
                        else condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(Main.main.SR.survivalNumQuestTitle[(int)quest.heroKind]) + " / " + tDigit(50000);
                        break;
                    case QuestKindTitle.Survival4: //TODO
                        name = Title(TitleKind.Survival) + " 4";
                        client = "Matsuzo, the hot-blooded instructor";
                        description = "Wow! You've come this far with all-out running! What amazing stamina! With this, you might be able to endure even harder survival challenges! Next, let's work on building your power! Power is justice! Power is justice! With power, you can do anything! Use monsters as punching bags and hone your power to the fullest!";
                        if (!quest.isAccepted) condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(500000);
                        else condition = "Defeat any monsters while your HP is 20% or less : " + tDigit(Main.main.SR.survivalNumQuestTitle[(int)quest.heroKind]) + " / " + tDigit(500000);
                        break;
                    case QuestKindTitle.Cooperation1: //TODO
                        name = Title(TitleKind.Cooperation) + " 1";
                        client = "Morkyl";
                        description = "Hey there player! Let me introduce you to the method for improving your heroes, by allowing them to increase their background efficiency when you're playing as a different hero! With each improvement to the Proof of Rebirth title, your background efficiency will get better, but it does require that you perform a certain number of rebirths at a higher tier than the previous quest required. Let's start this off by having you perform Rebirth Tier 1 once. When you have done that, come back here for your reward!";
                        condition = "Rebirth Tier 1 # : " + tDigit(GameController.game.rebirthCtrl.Rebirth(quest.heroKind, 0).rebirthNum) + " / 1";
                        break;
                    case QuestKindTitle.Cooperation2: //TODO
                        name = Title(TitleKind.Cooperation) + " 2";
                        client = "The TestTeam";
                        description = "Now that you've started to Rebirth Tier 1 a lot. (I sure hope you're getting the Exp Multiplier from the RB1 Upgrades! ) It's time to test yourself and go for Rebirth Tier 2. (Some insider knowledge : Try and get more then 20 levels of EXP multiplier!) Like the previous title, you'll gain more background efficiency. Be aware of what the Rebirth Tier 2 will reset, so it's not a shock! I know you can complete this! Perform one Rebirth Tier 2 and come back here and collect your new title reward!";
                        condition = "Rebirth Tier 2 # : " + tDigit(GameController.game.rebirthCtrl.Rebirth(quest.heroKind, 1).rebirthNum) + " / 1";
                        break;
                    case QuestKindTitle.Cooperation3: //TODO
                        name = Title(TitleKind.Cooperation) + " 3";
                        client = "The TestTeam";
                        description = "Who's ready to gain some more Background Efficiency? The next hardship will be conducting a Rebirth Tier 3.  Again, read what it will reset, so you can prepare! This one can be tricky to get enough levels, but I believe in you! Remember, EXP is your friend! Get up close and cuddly with it. Perform one Rebirth Tier 3 and come back for a shiny new reward.";
                        condition = "Rebirth Tier 3 # : " + tDigit(GameController.game.rebirthCtrl.Rebirth(quest.heroKind, 2).rebirthNum) + " / 1";
                        break;
                    case QuestKindTitle.Quester1: //TODO
                        name = Title(TitleKind.Quester) + " 1";
                        client = "Ivan, the Trainee Adventurer";
                        description = "Hi there, adventurer! You seem to be the questing type, but did you know that there are benefits to completing many, many quests? Yeah, there's a program through the Adventurer's Guild that grants the title of Quester to anyone who completes at least 100 general quests! I'm still too new to even think about doing that, but you look like you might be able to pull it off! Why don't you give a shot? I've heard having that title earns some great benefits when completing quests!";
                        break;
                    case QuestKindTitle.Quester2: //TODO
                        name = Title(TitleKind.Quester) + " 2";
                        client = "Ivan, the fledgling adventurer";
                        description = "Hey! It looks like you are doing well with your quests. I also followed your example and took on a quest, which was a success and got me out of my apprenticeship. Let's both continue to tackle quests from now on!";
                        break;
                    case QuestKindTitle.Quester3: //TODO
                        name = Title(TitleKind.Quester) + " 3";
                        client = "Ivan, a low-ranked adventurer";
                        description = "I was also successful in a few quests and the guild gave me a title for my recognition! I didn't think it was possible for me, but now I know I can do it if I try. I'm going to try to take on more quests.";
                        break;
                    case QuestKindTitle.Quester4: //TODO
                        name = Title(TitleKind.Quester) + " 4";
                        client = "Ivan, the Promising  Adventurer";
                        description = "When I accepted a quest, the receptionist said to me, 'You are a promising newcomer'. I don't know if I can live up to his expectations, but I was a little happy to hear that about me!";
                        break;
                    case QuestKindTitle.Quester5: //TODO
                        name = Title(TitleKind.Quester) + " 5";
                        client = "Ivan, a mid-level adventurer";
                        description = "I've been able to achieve some decent results within the guild, so I'm not being called a newbie as much anymore. Even though I still feel like a rookie. But now that I've graduated from being a newbie, I have to work hard and live up to expectations!";
                        break;
                    case QuestKindTitle.Quester6: //TODO
                        name = Title(TitleKind.Quester) + " 6";
                        client = "Ivan, a well-known adventurer";
                        description = "Lately, when I go back to the guild, I've been approached by various adventurers for help. I wonder if it's because I've been taking on a lot of quests and doing them well? I'm feeling more confident about myself now!";
                        break;
                    case QuestKindTitle.Quester7: //TODO
                        name = Title(TitleKind.Quester) + " 7";
                        client = "Ivan, a high ranking adventurer";
                        description = "I was able to receive a higher rank than before when I successfully completed a quest to defeat a monster that was said to be difficult to subjugate. I feel like I'm finally getting closer to you.";
                        break;
                    case QuestKindTitle.Quester8: //TODO
                        name = Title(TitleKind.Quester) + " 8";
                        client = "Ivan, the Popular Adventurer";
                        description = "When I go to town, I'm getting approached by townspeople. It seems that my success in completing many quests has spread through the guild and to the townspeople, and now many people know about it. It's a little embarrassing, but I don't feel bad!";
                        break;
                    case QuestKindTitle.Quester9: //TODO
                        name = Title(TitleKind.Quester) + " 9";
                        client = "Ivan, the highest ranked adventurer";
                        description = "I have finally received the highest title in the guild after taking on many difficult quests! I never thought I could grow this much from being a apprentice. I'm glad I've continued to steadily take on quests up to this point!";
                        break;
                    case QuestKindTitle.Quester10: //TODO
                        name = Title(TitleKind.Quester) + " 10";
                        client = "Ivan, an elite adventurer";
                        description = "After becoming the highest rank adventurer, I continued to take on quests and was eventually appointed to the elite force directly under the guild! There is nothing more honorable than this. Even now, I cannot match the number of quests you have cleared. I started taking quests for you, and I think it's in part because of you that I made it into the elite corps. Thank you!";
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
                        name = "Trouvez Mon Époux 1";
                        client = "Wakana";
                        description = "Excusez moi, avez vous un moment? Mon époux est disparu il y à quelques jours. Mes voisins disent qu'ils l'ont vu aller dans la caverne des Slimes, mais je ne suis pas douée avec les Slimes alors je ne peux pas aller voir. Pouvez-vous y aller pour moi?"
                            + " Quand vous aurez complété <color=orange>Village Slime: Zone 2</color> 100 fois, Vous pouvez essayer le Dongeon Slime par l'onglet<color=orange>Dongeon</color> dans la map monde. Gardez à l'esprit qu'il vous faudra une <color=orange>Orbe Portail</color> pour entrer dans les Dongeons, que vous pouvez obtenir par exemple dans les quêtes globales et journalières."
                            + " Avant de tenter un dongeon, le boutton <color=orange>Simulation</color> dans la map monde peut être utile. Il simule chaque zone et vous informe si vous pouvez la compléter ou non.";
                        break;
                    case QuestKindGeneral.CompleteDungeon0_1:
                        name = "Trouvez Mon Époux 2";
                        client = "Wakana";
                        description = "Oh, vous ne l'avez pas trouvé, je suis si triste. Peut-être qu'il est dans une autre caverne... Je sais pas. S'il-vous-plaît, pouvez-vous aller à sa recherche à nouveau? JE suis inquiète pour lui et je ne peux rien faire.";
                        break;
                    case QuestKindGeneral.CompleteDungeon0_2:
                        name = "Trouvez Mon Époux 3";
                        client = "Wakana";
                        description = "Quoi! Vous l'avez vu se faire kidnapper par des Slimes dans les profondeurs de la caverne!? Oh mon Dieu! Je suis certaine qu'il y a un repère de Slimes dans le coin, c'est là qu'il sera. S'il-vous-plaît S'il-vous-plaît S'il-vous-plaît, allez le retrouver!";
                        break;
                    case QuestKindGeneral.DefeatNormalMagicSlime:
                        name = "Une Dette Impayée";
                        client = "Jeune Sorcière";
                        description = "J'étudiais près des arbres quand un Slime Magique a demandé d'emprunter ma plume. J'aurais dû savoir que quelque chose n'allait pas quand il l'a avalé, mais je lui ai tout de même fait confiance. Maintenant je n'ai rien pour écrire et mes devoirs pour l'académie sont en retard. Si vous pouvez leur apprendre une leçon je vous renverrez volontier l'ascenseur en faisant un édredon de leurs chapeaux.";
                        break;
                    case QuestKindGeneral.DefeatGreenMagicSlime:
                        name = "Envoyer Un Message";
                        client = "Claire La Sorcière";
                        description = "\"Je faisais des travaux en extra pour compenser pour mes devoirs manquant quand un des Slimes Magiques m'a lancé ce papier.\" Elle vous tend un morceau de papier chifonné vous invitant pour le thé dans la ville des Slimes Magiques. \"Je suis pas une experte, mais je dirais que c'est définitivement un piège. Spécialement considérant que mes amis à l'école sont trop nerveux pour m'inviter. J'ai besoin que tu y ailles pour moi et que tu renvoies ces menteurs de Slime Magiques d'où ils viennent.\"";
                        break;
                    case QuestKindGeneral.DefeatYellowBat:
                        name = "La Mine 1";
                        client = "Brick";
                        description = "Comme vous êtes sur le point d'entrer dans la caverne, vous voyez un petit géant qui ne porte qu'une salopette, un casque de mineur et une pioche. Il se gratte la tête et s'adresse à vous avec une expression inquiète. \"Excusez-moi. Je dois miner pour le patron mais les chauve-souris me foutent les jetons. Pouvez-vous me donner un coup de main pour les éliminer?Je ne peux pas vous donner de minerais mais vous pouvez prendre la pierre.\"";
                        break;
                    case QuestKindGeneral.DefeatRedBat:
                        name = "La Mine 2";
                        client = "Mira";
                        description = "Une petite femme dans une tenue d'acier épaisse et un casque de mineur vous approche, \"Merci pour votre aide avec les chauve-souris. Brick a un regain de motivation récemment. Si vous pouviez aller un peu plus profond dans la mine on pourrait trouver du minerais de meilleur qualité, et un peu de pierre que tu pourrais garder.\"";
                        break;
                    case QuestKindGeneral.DefeatGreenBat:
                        name = "La Mine 3";
                        client = "Mira";
                        description = "Avec toutes ces Chauve-Souris hors du chemin, on a vu quelques gemmes scintiller plus bas dans les mines. Les mecs et moi on comprend que c'est dangereux de descendre plus profondément. Alors on veut bien partager notre butin.";
                        break;
                    case QuestKindGeneral.DefeatPurpleBat:
                        name = "Un endroit sombre et lugubre";
                        client = "Brick";
                        description = "Brick s'approche de vous comme vous revenez de la mine avec une expression inquiète, \"C'est bien que vous soyez de retour sain et sauf. Avez-vous vu la chose bouger? C'est comme si quelque chose vivait dans le vide des ténèbres. Je sais pas pourquoi, mais j'ai un mauvais présentiment. Pourrais-tu aller dans les ténèbres et t'en occuper pour nous? Je suis certain que tout le monde serrait heureux de dormir sur leurs deux oreilles.\"";
                        break;
                    case QuestKindGeneral.DefeatBlueBat:
                        name = "Une Étrange Requête";
                        client = "Mademoiselle Fizzle";
                        description = "Comme vous vous dirigez vers la Caverne des Chauve-Souris, un garçon manqué avec d'épaisses lunettes et un sourrire prononcé vous observe du haut d'un rocher. En remuant une potion flamboyante dans sa main elle s'addresse à vous, \"Toi. Ouais, toi. Je me demandais si tu pourrais m'apporter du guano des Chauve-Souris. J'ai un projet sur lequel je travaille, ce sera génial tu verra.\"";
                        break;
                    case QuestKindGeneral.BringToEnchantShard:
                        name = "Le Gros";
                        client = "Mademoiselle Fizzle";
                        description = "Hey, merci pour ton aide plus tôt. Mes expérimentations sont presque terminées. Tout ce qu'il me faut c'est un peu d'Huile de Slime pour servir de base, un peu de Tissu Magique pour l'emballer, et de la Soie d'Areignée pourune mèche suffisament longue. Ensuite on pourra créer une bombe assez grosse pour faire exploser un million de chauve-souris. Pour la science, bien entendu.";
                        break;
                    case QuestKindGeneral.CompleteDungeon2_0:
                        name = "Manoir Hanté 1";
                        client = "Hansen";
                        description = "Avez-vous entendu la rumeur d'après laquelle le bois est hanté par un esprit maléfique ? Il faut que j'aille vérifier par moi-même. On m'a dit qu'il y a du bruit provenant des murs, mais je suis trop occupé pour aller voir moi-même. Très, très occupé.";
                        break;
                    case QuestKindGeneral.CompleteDungeon2_1:
                        name = "Manoir Hanté 2";
                        client = "Hansen";
                        description = "Argh, c'était les araignées qui faisaient tout ce bruit. Je veux dire de GROSSES araignées. Pourriez-vous en éliminer quelques unes pour moi ? J'ai beaucoup de travail à faire dans la forêt aujourd'hui.";
                        break;
                    case QuestKindGeneral.CaptureNormalSpider:
                        name = "Manoir Hanté 3";
                        client = "Hansen";
                        description = "Les araignées ne cessent de débarquer, hein ? Il doit y avoir une reine. Malheureusement je suis malade et je ne peux le faire moi-même, donc pourriez-vous prendre quelques filets et capturer des araignées pour moi ? Je vous aiderai à trouver la reine après ça.";
                        break;
                    case QuestKindGeneral.CompleteDungeon2_2:
                        name = "Manoir Hanté 4";
                        client = "Une Étrange Note";
                        description = "J'ai trouvé la reine des araignées. Du moins, une des reines. Malheureusement, elle m'a capturé. Envoyez de l'aide !";
                        break;
                    case QuestKindGeneral.CaptureYellowSlime:
                        name = "Pour Tout En Jaune !";
                        client = "Cercle Jaune";
                        description = "Un individu vêtu d'une robe Jaune de la tête aux pieds se tient juste au dehors du village slime, bondissant d'excitement sur ses talons alors qu'il étire le cou pour avoir une meilleure vue sur la ville. Alors que vous le dépassez, il vous salue frénétiquement, vous invitant à le rejoindre. \"S'il vous plaît, je passais par ce village et j'ai vu un éclair jaune se faufiller entre deux édifices, mais je n'ai pas pu le rattraper. Pouvez-vous l'attraper pour moi ? S'il vous plaît, s'il vous plaît, s'il vous plaît !\" Bon, vous ne pouvez dire non à ce visage. Allons-y !";
                        break;
                    case QuestKindGeneral.CaptureNormalFairy:
                        name = "Le Roi Des Fées 1";
                        client = "Un Garçon Perdu";
                        description = "Un jeune garçon, renifflant et couvert de bleus, vous approche. \"J'voulais juste jouer dans le jardin quand j'ai trébuché sur une fée. Ensuite elles m'ont intimidé jusqu'à ce que je sorte. Pouvez-vous m'aider à savoir si je peux y retourner sans danger ?\"";
                        break;
                    case QuestKindGeneral.CaptureBlueFairy:
                        name = "Le Roi Des Fées 2";
                        client = "Pierre Joyeux";
                        description = "Les jeunes aventuriers comme toi viennent toujours empirer les choses. Ne sais-tu pas que pour chaque fée tuée, deux autres reviennent ? Tu dois les capturer si tu veux les empêcher de te terroriser. Je vais également faire de mon mieux.";
                        break;
                    case QuestKindGeneral.CaptureYellowFairy:
                        name = "Le Roi Des Fées 3";
                        client = "Pierre Joyeux";
                        description = "S'il y a une chose que les fées respectent, c'est une fée plus puissante qu'elles. Tout ce que nous avons à faire c'est créer la fée la plus forte de l'histoire de l'univers. Trouve une fée puissante et on l'emmenera aux jardins pour éclaircir les choses.";
                        break;
                    case QuestKindGeneral.CaptureRedFairy:
                        name = "La Reine Des Fées";
                        client = "Pierre Joyeux";
                        description = "Tu as fait du bon travail en m'aidant, je n'en attendais pas moins. Cependant, c'est ici que nos chemins se séparent. Prends bien soin de la fée que je t'ai donné.";
                        break;
                    case QuestKindGeneral.CaptureGreenFairy:
                        name = "Charmes pour la Chance";
                        client = "Panemu";
                        description = "Est-ce que vous savez que certains croient que les ailes de fées portent chance ? On aurait bien besoin d'un meilleur karma en ce moment. Si vous m'aidez à faire ces charmes, nous pourrons les distribuer, juste au cas où il reste de l'énergie négative dans la ville.";
                        break;
                    //Fox
                    case QuestKindGeneral.CaptureNormalFox:
                        name = "Amis Renards";
                        client = "Moine aux Histoires Nombreuses";
                        description = "Avez-vous entendu la rumeur que le temple du renard local est possédé par un neuf-queues ? C'est horrible de voir les renards attaquer les gens à vue. Pourriez-vous capturer quelques renards pour qu'on puisse les aider ? Si vous les ramenez dans des filets, nous pourrons les relocaliser dans une petite ville dans la forêt. La rumeur dit que les renards peuvent y parcourir ses rues légalement, tout comme les gens.";
                        break;
                    case QuestKindGeneral.BringFoxTails:
                        name = "Ville des Renards";
                        client = "Moine aux Histoires Nombreuses";
                        description = "Les renards dans la ville vont bien mais ils se sentent seuls sans leurs vieux amis. Je vois que vous avez une jolie collection de monstres dans votre village. Pourriez-vous en envoyer quelques uns dans le village dans la forêt ? Ils peuvent encourager les renards, et ramasser des trucs sur leur chemin du retour vers votre village.";
                        break;
                    case QuestKindGeneral.CaptureGreenFox:
                        name = "Construire un Meilleur Temple";
                        client = "Moine aux Histoires Nombreuses";
                        description = "Il semble que le neuf-queues ne quittera pas le temple de si tôt. Donc les renards n'ont nul part où aller. Peut-être que vos petits amis peuvent être utiles à nouveau. Les renards ne font pas confiance aux humains, mais si vos companions les aident à construire un temple, ils pourraient rester dans ce temple et ne pas se soucier du neuf-queues. Les villageois de la forêt ne laisseraient jamais leur précieux renards être blessés, après tout.";
                        break;
                    case QuestKindGeneral.CapturePurpleFox:
                        name = "Un Voyage de Mille Lieues";
                        client = "Moine aux Histoires Nombreuses";
                        description = "Oh, c'est encore vous. Merci encore pour votre aide. Je viens d'aller à la guilde pour demander une petite faveur. Il y a eu un accident récent dans le village de la forêt où un voyageur est venu passer la nuit. C'était plutôt déstabilisant et je crois que je dois aller faire un pèlerinage pour me remettre les idées en place. Ce voyage n'est pas sûr. Même sans ça, le voyage sera très solitaire, et j'apprécierais grandement que l'un de vos petits amis se joigne à moi.";
                        break;
                    //Devilfish
                    case QuestKindGeneral.CaptureBlueDevilFish:
                        name = "Par Delà l'Etang";
                        client = "Brick";
                        description = "Héé, on a creusé jusqu'au fond puis on s'est trouvé un lac. Le patron dit qu'c'est ok de prendre une pause pour nager un peu, pendant qu'on creuse une autre mine, mais j'crois pas que ce soit une si bonne idée. Même les plus épeurants prennent leurs précautions. P't'être que vous pourriez jetter un oeil dans le lac, et trouver une preuve qu'y'a des monstres là-dedans. J'préfère pas me faire mordre le fond de culotte.";
                        break;
                    case QuestKindGeneral.DefeatBlueDevilFish:
                        name = "Hérésie";
                        client = "Cryt";
                        description = "Écoute fiston, as-tu entendu parler de l'hérésie dernièrement ? J'te le dis tout de suite, c'est mon lac et ma maison, je vis ici depuis longtemps, et j'ai jamais eu de problèmes de poisson démon. Jusqu'à c'qu'un homme commence à venir avec ses jouets de poisson démon pour faire peur aux touristes. Personne le crois bien sûr. Tout le monde sait que les poissons démons sont rouges, pas bleus. Qu'est-ce tu dirais d'arrêter la prochaine ligne de faux poissons démons avant que les touristes soient trop agités ?";
                        break;
                    case QuestKindGeneral.DefeatBossDevilFish:
                        name = "Pêche à la Dynamite";
                        client = "Mademoiselle Pétille";
                        description = "Vous savez, je ne suis pas fan de débats philosophiques sur l'existence des poissons démons, ou la moralité en général. Alors j'essaie de me tenir loin des petites disputes dans lesquelles les gens se mêlent. Je sais qu'il y a quelque chose de gros là-dedans, et je ne nagerai pas tant que ce ne sera pas parti. Si je viens à ouvrir la caverne sous-marine, vous vous en chargerez dans sa propre tanière. Correction, dans son ancienne tanière.";
                        break;
                    case QuestKindGeneral.BringFairyFoxFish:
                        name = "Pour Le Revêtement";
                        client = "Mademoiselle Pétille";
                        description = "Vous savez, je suis une personne pragmatique. Nous n'avons toujours pas de preuve indéniable que les poissons démons existent. Bien entendu, je vous ai vu revenir avec plusieurs gros poissons ressemblant à des monstres l'autre jour. Donc mieux vaut prendre des précautions. Cependant, les bombes à l'épreuve de l'eau sont difficiles à produire. On aura besoin de matériaux de poisson démon pour le revêtement, quelques Queues de Renard pour l'aider à couler rapidement, et suffisament de Poudre de Fée pour illuminer le ciel. Ça devrait suffire pour les tenir loin de la rive pour un petit moment.";
                        break;
                    //Treant
                    case QuestKindGeneral.DefeatNormalTreant:
                        name = "Wombat Rescapés 1";
                        client = "Croque-Requin, le berger de Wombat";
                        description = "Vous voyez une grosse bête poilue approcher. En fait, non, en regardant de plus près c'est un homme... qui transporte une bête poilue. La créature est énorme et cache complètement l'homme et tout ce que vous voyez c'est une tignasse de cheveux blonds qui dépasse au dessus d'un visage poilu qui vous regarde en mâchant tranquillement. \"B'jour, 'pouvez nous donner un coup d'main ? Z'avez une minute ? J'ai un tas de wombats, la prunelle de mes yeux, mais des monstres ont attaqué ma ferme et ces casse-pieds sont partis plus loin. Nan, les wombats, pas les monstres. Bah, eux aussi. Enfin, j'aimerais les ravoir, mais tant que ma ferme est ruinée, ça sert a rien hein ? Aideriez-vous un type comme moi, en trouvant du bois solide pour réparer ma ferme ? J'le ferais moi-même, mais Gus ici présent est tout ce qu'il me reste et j'peux pas couper du bois en tennant mon gros gaillard. Non, Papa te laisse pas partir p'tit casse-pieds poilu.\" Vous laissez l'étrange homme parler à son étrange créature.";
                        break;
                    case QuestKindGeneral.DefeatYellowTreant:
                        name = "Wombat Rescapés 2";
                        client = "Croque-Requin, le berger de Wombat";
                        description = "Ma p'tite beauté, c'est exactement ce qui m'faut pour réparer ma ferme. Avec ça, Gus pis moi on peut réparer la ferme en deux mouvements de queue de wombat ! (Vous regardez Gus, mais il ne semble pas avoir de queue) J'déteste vous demander encore de l'aide, mais comme vous explorez et aventurez et peu importe c'que vous faites quand vous aidez pas les pauvres casse-pieds, pourriez-vous garder un oeil surc'qui reste de mon troupeau ?Les wombats sont une espèce invasive ici. Y' font de mal à personne, mais 'sont à peu près invulnérables et rien peut leur faire de mal non plus. Z'auriez dû voir quand la mère de Gus a décidé de faire la sieste au milieu de la route principale vers la ville. Une guilde d'aventuriers entière a essayé et échoué à la déplacer, jusqu'à c'que quelqu'un pense à la réveiller et l'attirer hors du chemin avec des carottes. Ça' pris des heures pour que l'embouteillage se règle! Ça nous a valu d'bonnes histoires de beuverie ! Enfin, on a tous deux du travail à faire, et rester assis à parler va pas réparer ma ferme.";
                        break;
                    case QuestKindGeneral.DefeatRedTreant:
                        name = "Wombat Rescapés 3";
                        client = "Croque-Requin, le berger de Wombat";
                        description = "Mon troupeau ! Ma ferme ! Ils sont r'venu grâce à vous ! Sauf qu'y m'faut encore vot' aide. Ces casse-pieds qui ont détruit ma ferme dans l'temps sont encore dans les alentours. J'crois qu'ils me r'gardaient l'autre nuit. J'voyais rien, mais Gus était assis à fixer dans l'noir pendant des lunes, et j'vous jure, le son des branches qui bougent, c'tait pas naturel. Ça m'a fait rappeler des souvenirs terribles de mon temps dans l'armée, quand j'tais en charge d'entrainer une unité de wombats de combat. C'tait terrible, trop même pour les histoires de beuverie. J'referrai pas face à ça, mais ça veut dire que j'peux pas me battre près d'mon troupeau, même pas pou' les défendre. Donc s'tu pourrais, tu vois, combattre ces monstres pour moi et me laisser garder mes bébés en sûreté ?";
                        break;
                    case QuestKindGeneral.TheBiggerOne: //TODO
                        name = "The Bigger One";
                        client = "Papa Beemeritus";
                        description = "Slimes & Spiders? Pfft! We're about to start working with the serious ingredients to blow those Devilfish right out of the lake! Go collect Bat Wings to form a base, a few Fox Tails to wrap it in, and some Fairy Dust to serve as a magical binding. With these Papa promises magically explosive results!";
                        break;
                    case QuestKindGeneral.TheBiggestOne: //TODO
                        name = "The Bigger One";
                        client = "Miss Fizzle";
                        description = "Are we ready for another science lesson? I see you've built enough bombs for Devilfish. Maybe we should build the biggest one yet for Unicorns? Let's start the collection of Fish Scales, Carved Branches, and Thick Fur! After all this is in the name of Science and discovery!";
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
        return base.Material(kind);
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
                return "Or";
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
                return "Exclure les Équipements Enchantés";
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
                return "Désactiver les Notifications pour le Labo";
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
                return "Cacher les Défis Complétés";
            case ToggleKind.UseMultiplierForAutoBuyShop:
                return "Utilisez le multiplicateur en haut à gauche pour l'auto-achat de familier et la file d'améliorations";
            case ToggleKind.AutoAreaProgressPassiveHero:
                return "Transporte les Héros Passifs dans la Zone de Progression Auto";
            case ToggleKind.SDDisableDamageText:
                return "Désactive les Textes de Dégâts";
            case ToggleKind.SDDisableAllLogs:
                return "Désactive tous les Messages";
            case ToggleKind.SDDisableDungeonCoinLog:
                return "Gain de Pièce de Donjon";
            case ToggleKind.SDDisableFameLog:
                return "Gain de Renommée";
            case ToggleKind.SDDisableGradeUp:
                return "Désactive le Texte et les Particules de Montée de Classe de Héros";
            case ToggleKind.SDDisableParticle:
                return "Désactive les Particules";
            case ToggleKind.SDDisableAttackEffect:
                return "Désactive les Effets des Attaques";
            case ToggleKind.AutoBuyRebirthUpgrade1:
                return "Achat Auto des Améliorations de Réincarnation (Classe 1)";
            case ToggleKind.AutoBuyRebirthUpgrade2:
                return "Achat Auto des Améliorations de Réincarnation (Classe 2)";
            case ToggleKind.AutoBuyRebirthUpgrade3:
                return "Achat Auto des Améliorations de Réincarnation (Classe 3)";
            case ToggleKind.AutoBuyRebirthUpgrade4:
                return "Achat Auto des Améliorations de Réincarnation (Classe 4)";
            case ToggleKind.AutoBuyRebirthUpgrade5:
                return "Achat Auto des Améliorations de Réincarnation (Classe 5)";
            case ToggleKind.AutoBuyRebirthUpgrade6:
                return "Achat Auto des Améliorations de Réincarnation (Classe 6)";
            case ToggleKind.SDAutoDodge:
                return "Auto Esquive";
            case ToggleKind.SDAutoLeaveAndRetry:
                return "Auto Quitter & Réessayer";
            case ToggleKind.SDAutoProgress:
                return "Auto Progression";
            case ToggleKind.SDAutoPowerups:
                return "Achat Auto des Pouvoirs";
            case ToggleKind.SDUseAutoProgressionTargetFloor:
                return "Etage Visé lors de l'Auto Progression";
            case ToggleKind.SDFastResult:
                return "Écourter l'Écran de Résultat de Super Donjon";
            case ToggleKind.SDAutoUseRefreshTicket:
                return "Auto Utilisation de Ticket de Rafraîchissement";
        }
        return base.Toggle(kind);
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
                tempName = "Limite d'Or Rocheuse +";
                tempEffect = "Effet de l'Amélioration Limite d'Or Rocheuse + " + percent(upgrade.effectValue);
                tempNextEffect = "Effet de l'Amélioration Limite d'Or Rocheuse + " + percent(upgrade.nextEffectValue);
                break;
            case RebirthUpgradeKind.CrystalGoldCap:
                tempName = "Limite d'Or Cristallique +";
                tempEffect = "Effet de l'Amélioration Limite d'Or Cristallique + " + percent(upgrade.effectValue);
                tempNextEffect = "Effet de l'Amélioration Limite d'Or Cristallique + " + percent(upgrade.nextEffectValue);
                break;
            case RebirthUpgradeKind.LeafGoldCap:
                tempName = "Limite d'Or Végétale +";
                tempEffect = "Effet de l'Amélioration Limite d'Or Végétale + " + percent(upgrade.effectValue);
                tempNextEffect = "Effet de l'Amélioration Limite d'Or Végétale + " + percent(upgrade.nextEffectValue);
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
                tempName = "Limite d'Or Rocheuse ++";
                tempEffect = "Effet de [Limite d'Or Rocheuse +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Limite d'Or Rocheuse +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1CrystalGoldCapBoost:
                tempName = "Limite d'Or Cristallique +";
                tempEffect = "Effet de [Limite d'Or Cristallique +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Limite d'Or Cristallique +] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T1LeafGoldCapBoost:
                tempName = "Limite d'Or Végétale ++";
                tempEffect = "Effet de [Limite d'Or Végétale +] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Limite d'Or Végétale +] + " + percent(upgrade.nextEffectValue, 0);
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
                tempEffect = "Gain de Points de Réincarnation Classe 2 + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Gain de Points de Réincarnation Classe 2 + " + percent(upgrade.nextEffectValue, 0);
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
                tempName = "Limite d'Or Rocheuse +++";
                tempEffect = "Effet de [Limite d'Or Rocheuse ++] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Limite d'Or Rocheuse ++] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2CrystalGoldCapBoost:
                tempName = "Limite d'Or Cristallique +++";
                tempEffect = "Effet de [Limite d'Or Cristallique ++] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Limite d'Or Cristallique ++] + " + percent(upgrade.nextEffectValue, 0);
                break;
            case RebirthUpgradeKind.T2LeafGoldCapBoost:
                tempName = "Limite d'Or Végétale +++";
                tempEffect = "Effet de [Limite d'Or Végétale ++] + " + percent(upgrade.effectValue, 0);
                tempNextEffect = "Effet de [Limite d'Or Végétale ++] + " + percent(upgrade.nextEffectValue, 0);
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
        string tempString = "Vous gagnerez <color=green>" + tDigit(rebirth.RebirthPointGain()) + " Points de Réincarnation</color> de Classe " + tDigit(rebirth.tier + 1) + " si vous vous réincarnez maintenant !";
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
        return base.RebirthPointGainKind(kind);
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
        return base.AutoRebirthInfo(id);
    }

    //Challenge
    public override string ChallengeType(ChallengeType type)
    {
        switch (type)
        {
            case global::ChallengeType.RaidBossBattle:
                return "Raid de Boss";
            case global::ChallengeType.SingleBossBattle:
                return "Boss Solo";
            case global::ChallengeType.HandicappedBattle:
                return "Boss avec Handicap";
            case global::ChallengeType.SuperDungeon:
                return "Super Donjon";
        }
        return ChallengeType(type);
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
        return base.HandicapString(kind);
    }

    //ExpeditionMilestone
    public override string ExpeditionMilestoneString(int id, string text)
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
            case 11: return "Les Familiers dans une Expédition persistent après une AM (seulement le premier emplacement jusqu'à l'Accomplissement AM1 #65)";
            case 12: return "Le progrès des Expéditions persiste après une AM (requiert l'Accomplissement AM1 #65)";
            case 13: return "Effet Passif des Expéditions + 25%";
            case 14: return "Vitesse des Expéditions + 25%";
            case 15: return "Effet d'Expédition Passif [Entraînement de Terrain] + " + text;
            case 16: return "Gain d'EXP d'Expédition + " + text;
            case 17: return "Récompense d'Expédition + " + text;
            case 18: return "Effet d'Expédition Passif + " + text;
            case 19: return "Vitesse d'Expédition + " + text;
            case 20: return "Stats de Familier + " + text;
            case 21: return "Limite d'Or + " + text;
        }
        return base.ExpeditionMilestoneString(id);
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
            case 6: return "Gain de Maîtrise d'Équipement + 20%";
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
            case 21: return "Emplacement de Collection d'Équipement + 1";
            case 22: return "Gain de Maîtrise de Capacité + 100%";
            case 23: return "Limite d'Or + 100%";
            case 24: return "Gain d'Or + 100%";
            case 25: return "Efficacité des Pièces Slime + 25%";
            case 26: return "Emplacement d'Inventaire d'Enchantement + 10";
            case 27: return "Effet des Béndictions + 100%";
            case 28: return "Emplacement de Familier Actif + 5";
            case 29: return "Limite de Niveau des Catalyseurs + 25";
            case 30: return "Emplacement de Set de Capacité + 1";
            case 31: return "Niveau de Bâtiment de Ville + " + text;
            case 32: return "Limite de Loyauté de Familier + " + text;
            case 33: return "Améliore l'effet des améliorations de Gain de Ressources";
            case 34: return "Réduit l'incrément du coût par Nv des améliorations de Gain de Ressources par " + text;
            case 35: return "Limite de Rang de Familier + " + text;
            case 36: return "Les Files d'Amélioration/Alchimie persistent après une Ascension Monde";
            case 37: return "Les Capacités restent au Rang 1 après une Ascension Monde ";
            case 38: return "Vitesse de Nitro + 0.5x (Consommation + 0.5 par sec)";
            case 39: return "La configuration de héros Actifs/Passifs dans l'onglet Guilde persiste après une AM";
            case 40: return "Débloque l'Allocation d'Essence dans le Labo (Requiert l'Accomplissement AM1 #30)";//"Catalyst setup persists on WA (requires WA1 Accomp #30)";
            case 41: return "La Limite d'Eau Mystérieuse persiste après une AM sans compter les améliorations manquantes";
            case 42: return "La configuration de Recherche de ville persiste après une AM (Requiert l'Accomplissement AM1 #60)";
            case 43: return "Gain d'Or + 250%";
            case 44: return "Les Rang S de Maîtrise de Quêtes Générales persistent après une AM";
            case 45: return "([Nv. Guilde Max Atteint (au plus 200)]-100)/2 Points de Guilde Bonus après une nouvelle AM";
            case 46: return "Réduit la courbe de gains réduits d'Eau Mystérieuse allouée sur les Essences";
            case 47: return "Les Parchemins de Lotterie tirent seulement des valeurs plus hautes";
            case 48: return "Intérêt sur les Pièces Slime + " + text;
            case 49: return "Gain de Score d'Invasion + " + text;
        }
        return base.MissionMilestoneString(id);
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
            case 13: return "Vaincre le Raid de Boss [Florzporbe Nv 100] en 8 heures ou moins";
            case 14: return "Vaincre le Raid de Boss [Florzporbe Nv 100] en 3 heures ou moins";
            case 15: return "Vaincre le Raid de Boss [Florzporbe Nv 100] en une heure ou moins";
            case 16: return "Vaincre le Raid de Boss [Florzporbe Nv 100] en 20 minutes ou moins";
            case 17: return "Vaincre le Raid de Boss [Florzporbe Nv 100] en 5 minutes ou moins";
            case 18: return "Vaincre le Raid de Boss [Aranetta Nv 150] en 8 heures ou moins";
            case 19: return "Vaincre le Raid de Boss [Aranetta Nv 150] en 3 heures ou moins";
            case 20: return "Vaincre le Raid de Boss [Aranetta Nv 150] en une heure ou moins";
            case 21: return "Vaincre le Raid de Boss [Aranetta Nv 150] en 20 minutes ou moins";
            case 22: return "Vaincre le Raid de Boss [Aranetta Nv 150] en 5 minutes ou moins";
            case 23: return "Vaincre le Raid de Boss [Gardien Kor Nv 200] en 8 heures ou moins";
            case 24: return "Vaincre le Raid de Boss [Gardien Kor Nv 200] en 3 heures ou moins";
            case 25: return "Vaincre le Raid de Boss [Gardien Kor Nv 200] en une heure ou moins";
            case 26: return "Vaincre le Raid de Boss [Gardien Kor Nv 200] en 20 minutes ou moins";
            case 27: return "Vaincre le Raid de Boss [Gardien Kor Nv 200] en 5 minutes ou moins";
            case 28: return "Vaincre le Raid de Boss [" + str1 + "] en 8 heures ou moins";
            case 29: return "Vaincre le Raid de Boss [" + str1 + "] en 3 heures ou moins";
            case 30: return "Vaincre le Raid de Boss [" + str1 + "] en une heure ou moins";
            case 31: return "Vaincre le Raid de Boss [" + str1 + "] en 20 minutes ou moins";
            case 32: return "Vaincre le Raid de Boss [" + str1 + "] en 5 minutes ou moins";
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
            case 78: return "Les Équipements Uniques sont préservés lors d'une Ascension Monde";
            case 79: return "Le Niveau des Catalyseurs est préservé lors d'une Ascension Monde";
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
            case 93: return "Les zones de la région " + str1 + " débloquées et leur # de Complétions sont préservés";
        }
        return base.AscensionMissionString(id);
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
        return base.WarriorSkillsString(id);
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
        return base.WizardSkillsString(id);
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
            case 7: return "Vitesse de Déplacement + " + percent(value) + " tant que cette Capacité est équipée";
            case 8: return "+50% de dégâts pour cette Capacité par mètre parcouru";
            case 9: return "Portée de l'Effet de cette Capacité + ";
            case 10: return "Nombre de Coups de cette Capacité + 1";
            case 11: return "Temps de Recharge de cette Capacité -25%";
            case 12: return "À Définir";
            case 13: return "Résistance aux Débuffs +" + percent(value, 2) + " tant que cette Capacité est équipée";
        }
        return base.AngelSkillsString(id);
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
            case 9: return "Disparait momentanément et apparait de nouveau près de l'ennemi le plus éloigné pour lui ingliger des dégâts";
            case 10: return " chance de voler un matériau laché à chaque utilisation";
        }
        return base.ThiefSkillsString(id);
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
            case 9: return "Dégâts de Lumière +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 10: return "Dégâts des Ténèbres +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 11: return "Tire une flèche vers le centre qui attire tous les ennemis à l'écran vers celle-ci";
            case 12: return "Permet de se déplacer aux bords de l'écran pour échapper à la portée au corps à corps des ennemies avec une pénalité de vitesse dans le mode Mouvement Auto";
        }
        return base.ArcherSkillsString(id);
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
            case 18: return "Vitesse de Déplacement & Vitesse d'Attaque des Familiers + ";
            case 19: return "Gain de Points de Loyauté +" + percent(value, 2) + " tant que cette Capacité est équipée";
            case 20: return "Gain d'EXP des Familiers : + ";
            case 21: return "À Définir";
            case 22: return " chance de capturer le monstre cible sans utiliser de piège à chaque utilisation ( + ";
            case 23: return "\n- Pour la capture, le piège adapté doit être débloqué dans le Magasin et l'ennemi doit être à un niveau capturable";
            case 24: return "Essaye de capturer tous les monstres de la même couleur que la cible dans une zone d'effet";
            case 25: return "La priorité est donnée à la capture de monstres dont un piège de la même couleur est équipé";
        }
        return TamerSkillsString(id);
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
            case 11: return " fois";
            case 12: return "Magasin Épique [Réinitialisation de Prestige de Zone/Donjon]";
            case 13: return "Total Complété #";
            case 14: return "Difficulté ";
            case 15: return "Améliorations de Prestige de Zone  ( Points : ";
            case 16: return "MAX";
            case 17: return "récompense unique";
            case 18: return "Niveau + !!!";
            case 19: return "Vous vous êtes Réincarné !";
            case 20: return "Dégâts infligés à vous";
            case 21: return "DPS";
            case 22: return "<size=20>Convocation<size=18>\n- Cliquer pour convoquer tous les héros passifs en arrière-plan.\n- Vous ne pouvez pas utiliser ceci dans un Donjon ou un Défi.";
            case 23: return "Maj + Clic pour déplacer tous les héros dans leur zone favorite.";
            case 24: return "Magasin Épique [ Convocation ]";
            case 25: return "Bâtiment [Cartographeur] Nv ";
            case 26: return " INVASION DE MONSTRE EN COURS !";
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
            case 41: return "Classe + !!!";
            case 42: return "Raccourci : Espace";
            case 43: return "Zone Sûre";
        }
        return base.BattleControllerUIString(id);
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
            case 7: return "La Fabrication n'est pas possible sur les Antiquités.";
        }
        return base.EquipmentDictionaryUIString(id);
    }

    public override string EquipmentTalismanUIString(int id)
    {
        switch (id)
        {
            case 0: return "Auto Désassembler les Talismans";
            case 1: return "Type : Talisman";
            case 2: return "# Désassemblé";
            case 3: return "\n- Reste actif tant qu'équipé dans un Emplacement d'Utilitaire";
            case 4: return "\n- Gain de Fragments lors du désassemblage : ";
            case 5: return "<size=20><u>Effet Équipé par # de Pile</u><size=18>";
            case 6: return " Fragments";
            case 7: return "\n\n<color=yellow>Ce Talisman ne peut pas être désassemblé.</color>";
            case 8: return "<size=20><u>Effet Passif par # Désassemblé</u><size=18>";
            case 9: return "<size=20><u>Effet Passif Total Courant</u><size=18>";
        }
        return base.EquipmentTalismanUIString(id);
    }

    public override string LabMenuUIString(int id)
    {
        switch (id)
        {
            case 0: return "Auto Étendre";
            case 1: return "Auto Désassembler";
        }
        return base.LabMenuUIString(id);
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
        return base.SaveManagerString(id);
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
        return base.SettingMenuUIString(id);
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
        return base.BonusCodeUIString(id);
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
            case 9: return "Multiplication de la Vitesse de Déplacement par ";
            case 10: return "Bénédiction de Maîtrise de Capacité";
            case 11: return "Multiplication de la Maîtrise de Capacité par ";
            case 12: return "Bénédiction de Maîtrise d'Équipement";
            case 13: return "Multiplication de la Maîtrise d'Équipement par ";
            case 14: return "Bénédiction de Gain d'Or";
            case 15: return "Multiplication des Gains d'Or par ";
            case 16: return "Bénédiction de Gain d'EXP";
            case 17: return "Multiplication des Gains d'EXP par ";
        }
        return base.BlessingString(id);
    }

    public override string PlaytestBonusDeadlineString(int id)
    {
        switch (id)
        {
            case 0: return "<color=yellow>Limite de temps pour le reçu : 22 Août</color>";
        }
        return base.PlaytestBonusDeadlineString(id);
    }
    public override string AchievementString(int id, double value = 0, string valueString = "")
    {
        switch (id)
        {
            case 0: return "Compléter toutes les quêtes de tutoriel";
            case 1: return "Débloquer la Mage";
            case 2: return "Débloquer l'Ange";
            case 3: return "Débloquer le Voleur";
            case 4: return "Débloquer l'Archer";
            case 5: return "Débloquer la Dompteuse";
            case 6: return "Utiliser " + tDigit(value) + " Nitro en tout";
            case 7: return "Capturer " + tDigit(value) + " monstres en tout";
            case 8: return "Ouvrir " + tDigit(value) + " Coffre(s) au Trésor";
            case 9: return "Vaincre " + tDigit(value) + " Mimique(s)";
            case 10: return "Vaincre " + tDigit(value) + " invasion(s)";
            case 11: return "Marcher autour du monde [" + valueString + " mètres]";
            case 12: return "Marcher autour du monde 2 fois [" + valueString + " mètres]";
            case 13: return "Marcher autour du monde 3 fois [" + valueString + " mètres]";
            case 14: return "Marcher autour du monde 5 fois [" + valueString + " mètres]";
            case 15: return "Marcher vers la Lune [" + valueString + " mètres]";
            case 16: return "Marcher vers la Lune aller-retour [" + valueString + " mètres]";
            case 17: return "Marcher vers le Soleil [" + valueString + " mètres]";
            case 18: return "Dépenser " + tDigit(value) + " Pièces Épiques";
            case 19: return "Débloquer " + valueString;
            case 20: return "Gagner tous les Équipements Uniques de la Collection " + valueString;
            case 21: return "Gagner " + valueString + " Or en tout";
            case 22: return "Gagner " + valueString + " Pierres en tout";
            case 23: return "Gagner " + valueString + " Cristaux en tout";
            case 24: return "Gagner " + valueString + " Feuilles en tout";
            case 25: return "Atteindre le Niveau de Guilde " + tDigit(value);
            case 26: return "Vaincre le Raid de Boss [" + valueString + "]";
            case 27: return "Atteindre le Niveau de Potion total " + tDigit(value);
            case 28: return "Gagner " + valueString + " Points d'Alchimie en tout";
            case 29: return "Gagner " + tDigit(value) + " Équipement en tout";
            case 30: return "Avoir " + tDigit(value) + " Emplacements d'Arme pour le héros " + valueString;
            case 31: return "Avoir " + tDigit(value) + " Emplacements d'Armure pour le héros " + valueString;
            case 32: return "Avoir " + tDigit(value) + " Emplacements de Bijou pour le héros " + valueString;
            case 33: return "Avoir " + tDigit(value) + " Emplacements d'Utilitaire pour le héros " + valueString;
            case 34: return "Avoir " + tDigit(value) + " Emplacements de Capacité de Classe pour le héros " + valueString;
            case 35: return "Avoir 8 Emplacements de Capacité Global";
            case 36: return "Effectuer une Réincarnation de Classe " + tDigit(value) + " avec le héros " + valueString;
            case 37: return "Effectuer une Ascension Monde " + tDigit(value) + " fois";
            case 38: return "Jouer à IEH pendant " + tDigit(value) + " jour(s) de temps de jeu";
            case 39: return "Jouer à IEH pendant " + tDigit(value) + " semaine(s) de temps de jeu";
            case 40: return "Jouer à IEH pendant " + tDigit(value) + " mois(s) de temps de jeu";
            case 41: return "Jouer à IEH pendant " + tDigit(value) + " année(s) de temps de jeu";
        }
        return base.AchievementString(id);
    }

    public override string AreaTableUIString(int id)
    {
        switch (id)
        {
            case 0: return "Simulation en Cours...";
            case 1: return "Vous pouvez simuler les résultats des combats dans chaque zone en même temps.\n<size=18>Raccourci : Maj + S";
            case 2: return "Étes-vous sûr de vouloir rentrer dans ce donjon ?\nCela coûtera";
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
            case 17: return "\n- Les Expansions d'Eau Mystérieuse et les Catalyseurs";
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
            case 38: return "\n- Les Quêtes Journalières et de Titres couramment acceptées devront être acceptées de nouveau après une Ascension Monde";
            case 39: return "\n- Les objets dans les emplacements d'inventaire étendu ne seront disponibles qu'après les avoir débloqués de nouveau";
            case 40: return "\n- Les Familiers actifs après le # de familiers activables seront automatiquement désactivés";
            case 41: return "\n- Vous pourrez recommencer les missions complétées mais vous ne recevrez pas de Pièces Épiques venant d'elles";
            case 42: return "Ascension Monde de Classe " + tDigit(wa.tier + 1);
            case 43: return "\n- Hero Grade, Fame and Super Ability Points";//?
            case 44: return "\n- Etage Maximal de Super Donjon Atteint et Limite de # d'Achats du Magasin de Rubis";
            case 45: return "\n- Paliers de Classe, Améliorations de Super Donjon et l'onglet Stats de Magasin de Rubis";
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
            case 20: return "Ce monstre ne lâche pas de matériau";
            case 21: return "Effet de Familier Actif";
            case 22: return "Effet de Familier Passif";
            case 23: return "Stats du Familier";
            case 24: return "Rang de Familier Total";
            case 25: return "Palier de Rang de Familier Total";
        }
        return "";
    }


    public override string EquipmentSlotsString(int id, int slotAmt = 1)
    {
        switch (id)
        {
            case 0: return "Emplacement d'Arme du Guerrier";
            case 1: return "Emplacement d'Arme de la Mage";
            case 2: return "Emplacement d'Arme de l'Ange";
            case 3: return "Emplacement d'Arme du Voleur";
            case 4: return "Emplacement d'Arme de l'Archer";
            case 5: return "Emplacement d'Arme de la Dompteuse";
            case 6: return "Emplacement d'Armure du Guerrier";
            case 7: return "Emplacement d'Armure de la Mage";
            case 8: return "Emplacement d'Armure de l'Ange";
            case 9: return "Emplacement d'Armure du Voleur";
            case 10: return "Emplacement d'Armure de l'Archer";
            case 11: return "Emplacement d'Armure de la Dompteuse";
            case 12: return "Emplcement de Bijou du Guerrier";
            case 13: return "Emplcement de Bijou de la Mage";
            case 14: return "Emplcement de Bijou de l'Ange";
            case 15: return "Emplcement de Bijou du Voleur";
            case 16: return "Emplcement de Bijou de l'Archer";
            case 17: return "Emplcement de Bijou de la Dompteuse";
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
            case 2: return "Raid de Boss";
            case 3: return "Participant";
            case 4: return "Tous les héros couramment actifs vont rejoindre le combat !";
            case 5: return "Le coût en Orbe Portail double toutes les 5 entrées dans un Super Donjon.";
            case 6: return "Entrées Courantes : ";
            case 7: return "Entrées Totales : ";
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
            case 12: return "Gain de Ressources ";
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
            case 27: return "Étendre la Limite d'Eau Mystérieuse jusqu'à " + text;
            case 28: return "Débloque un nouveau Catalyseur";
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
            case 41: return "Multiplie l'Effet des Équipements par ";
            case 42: return "Points de Dictionnaire Gagnés : " + text;
            case 43: return "Débloque la [Fabrication] dans l'onglet Labo";
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
            case 91: return "Efficacité des Pièces Slime + " + text + "%";
            case 92: return "Gain d'Or + " + text + "%";
            case 93: return "Octroie de l'intérêt sur les Pièces Slime en votre possession toutes les 10 minutes : ";
            case 94: return "Quantité de réapprovisionnement de matériaux dans le Magasin ";
            case 95: return "Multiplie la Limite de Pièces Slime par ";
            case 96: return "Arène Mystique";
            case 97: return "Dégâts sur les Boss de Défi ";
            case 98: return "Complétion de Défi de Raid " + text;
            case 99: return "Débloque les Défis avec Handicap";
            case 100: return "Débloque l'onglet [ Super Donjon ]";
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
            case 126: return "Niveau Maximal d'Amélioration de Dictionnaire + " + text;
            case 127: return "Ajoute une récompense de \"Ticket de Rafraîchissement\" dans les Quêtes Journalières [Cartographeur " + text + "]";
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
            case 4: return "<size=17>Dame Emelda, la Fée Sorcière, a gouverné pendant longtemps sur les Fées de Glainn Caillte, depuis que la Reine des Fées a succombé à une malédiction qui l'a transformé en pierre de façon permanente. Intervenant pour prendre la place de la souveraine pétrifiée, la haine de Dame Emelda envers toute créature non féerique a influencé les Fées de Glainn Caillte à devenir tordues et hostile. Sa maîtrise de la magie de feu est bien connue, et il est dit que dès qu'elle voit quelqu'un qui n'appartient pas à son espèce, elle l'incinère immédiatement. Il est dit que l'assassinat de cette bête pourrait restaurer la gentillesse des Fées qu'elles avaient il y a des siècles, mais il est aussi possible que leur corruption soit complète et qu'elles ne puissentplus être telles qu'elles étaient avant la mort de la Reine des Fées. Dans tous les cas, le danger envers le monde qu'est Dame Emelda reste, et beaucoup souhaiterait voir son règne se terminer.</size>";
            case 5: return "<size=17>Nari Sune, le Renard aux Neuf Queues, a beaucoup de rumeurs circulant autour d'elle. En tant que farceur connu, Nari Sune peut se transformer en plein de créatures différentes et peut même contrôler tout pouvoir natif que cette créature peut posséder. Généralement isolée et content d'ignorer l'état du monde, Nari Sune a récemment été découverte en train d'interférer avec les affaires politiques de différents royaumes, se transformant en leaders variés pour implanter conflit et discontentement. Les intentions de Nari Sune sont inconnues, mais ses actions ont donné lieu à des guerres, des coups d'état, et à la mort de milliers de personne dans le chaos qu'il s'en suit. Attention à tous ceux à sa recherche, car elle est ancienne est rusée, ce qui lui a permis de survivre depuis si longtemps.</size>";
            case 6: return "<size=17>Octopabo, la Terreur des Profondeurs, tourmente les paquebots de commerce depuis maintenant soixante ans. Peu de choses sont connues à son propos, car il existe peu de survivants, et ceux qui existent ont péri peu après leur échapée à cause du poison mortel se trouvant dans l'encre noire d'Octopabo. Ce que l'on sait est qu'il aveugle complètement ses victimes, même en dehors de l'eau, car son encre reste dans l'air, formant d'épais nuages noirs. Lorsque ces nuages se dispersent enfin, le bâteau ainsi que son équipage ont disparus, comme si entièrement avalés par la bête. Seules les âmes les plus stupides et courageuses essayent de réclamer la prime multidécennale sur cette créature machiavélique.";
            case 7: return "<size=17>Bananoutan, le Bananattaqueur, est une créature mystérieuse. Brandissant des bananes en tant que dagues, cette créature peut en invoquer une infinité, bombardant une zone dans une évisceration totale de bananes. Certains pensent qu'il est l'esprit d'un arbre qui a été maudit par une sorcière pour ne pas avoir poussé de fruit suite à se demande, cependant personne ne connait la réelle origine de ce monstre. Cependant, il est su qu'il agit rarement d'une façon amicale, et il devient immédiatement hostile lorsqu'il est approché. Il est dit que seuls ceux portant le symbole de la Grande Banane peut s'en approcher, mais personne ne sait vraiment ce que c'est ou comment l'acquérir.";
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
            case 3: return "# de Limite d'Achat : " + text;
            case 4: return "Ceci coûte normalement " + text + ", mais il est GRATUIT la première fois !";
            case 5: return "Le prix augmentera après l'achat.";
            default: return base.EpicStoreMenuString(id, text);
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
            case 6: return "Arène Mystique E" + text;
            default: return base.ChallengeHandicappedString(id, text);
        }
    }
    public override string EquipMenuString(int id, string text = "")
    {
        string tempStr;
        switch (id)
        {
            case 0:
                tempStr = "<size=20>Boîte de Désassemblage<size=18>";
                tempStr += "\n- Glissez et déposez un objet ici pour le désassembler.";
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
            case 1: return "Reste actif tant qu'équipé dans un Emplacement d'Utilitaire";
            case 2: return "Temps de Recharge";
            case 3: return "Effet Équipé";
            case 4: return "Niveau de Monstre Capturable" + text + " ou moins";
            case 5: return "Il augmente avec le Niveau du Héros et le Titre [Étude de Monstre].";
            case 6: return "Vous ne pouvez pas capturer des monstres de type 'colorés' avec cet objet.";
            case 7: return "Ce Talisman ne peut pas être désassemblé.";
            case 8: return "Effet Passif obtenu après désassemblage";
            case 9: return "Cette antiquité consomme " + text + " Nitro par sec lorsqu'elle est équipée";
            default: return base.EquipMenuString(id, text);
        }
    }
    public override string ExpeditionCtrlString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Niveaux d'Expédition";
            case 1: return "Paliers d'Expédition";
            case 2: return "Nv total";
            case 3: return "Êtes-cous sûr de vouloir annuler cette expédition ?";
            case 4: return "Nous ne recevrez pas de récompense.";
            case 5: return "Équipe";
            case 6: return "Récompense de Complétion";
            case 7: return "Commencer";
            case 8: return "Annuler";
            case 9: return "Êtes-vous sûr de vouloir annuler <color=yellow>TOUTES</color> les expéditions ?";
            default: return base.ExpeditionCtrlString(id, text);
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

            case SlimeBankUpgradeKind.SlimeCoinCap2:
                name = "Limite de Pièce Slime 2";
                description = "Multiplie la Limite de Pièce Slime";
                effect = "par " + percent(1 + upgrade.EffectValue(isNextValue));
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
            case 1: return "En attente dans " + text;
            case 2: return "EXP";
            case 3: return "EXP gagnés dans la dernière minute";
            case 4: return "Points d'Abilité disponibles";
            case 5: return " Héros sont couramment actifs";
            case 6: return " Héro est couramment actif";
            case 7:
                return optStrL
                + "\n- En plus du héros couramment en jeu, vous pouvez activer les autres héros en arrière-plan " +
                "\naprès avoir reçu la Quête de Titre [Preuve de Reinc.]."
                + "\n- " + text + " héros peuvent être activés en même temps." +
                "\n- Vous pouvez augmenter cette limite à travers une amélioration d'Ascension Monde.";
            case 8: return "Ce héros est couramment actif.";
            case 9: return "Ce héros est couramment actif en arrière-plan.\nEfficacité des Gains en Arrière-Plan : ";
            case 10: return "vous pouvez activer ce héros en arrière-plan.\nEfficacité des Gains en Arrière-Plan : ";
            case 11: return "Finissez la Quête de Titre [Preuve de Reinc.] pour permettre l'Activation en Arrière-Plan.";
            case 12: return "Vous jouez couramment le héros " + text;
            case 13: return "Jouer le héros " + text;
            case 14: return "Niveau visé pour l'auto achat";
            default: return base.GuildMenuString(id, text);
        }
    }
    public override string MissionString(MISSION mission, string text = "")
    {
        switch (mission.kind)
        {
            case MissionKind.Clear:
                return "Compléter cette Zone";
            case MissionKind.SaveHp:
                return "Compléter cette Zone avec PV > " + text;
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
            default: return base.MissionString(mission, text);
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
            case 5: return "Vous êtes couramment à vote max de Nitro.";
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
            case 16: return "complétée " + text + " fois";
            default: return base.OfflineBounusString(id, text);
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
            case 13: return "1 Orbe Portail";
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
            default: return base.SwarmString(id, text);
        }
    }

    public override string FieldCurseString(AREA area)
    {
        string tempStr = "";
        bool isCurse = false;
        if (area.curseAbilityMul < 1)
        {
            if (isCurse) tempStr += ", ";
            tempStr += "Réduit les Points d'Abilité de " + percent(area.curseAbilityMul, 4);
            isCurse = true;
        }
        if (area.cursePetBasicStatsMul < 1)
        {
            if (isCurse) tempStr += ", ";
            tempStr += "Réduit les Stats des Familiers de " + percent(area.cursePetBasicStatsMul);
            isCurse = true;
        }
        if (area.curseMoveSpeedMul < 1)
        {
            if (isCurse) tempStr += ", ";
            tempStr += "Réduit la Vitesse de Déplacement de " + percent(area.curseMoveSpeedMul);
            isCurse = true;
        }
        if (area.curseSkillRangeMul < 1)
        {
            if (isCurse) tempStr += ", ";
            tempStr += "Réduit la Portée des Capacités de " + percent(area.curseSkillRangeMul);
            isCurse = true;
        }
        if (area.curseAOEMul < 1)
        {
            if (isCurse) tempStr += ", ";
            tempStr += "Réduit la Taille des Zones d'Effet de " + percent(area.curseAOEMul);
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
            default: return base.ExpeditionMenuString(id, text);
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
            default: return base.QuestString(id, text);
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
            case 7: return "La Réincarnation de Classe 3 remet à zéro le Niveau des Équipements et leur Maîtrise du héros couramment actif hero en plus de ce que celle de Classe 1 remet à zéro, ce qui veut dire que vous pouvez gagner des Points de Dictionnaire à nouveau. Les Améliorations de Réincarnation de Classe 3 booste les améliorations des Classes inférieures et permet d'augmenter le Niveau de Héros et le Niveau des Équipements plus haut et plus rapidement !";
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
            default: return base.RebirthMenuString(id, text);
        }
    }
    public override string ResourceCtrlString(int id, string text = "", string text2 = "")
    {
        switch (id)
        {
            case 0: return "Boosteur de Nitro";
            case 1: return "Temps de Jeu x" + text;
            case 2: return "Vous gagnez du Nitro en étant hors-ligne";
            case 3: return "Vous avez couramment";
            case 4: return "L'Objet du Magasin Épique [Chargeur de Nitro Max] peut donner du Nitro après la Limite de Nitro.";
            case 5: return "Cliquer pour Activer/Désactiver";
            case 6: return "Tant que le Boosteur de Nitro est Activé, la Vitesse du Jeu est";
            case 7: return "x" + text;
            case 8: return text;
            case 9: return ", " + text + " Nitro est consommé par sec";
            case 10: return " + Flèche Haut/Bas pour augmenter/réduire la vitesse.";
            case 11: return "Pièce de Slime";
            case 12: return "Gagné lorsque l'Or dépasse la Limite d'Or";
            case 13: return "Utilisé pour les Améliorations de Banque Slime, qui sont débloquées par la Banque Slime au Niveau de Guilde 35";
            case 14: return "Vous avez couramment";
            case 15: return "Gagné dans les 10 dernières minutes";
            case 16: return "Efficacité de Gain : ";
            case 17: return " d'or dépassant la limite";
            case 18: return "Détails de l'Efficacité des Gains";
            case 19: return "Base à travers les Améliorations";
            case 20: return "Ville";
            case 21: return "Gagné lors de la défaite d'un monstre";
            case 22: return "Vous avez couramment";
            case 23: return "Gagné pendant la dernière minute";
            case 24: return "Or Gagné au Total";
            case 25: return "Détails de la Limite D'Or";
            case 26: return "Vous avez couramment";
            case 27: return "Gagné pendant la dernière minute";
            case 28: return "Tout monstre lâche " + text + text2 + " lors qu'ils sont vaincus par le/la ";
            case 29: return " ou le/la ";
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
            case 42: return "Maj + F pour montrer les coûts entiers (Max x100)";
            case 43: return "Détails de la Limite de Nitro";
            default: return base.ResourceCtrlString(id, text);
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
            default: return base.TitleSceneString(id, text, text2);
        }
    }
    public override string LabMenuString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Reste actif quand équipé dans un Emplacement d'Utilitaire";
            case 1: return "Temps de Recharge";
            case 2: return "Vous gagnez " + text + " Points d'Alchimie pour chaque alchimie";
            case 3: return "Cet effet est boosté par la potion de classe inférieure";
            case 4: return "Vous avez besoin d'un Emplacement d'Utilitaire";
            case 5: return "Niveau Max";
            case 6: return "File Disponible";
            default: return base.LabMenuString(id, text);
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
            default: return base.SettingMenuString(id, text);
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
            default: return base.UpgradeMenuString(id, text);
        }
    }
    public override string WorldAscensionMissionString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Récompense de Point d'AM " + text;
            default: return base.WorldAscensionMissionString(id, text);
        }
    }
    public override string WorldMapString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Vous avez " + text + " " + Basic(BasicWord.PortalOrb);
            default: return WorldMapString(id, text);
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
                effect = "Réinitialise les Abilités et redonne les Points d'Abilité du Héros couramment en jeu.";
                break;
            case EpicStoreKind.GuildAbilityReset:
                name = "Réinitialisation d'Abilité de Guilde";
                effect = "Réinitialise les Abilités de Guilde et récupère les Points d'Abilité de Guilds dépensés." +
            " Gardez à l'esprit que les objets dans les emplacements d'inventaire étendus seront indisponibles jusqu'à qu'ils soient de nouveau débloqués." +
            " Il est aussi possible qu'il faille réallouer l'Eau Mystérieuse dans les catalyseurs une nouvelle fois.";
                break;
            case EpicStoreKind.DictionaryUpgradeReset:
                name = "Réinitialisation d'Améliorations de Dictionnaire";
                effect = "Permet de réinitialiser les Améliorations de Dictionnaire de façon permanente. Il sera possible de les réinitialiser et de récupérer ses points à tout moment.";
                break;
            case EpicStoreKind.AdvancedAutoDisassemblingEquipment:
                name = "Auto Désassemblage d'Équipement Avancé";
                effect = "Débloque une option dans le Dictionnaire d'Équipement qui permet d'éviter de désassembler les équipements enchantés.";
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
                name = "Emplacement d'Inventaire d'Équipement + 10";
                effect = "Débloque 10 Emplacements d'Inventaire d'Équipement.";
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
                name = "Emplacement d'Inventaire de Bijou + 1";
                effect = "Débloque 1 Emplacement d'Inventaire de Bijou pour tous les héros.";
                break;
            case EpicStoreKind.SkillTenacity:
                name = "Tenacité de Capacité";
                effect = "Débloque une option dans l'onglet Capacité qui permet d'autoriser le lancer d'une capacité aussi tôt que son Temps de Recharge est écoulé peu importe sa Consommation de PM, avec une réduction proportionnelle de l'effet et du gain de maîtrise si la Consommation de PM n'est pas atteinte de ([PM courant du héros] / [Consommation de PM de la capacité])%, avec un minimum de 10%";
                break;
            case EpicStoreKind.EquipmentTenacity:
                name = "Tenacité d'Équipement";
                effect = "Permet d'équiper un équipement pour lequel les requis ne sont pas remplis, avec une réduction proportionnelle de son effet de ([Niveau du Héros et ses Abilités] / [Abilités requises de l'Équipement])%, avec un minimum de 10%. Il permet aussi d'utiliser les enchantements sur les objets équipés.";
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
                name = "Emplacement d'Auto Désassemblage d'Équipement + 5";
                effect = "Augmente le nombre d'Emplacements d'Auto Désassemblage d'Équipement par 5. Cliquez sur un équipement dans le dictionnaire pour assigner/enlever l'auto désassemblage lorsqu'il est récolté.";
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
                name = "Emplacement d'Équipement d'Utilitaire + 1";
                effect = "Débloque 1 Emplacement d'Équipement d'Utilitaire pour tous les héros.";
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
                name = "Accès Facile [Équipement]";
                effect = "Débloque des boutons dans l'onglet Équipement qui permet d'accéder aux emplacements d'équipement des héros en arrière-plan sans avoir à changer de héros.";
                break;
            case EpicStoreKind.AdvancedAutoDisassembleCraftedEquipment:
                name = "Auto-Désassemblage des Équipement Fabriqués Avancé";
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
                name = "Collection d'Équipement";
                effect = "Débloque des boutons dans l'onglet Équipement qui permet d'avoir différentes collections d'équipement - Tout achat supplémentaire augmente le nombre d'emplacements de collections par le nombre acheté.";
                break;
            case EpicStoreKind.RegularDailyChest:
                name = "Coffre Journalier";
                effect = "Vous recevrez quelques récompenses ci-dessous de façon aléatoire chaque jour !\n- 0%/25%/50%/100% de la Limite de Nitro (peut dépasser la limite)\n- 0/1/2/4 heures de bénédiction d'EXP (seulement pour le héros courant)\n- 0/1/2/5 Orbes de Portail\n- <sprite=\"epiccoin\" index=0> 50/100/250 Pièces Épiques";
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
                effect = "Débloque un bouton qui permet de mettre le jeu en pause dans l'onglet Options. Vous pouvez toujours intéragir avec le jeu pendant qu'il est mis en pause, pour changer les équipements et les capacités, acheter des améliorations, ou changer de héros, sans que le Temps de Jeu n'avance. Cela pause aussi le temps des Accomplissements d'Ascension Monde.";
                break;
            case EpicStoreKind.PurpleFoxMastery:
                name = "Maîtrise du Renard Violet";
                effect = "Débloque une option dans l'onglet Options qui permet à la Capacité du Familier Renard Violet de se baser sur le niveau de maîtrise de l'équipement (Nv 10) au lieu du niveau maximum. (Le familier doit être activé pour que l'effet marche.)";
                break;
            case EpicStoreKind.EquipmentEnchantFilter:
                name = "<size=21>Filtres Avancés d'Auto Désassemblage d'Équipements Enchantés";
                effect = "<size=19>Débloque un bouton [Personnaliser] dans le Dictionnaire qui permet l'utilisation d'un Filtre d'Enchantement, qui permet de spécifier quels enchantements (y compris leur niveau minimum) à exclure de l'option d'auto désassemblage. Vous devez d'abord acheter [Auto Désassemblage d'Équipement Avancé] pour que cela fonctionne.";
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
            case EpicStoreKind.OneClickChallenges:
                name = "Défis en un clic";
                effect = "Effectuer un clic droit sur un onglet de Défi, tel que \"Raid de Boss\", commencera/réclamera tous les défis pour le Héros Actif dans cet onglet sauf ceux qui ont déjà été complétés. Les récompenses récupérées à travers la complétion des défis seront aussi réclamées. ";
                break;
            case EpicStoreKind.ScrollFilter:
                name = "Filtre de Parchemin";
                effect = "Débloque un bouton dans l'onglet Équipement qui active un filtre de parchemin, qui indique que les parchemins tels que les Parchemins de Suppression ou les Parchemins de Lotterie ne seront pas gardées après avoir réclamé les récompenses de complétion de donjons/défis. ";
                break;
            case EpicStoreKind.PersistentSkillSet:
                name = "Capacités Persistante";
                effect = "Permet de garder les Capacités équipées après une Ascension Monde. Requiert le Palier de Mission de Zone #1000. Les Collections de Capacités sont aussi gardées après une Ascension Monde. Les capacités dans les emplacements temporaires seront désactivées après une Ascension Monde jusqu'à que l'emplacement soit débloqué de nouveau.";
                break;
            case EpicStoreKind.AutoAreaProgression:
                name = "Auto Progression de Zone";
                effect = "Débloque un bouton dans la Carte Monde qui permet aux héros d'aller dans chaque zone et d'atteindre le # de Complétions que vous avez établi, en partant du Village des Slimes 1. Quand vous avez atteint le # de Complétions donné, les héros se déplaceront automatiquement vers la prochaine Zone. Le nombre de complétions est basé sur la difficulté courante de la Zone. ";
                break;
            case EpicStoreKind.NitroCapExpansion:
                name = "Expansion de Nitro Max";
                effect = "Augmente le Maximum de Nitro de 10% par achat. \nEffet Courant : Multiplie le Maximum de Nitro par <color=green>" + percent(1d + 0.1d * game.epicStoreCtrl.Item(EpicStoreKind.NitroCapExpansion).purchasedNum.value) + "</color>\n";
                break;
            case EpicStoreKind.AdvancedAutoRebirthLazyQuestingMode:
                name = "Auto Réincarnation Avancée [ Mode Quête Automatique ]";
                effect = "<size=18>Débloque un bouton qui permet au héros de voyager vers la Zone de Quête de n'importe quelle Quête Générale que vous avez désignée en tant que Quête Favorite. Après avoir complété une Quête, le héro procèdera à la prochaine Zone de Quête de la prochaine Quête Favorite. L'Auto-Réincarnation ne se fera qu'une fois que toutes les Quêtes Favorites sont complétées. Pour utiliser cette fonctionalité, v[Quête Favorite] doit être acheté.";
                break;
            case EpicStoreKind.Nitro_OfflineBonus:
                name = OfflineBounusString(8);
                effect = "Gagne [" + OfflineBounusString(8) + "] suivant la Nitro en votre possession. La Nitro est convertie en temps hors-ligne utilisant un ratio de 1 Nitro par seconde pour les premières 24 heures, puis pour chaque prochaines 24 heures le coût augmente de 1 par seconde par achat. La Limite de # d'Achat est réinitialisée chaque jour.";
                break;
            case EpicStoreKind.AutoMysteriousWaterAdder:
                name = "Auto Ajouteur d'Eau Mystérieuse";
                effect = "Débloque la fonction de chargement d'Allocation d'Essences dans le Labo pour automatiquement allouer l'Eau Mystérieuse aux Essences dès que vous en produisez 0.1/sec, ou juste après une Ascension Monde. Requiert la complétion du Palier de Mission de Zone #1150 et l'Accomplissement d'AM1 #30.";
                break;
            case EpicStoreKind.SmartUseOfAnvils:
                name = "Utilisation Intelligente des Enclumes";
                effect = "Lorsqu'elle est appliquée à un équipement, une [Enclume de Forge] n'est appliquée que jusqu'à la valeur maximale pour éviter son gaspillage.";
                break;
            case EpicStoreKind.EasyAccessChallenge:
                name = "Accès Facile [Défi]";
                effect = "Débloque des boutons dans l'onglet Défi qui vous permet de tenter des défis avec les héros en arrière-plan.";
                break;
            case EpicStoreKind.SuperAbilityReset:
                name = "Réinitialisation de Super Abilités";
                effect = "Réinitialise les Super Abilités et rembourse les Points de Super Abilités dépensés du Héros couramment en jeu.";
                break;
            case EpicStoreKind.SDPowerupReset:
                name = "Réinitialisation de Pouvoir de Super Donjon";
                effect = "Réinitialise le Rang des Pouvoirs de Super donjon et rembourse les Topazes dépensés.";
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
            case HelpKind.Lab: return "Labo";
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
            case HelpKind.S_AreaMission: return "Mission de Zone";
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
        return base.HelpNameString(kind);
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
                tempStr += "\n- Le Voleur est un héros furtif qui inflige des <color=orange>Dégâts Physiques</color> et des <color=orange>Dégâts de Ténèbres</color>. Il a un mix de capacités de mélée et à distance. Ses deux atouts sont sa Vitesse et son taux d'Apparition d'Équipement, ce qui en fait un excellent farmeur. Il a une santé et défense plus basse, ce qui est son point faible. Le Voleur gagne des pierres lorsqu'il tue des monstres.";
                tempStr += "\n\n";
                tempStr += "<u>Archer</u>";
                tempStr += "\n- L'Archer est un héros mobile infligeant un mix de <color=orange>Dégâts Physiques</color> et de <color=orange>Dégâts Magiques</color> tout en se concentrant sur une portée longue qui garde les ennemis loin de lui. Sa santé basse est son point faible. L'Archer gagne des crystaux lorsqu'il tue des monstres.";
                tempStr += "\n\n";
                tempStr += "<u>Dompteuse</u>";
                tempStr += "\n- La Dompteuse est un héros de support qui laisse ses Familiers infliger les dégâts pour elle. Les Familiers peuvent infliger des <color=orange>Dégâts Physiques</color> comme des <color=orange>Dégâts Magiques</color> – cela dépend des Familiers. Les dégâts faibles venant de la Dompteuse est son point faible car cela prend du temps de gagner la loyauté des Familiers pour qu'ils commencent à infliger des dégâts. La Dompteuse gagne des feuilles lorsqu'elle tue des monstres.";
                tempStr += "\n\n";
                break;
            case HelpKind.Leveling:
                tempStr += "Augmenter le niveau du héros est très important. Vous recevrez des <color=orange>Points d'Abilité</color> et de l'<color=orange>EXP de Niveau de Guilde</color> à chaque fois que le héros monte de niveau.";
                tempStr += "\n\nVous pouvez gagner de l'EXP pour vos héros en tuant des monstres, en récupérant des récompenses de quêtes ou en complétant des donjons. A chaque fois que vous gagnez de l'EXP, le héros peut gagner jusqu'à <color=orange>30 niveaux à la fois</color>, les quêtes et donjons affichent un indicateur MAX si ses récompenses si cette limite est atteinte pour que vous ne perdez pas d'EXP.";
                tempStr += "\n\n";
                tempStr += "\n";
                tempStr += "<u>Astuces pour monter de niveau plus vite</u>";
                tempStr += "\n\n- Utilisez le bouton <color=orange>Simulation</color> pour chaque Zone sur la Carte Monde. Cela vous permet de voir le Temps de Complétion | Or/Sec | EXP/Sec pour chaque Zone débloquée. C'est un excellent moyen de déterminer où aller avec votre héros pour le monter de niveau.";
                tempStr += "\n\n- Augmenter le niveau du Bâtiment de Ville <color=orange>Statue de Héros</color> donne un bonus de gain d'EXP chaque fois que son niveau augmente.";
                tempStr += "\n\n- Faites en sorte de débloquer des <color=orange>Donjons</color> dans les différentes zones et vérifiez la partie <color=orange>Récompenses</color> sous l'onglet des détails du Donjon pour sa récompense d'EXP. Cela peut vastement booster le niveau du héros.";
                tempStr += "\n\n- Pendant un donjon, openez les <color=orange>Coffres au Trésor</color> car il y a une chance d'obtenir une <color=orange>Bénédiction d'EXP</color>, qui boostera vos gains d'EXP pendant un court moment. Cela augmente aussi la récompense d'EXP, si la bénédiction est toujours active lors de sa complétion.";
                tempStr += "\n\n- Quand vous atteignez la Réincarnation de Classe 1, faites en sorte d'améliorer Expérience Innée le plus possible.";
                tempStr += "\n\n- Atteindre la Rang 2 de la <color=orange>Hutte de l'Alchimiste</color> débloquera une potion d'EXP que les héros peuvent équiper dans un emplacement d'utilitaire pour augmenter ses gains d'EXP.";
                tempStr += "\n\n- Il y a aussi des objets uniques qui augmentent les gains d'EXP en tant que l'un de leurs effets.";
                break;
            case HelpKind.WorldMap:
                tempStr += "Cliquer sur l'icône de Carte en haut à droite de l'écran vous emmènera sur la Carte Monde. C'est ici où vous pourrez voir le nombre d'Orbes Portail en votre possession, et mettre la souris sur le ruban montrera les Paliers de Missions.";
                tempStr += "\n\n";
                tempStr += "<u>Régions</u>";
                tempStr += "\n- Il y a au total 10 régions dans le monde. Chaque région a 8 zones et quelques donjons. Vous pouvez cliquer sur chaque région sur la carte pour accéder aux différentes zones et donjons.";
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
                tempStr += "<u>Missions de Zone</u>";
                tempStr += "\n- Chaque Zone a deux missions au début, qui peuvent être complétées pour gagner des Pièces Épiques et qui comptent pour le compte des Paliers de Mission. Cela peut être amélioré à l'aide du Prestige de Zone détaillé ci-dessous.";
                tempStr += "\n\n";
                tempStr += "<u>Prestige de Zone</u>";
                tempStr += "\n- Vous devez effectuer une Ascension Monde pour que ce Prestige soit débloqué.";
                tempStr += "\n- Pour gagner des Points de Prestige de Zone, vous devez compléter la zone un certain nombre de fois. La fenêtre de détails de la zone vous dira le nombre de complétions requises pour gagner le prochain point.";
                tempStr += "\n- Il y a 6 différentes améliorations qui peuvent être choisies :";
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
                tempStr += "\n- L'obtention d'un titre [Preuve de Réinc.] supplémentaire augmente l'efficacité de ce héros tant qu'il est actif en arrière-plan et non pas le héros couramment en jeu.";
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
                tempStr += "<u>Couleur des Dégâts</u>";
                tempStr += "\n- Différentes couleurs sont associées aux types de dégâts qui vous sont infligés, et qui sont infligés aux monstres.";
                tempStr += "\nDégâts Physiques :";
                tempStr += "\n- Normal : Blanc";
                tempStr += "\n- Critique : Orange";
                tempStr += "\nDégâts Magiques :";
                tempStr += "\n- Normal : Jaune";
                tempStr += "\n- Critique : Rouge";
                tempStr += "\nDégâts Supplémentaires:";
                tempStr += "\n- Electrique : Jaune";
                tempStr += "\n- Huilde de Tueur : Orange";
                tempStr += "\n\n";
                tempStr += "<u>Dégâts Infligés</u>";
                tempStr += "\n- Tout d'abord, les dégâts d'une capacité sont calculés comme ceci : [ATQ/MATQ du Héros] * [Multiplicateur de Dégâts de la Capacité]";
                tempStr += "\n- ensuite, quand un monstre reçoit l'attaque de la capacité : les dégâts sont réduits par la DEF et le pourcentage de résistance élémentaire du monstre";
                tempStr += "\n- Après cela, les dégâts sont multipliés par [% de Dégâts Physiques/de Feu/de Glace/d'Electricité/de Lumière/de Ténèbres] et [% de Dégâts spécifiques au monstre à travers les effects d'Équipements uniques]";
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
                tempStr += "\n- Bénédiction de Maîtrise d'Équipement - Multiplie les gains de Maîtrise d'Équipement par un certain % pour une durée donnée.";
                tempStr += "\n- Bénédiction de Gain d'Or - Multiplie les Gains d'Or par un certain % pour une durée donnée.";
                tempStr += "\n- Bénédiction de Gain d'EXP - Multiplie les Gains d'EXP par un certain % pour une durée donnée.";
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
                tempStr += "\n- <color=orange>Maj + Clic Gauche</color> le bouton pour accepter : Accepter et se déplacer vers la quête instantanément";
                tempStr += "\n- <color=orange>Clic Droit</color> sur les boutons Global/Journalier : Accepter ou réclamer toutes les quêtes";
                tempStr += "\n- <color=orange>Clic Droit</color> sur un bouton de quête : Accepter ou réclamer la quête";
                tempStr += "\n- <color=orange>Maj + Clic Droit</color> sur un bouton de quête : Accepter et se déplacer vers la quête instantanément, ou juste réclamer la quête";
                tempStr += "\n\n";
                tempStr += "<u>Onglet Améliorations</u>";
                tempStr += "\n- <color=orange>Clic Droit</color> : Ajoute l'amélioration dans la file (Note : Cela requiert avoir des emplacements de file d'améliorations depuis un effet de Familier ou un achat dans le Magasin Épique)";
                tempStr += "\n- <color=orange>Maj + Clic Droit</color> : Enlève l'amélioration de la file";
                tempStr += "\n- <color=orange>Q</color> : Ajoute l'amélioration dans une Super File en utilisant 10 emplacements de file (Note: Ceci requiert un achat dans le Magasin Épique)";
                tempStr += "\n\n";
                tempStr += "<u>Onglet Équipements</u>";
                tempStr += "\n- <color=orange>Double Clic Gauche</color> : L'Équipement ou l'Utilitaire sera équipé/deséquipé, si un emplacement est libre.";
                tempStr += "\n- Effectuer un <color=orange>Clic Gauche</color> en maintenant <color=orange>Maj + D</color> sur un <color=orange>Objet</color> : l'Équipement/Utilitaire sera désassemblé.";
                tempStr += "\n- Effectuer un <color=orange>Double Clic Gauche</color> en maintenant <color=orange>Maj + D</color> sur le <color=orange>Bouton Désassembler</color> : Désassemble tous les objets dans l'Inventaire d'Équipement qui ne sont pas verrouillés.";
                tempStr += "\n- <color=orange>L</color> : Vérouille / Déverrouille un objet.";
                tempStr += "\n- Effectuer un <color=orange>Clic Gauche</color> en maintenant <color=orange>Maj</color> sur le <color=orange>Bouton de Tri</color> : Effectue le tri en ordre inverse.";
                tempStr += "\n- Glisser-déposer des Parchemins de Maîtrise ou des Enclumes ensemble en maintenant <color=orange>Maj</color> : Combine le même type d'effet.";
                tempStr += "\n- Glisser-déposer un Parchemin de Maîtrise sur un emplacement vide en maintenant <color=orange>Maj</color> : Sépare (valeur du multiplicateur) secondes du parchemin.";
                tempStr += "\n- Glisser-déposer une Enclume sur un emplacement vide en maintenant <color=orange>Maj</color> : Sépare (valeur du multiplicateur) de l'effet de l'enclume, mesuré en nombre entier.";
                tempStr += "\n- Glisser-déposer un objet Utilitaire dans un emplacement vide en maintenant <color=orange>Maj</color> : Sépare son # de pile basé sur le multiplicateur sélectionné en haut à gauche.";
                tempStr += "\n- <color=orange>Clic Gauche</color> sur un équipement dans le dictionnaire : Ajoute l'équipement cliqué dans la liste d'Auto Désassemblage (noté par un D). Effectuez un autre Clic Gauche pour l'enlever de la liste. (Note : Requiert des améliorations de ville ou des effets de familier)";
                tempStr += "\n- <color=orange>Maj + C</color> un équipement dans le dictionnaire : Fabrique cet objet. (Note : Requiert une amélioration de ville)";
                tempStr += "\n\n";
                tempStr += "<u>Onglet Labo</u>";
                tempStr += "\n- <color=orange>Clic Gauche</color> sur une potion: Ajoute la potion dans la file d'alchimie (Note : Requiert une file d'alchimie récupérable à travers les effets de familier ou un achat dans le Magasin Épique)";
                tempStr += "\n- <color=orange>Maj + Clic Droit</color> : Enlève la potion de la file";
                tempStr += "\n- <color=orange>Q</color> : Ajoute la potion dans la Super File en échange de 10 emplacements de file d'alchimie (Note : Requiert un achat dans le Magasin Épique)";
                tempStr += "\n\n";
                break;
            case HelpKind.Ability:
                tempStr += "<u>Statistiques</u>";
                tempStr += "\n- VTL : Augmente les PV | la DEF | la MDEF";
                tempStr += "\n- FOR : Augmente l'ATQ | la DEF";
                tempStr += "\n- INT : Augmente les PM | la MATQ | la MDEF";
                tempStr += "\n- AGI : Augmente les PM | VIT | Vitesse de Déplacement";
                tempStr += "\n- CHA : Augmente la Chance de Coup Critique | la Chance d'Apparition d'Équipement";
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
                tempStr += "\n- Chance d'Apparition d'Équipement = [BASE] + [INCREMENT] x CHA^(2/3)  :  <color=orange>Augmente la Chance d'Apparition d'Équipement ( N'inclut pas les Équipements Uniques )</color>";
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
                        tempStr += localized.BasicStats((BasicStatsKind)countI) + " " + tDigit(Parameter.baseStats[countJ][countI], 2) + " | ";
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
                        tempStr += localized.BasicStats((BasicStatsKind)countI) + " " + tDigit(Parameter.stats[countJ][countI], 2) + " | ";
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
                tempStr += "Les titres donnent des bonus uniques spécifiquement au héros qui l'a obtenu. Ils sont acquis à travers les <color=orange>Quêtes de Titre</color>. Sous l'onglet Capacité, vous pouvez cliquer sur Titre à droite pour voir les titres et bonus du héros.";
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
                tempStr += "\n- Les quêtes journalières sont une bonne source de Pièces Épiques et d'Orbes Portail.";
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
                tempStr += "<u>Quête Favorite (Achat du Magasin Épique)</u>";
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
                tempStr += "<u>Équipement</u>";
                tempStr += "\n- L'onglet Équipement est là où vous trouverez tous les équipements que vous avez ramassés sur le champ de bataille. Pour ramasser un équipement, effectuez un clic gauche sur celui-ci.";
                tempStr += "\n- Pour l'équiper, effectuez un clic gauche et glissez-déposez l'équipement depuis l'Inventaire d'Équipement vers un emplacement vide pour le bon type d'équipement.";
                tempStr += "\n- Tant que l'objet est équipé, il gagnera de la Maîtrise d'Équipement qui peut augmenter le niveau de l'objet, ce qui augmentera son pouvoir. Après avoir atteint le Niveau 10 (Maîtrise) avec ce héros, vous gagnerez un bonus passif. Tous les héros qui portent cet objet gagneront ce bonus passif.";
                tempStr += "\n- Si vous n'avez plus de place dans votre inventaire d'équipement, vous pouvez glisser-déposer un objet dans la bar de désassemblage pour récupérer des matériaux de ville.";
                tempStr += "\n- Il existe aussi un Inventaire d'Enchantements et un Inventaire d'utilitaires dans l'onglet Équipement - Référez-vous à la section d'aide du Laboratoire pour plus d'infos sur les Enchantements et les Utilitaires.";
                tempStr += "\n- Une fois qu'un équipement atteint le niveau 60, il débloquera son premier emplacement de forge. Les emplacements de forge sont débloqués au niveaux 60, 80, 100 et 120 pour chaque équipement.";
                tempStr += "\n- Vous pouvez récupérer les Enclumes requises pour forger l'équipement en complétant des expéditions, à travers des défis de boss, et à travers des donjons loin dans le jeu. Une fois qu'une enclume est obtenue, glissez-déposez la sur votre équipement de niveau 60 ou supérieur lors qu'il se trouve dans l'inventaire.";
                tempStr += "\n\n";
                tempStr += "<u>Dictionnaire</u>";
                tempStr += "\n- L'onglet Dictionnaire dans l'Équipement montre tous les équipements trouvés en jeu jusqu'à présent.";
                tempStr += "\n- A chaque fois qu'un équipement atteint le niveau 10 (pour chaque héros), vous gagnerez des points de dictionnaire qui peuvent être utilisés pour augmenter les Gain de Maîtrise d'Équipement d'un héros donne ou Chasseur d'Équipement qui augmente les chances de trouver des objets sur le champ de bataille.";
                tempStr += "\n- La rareté d'un équipement jour sur les gains de Points de Dictionnaire donnés. Commun : 1, Peu Commun : 2, Rare : 3, Super Rare : 4, et Épique : 5.";
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
                tempStr += "\n\nCatalyseurs";
                tempStr += "\n- Les catalyseurs sont débloqués après avoir dépensé les Matériaux et l'Eau Mystérieuse requise en cliquant sur le signe +.";
                tempStr += "\n- Pour équiper un catalyseur après l'avoir débloqué, il faut juste cliquer dessus. Vous verrez une ligne à double épaissure autour de celui-ci, et deux Essences apparaitront plus bas.";
                tempStr += "\n- Les catalyseurs ont aussi une chance d'effectuer un effet critique, qui procurera un objet d'Alchimie spécial qui peut être utilisé pour des améliorations dans la Ville.";
                tempStr += "\n\nEssence";
                tempStr += "\n- Chaque Catalyseur débloqué ont deux Essences attachées à ceux-ci.";
                tempStr += "\n- Chaque Conversion vous procurera un objet de cette Essence, qui est utilisé pour mixer des potions.";
                tempStr += "\n\nConversion";
                tempStr += "\n- Une Conversion arrive lorsque la barre de l'essence est pleine.";
                tempStr += "\n- Pour réduire le temps requis pour remplir la barre de l'essence, ajoutez plus d'Eau Mystérieuse / sec en appuyant sur la flèche ^.";
                tempStr += "\n- Vous avez besoin d'au moins 0.1 Eau Mystérieuse / sec pour l'appliquer à l'Essence.";
                tempStr += "\n\nPotions";
                tempStr += "\n- C'est ici que vous dépenserez vos essences pour fabriquer des potions.";
                tempStr += "\n\nPoints d'Alchimie";
                tempStr += "\n- Vous recevez des points en mixant des potions que vous pouvez utiliser pour améliorer le niveau des potions, ou sur d'autres améliorations d'alchimie dans le sous-onglet Améliorations, à côté de Potions.";
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
                tempStr += "\n- Vous pouvez activer jusqu'à 3 héros au début du jeu. Seul un héros peut être actif, qui est votre héros couramment en jeu. Les autres héros actifs sont en mode Passif. Ils continuent de faire tout comme s'ils sont actifs, mais avec un taux de gains réduit. ";
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
                tempStr += "\n- Vous gagnez des Points de Réincarnation basés sur le niveau des Équipements du Héros, sur le Niveau des Capacités du Héros à partir de 100, sur le Niveau du Héros à partir du niveau 300, à travers la complétion de différentes Quêtes Générales, et sur la distance parcourue depuis la dernière réincarnation.";
                tempStr += "\n- Bonus : Vous gagnez des niveaux pour la Capacité d'Attaque de Base basés sur le niveau du héros maximal atteint lors d'une Réincarnation de Classe 3, jusqu'au niveau 500 moins 300. Par exemple, si vous effectuez une réincarnation au Niveau 350, vous gagnerez 50 Nv pour la Capacité d'Attaque de Base pour ce héros. Vous augmenterez aussi le bonus de Réincarnation de Classe 2 (AP supplémentaire tous les 25 niveaux, et les AP de Classe 1) par un certain %. La formule est +10 x [# Réincarnation de Classe 3]^(2/3) %";
                tempStr += "\n\n";
                break;
            case HelpKind.Challenge:
                tempStr += "Les défis sont là où vous pourrez tester la puissance de votre équipe ou d'un seul héros contre de solides boss. ";
                tempStr += "\nCes Défis ne donneront qu'un bonus de complétion par Ascension Monde. Vous pouvez quand même recommencer un combat, mais aucune récompense ne sera donnée si elle a déjà été donnée pour cette Ascension Monde.";
                tempStr += "\n\n";
                tempStr += "<u>Combats de Raid de Boss</u>";
                tempStr += "\n- Les combats de Raid de Boss utilisent tous les memebres de l'équipe qui sont en mode Actif/Passif.";
                tempStr += "\n- Les héros inactifs ne participeront pas au combat. ";
                tempStr += "\n\n";
                tempStr += "<u>Combats de Boss Solo</u>";
                tempStr += "\n- Les combats de Boss Solo utilisent seulement le héros couramment actif.";
                tempStr += "\n- Toutes les capacités (y comprises globales) sont disponibles dans ce combat.";
                tempStr += "\n- Vous devez d'abord vaincre le Raid de Boss pour débloquer le Boss Solo.";
                tempStr += "\n\n";
                tempStr += "<u>Combats avec Handicap</u>";
                tempStr += "\n- Ces combats ont des limitations pendant le combat. Par exemple, aucune capacité globale n'est autorisée, aucun équipement n'est autorisé, ou seul un certain nombre d'emplacements de capacité est disponible.";
                tempStr += "\n- Vous devez d'abord vaincre le Combat de Boss Solo pour débloquer les Combats de Boss avec Handicap.";
                tempStr += "\n\n";
                tempStr += "Le bâtiment de ville [Arène Mystique] est associé à ces Défis. Vous pouvez débloquer de nouveaux étages et niveaux de boss à travers ce bâtiment de ville. ";
                break;
            case HelpKind.Expedition:
                tempStr += "Les expéditions sont là où vous pouvez envoyer vos familiers (récupéré en augmentant le rang de monstres au Rang 1 à travers des captures) dans de différentes types d'aventures.";
                tempStr += "\n\n";
                tempStr += "Pour lancer une expédition, cliquez sur un emplacement de familier vide dans l'équipe. (Cliquez sur le bouton + gris sous Equipe). Sélectionnez le familier que vous voulez envoyer. (Faites attention, ce familier ne sera plus disponible jusqu'à la fin de l'expédition). Sélectionnez l'expédition dans laquelle vous voulez envoyer votre Equipe, à travers la liste déroulante. Vous pouvez ensuite ajuster la durée de l'expédition. Plus l'expédition est longue, plus son coût en Or sera élevé. Une fois que tout est prêt, appuyez sur Commencer puis attendez la fin de l'expédition. Une fois cela fait, appuyez sur Réclamer pour récupérer les récompenses de celle-ci.";
                tempStr += "\n\n";
                tempStr += "Chaque espèce de familier aura des récompenses différentes suivant l'Expédition dans laquelle elle est envoyée. Vous pouvez augmenter les gains en changeant la longueur de l'expédition, en augmentant le Rang de l'Equipe, et le Niveau du Type d'Expédition. Les familiers gagneront aussi des Niveaux de Familier ainsi que de la distance parcourue supplémentaire comptabilisée pour l'Ascension Monde lorsqu'ils sont envoyés dans une expédition.";
                tempStr += "\n\n";
                tempStr += "Vous commencez avec 3 types d'Expéditions Lointaines. La Manufacture de Briques, la Coûpe d'Arbres, et le Ramassage d'Éclats. Les récompenses reçues à travers celles-ci sont des Matériaux de Ville, des Briques, des Billots et des Eclats.";
                tempStr += "\n\n";
                tempStr += "Monter le niveau des expéditions augmenteront votre nombre total de niveaux d'expéditions, qui peut débloquer de nouvelles expéditions ainsi qu'augmenter leurs effets passifs.";
                tempStr += "\n\n";
                tempStr += "Le bâtiment de ville [Equipe d'Aventuriers] aide au niveau des Expéditions, en débloquant de nouvelles Equipes, de nouveaux emplacements de familiers, et en donnant accès à des Recherches de Ville liées aux Expéditions.";
                break;
            case HelpKind.WorldAscension:
                tempStr += "L'Ascension Monde est un processus dans lequel le monde entier est réinitialisé, ce qui vous fait recommencer du début. Cependant, ce nouveau monde sera bien plus fort que le précédent. ";
                tempStr += "\n\n";
                tempStr += "La liste complète de ce qui est réinitialisé et de ce qui ne l'est pas est visible dans l'onglet Ascension, dans l'icône en haut à gauche (I). Vous pourrez voir ce qui est réinitialisé, ce qui ne l'est pas, ainsi que quelques mots d'avertissement. En haut à droite, vous pouvez changer la Classe de l'Ascension Monde lorsqu'elles seront débloquées. Il n'existe que l'Ascension Monde de Classe 1 en jeu couramment.";
                tempStr += "\n\n\n";
                tempStr += "<u>Ascension Monde de Classe 1</u>";
                tempStr += "\n";
                tempStr += "Il existe 8 paliers différents qu'il est possible d'atteindre. Vous aurez besoin de compléter un certain nombre de Paliers pour pouvoir effectuer une Ascension Monde. La première fois, 5 Niveaux de Paliers doivent être atteints afin d'être éligible. Ce coût augmente de 1 pour chaque Ascension Monde suivante. ";
                tempStr += "\n\n";
                tempStr += "Les 8 Paliers sont";
                tempStr += "\n- Constructeur de Ville – Celui-ci est directement lié au nombre de niveaux de vos bâtiments de ville.";
                tempStr += "\n- Emissaire de la Carte – Nombre total de Paliers de Missions de Zone atteint pendant cette Ascension Monde.";
                tempStr += "\n- Très Ressourcé - Lié au nombre de niveaux de l'onglet Général 1, des améliorations de Gain de Ressources.";
                tempStr += "\n- Explorateur du Monde – La distance totale parcourue par les héros et les familiers pendant cette Ascension Monde.";
                tempStr += "\n- Expert en Équipement - Celui-ci se concentre sur le nombre de points de dictionnaire accumulés.";
                tempStr += "\n- Désassembleur Professionnel – Nombre total de Matériaux de Ville gagnés à travers le Désassemblage d'Équipement.";
                tempStr += "\n- Réincarnateur Classe 1 – Nombre total de Réincarnations de Classe 1 effectuées à travers tous les héros pendant cette Ascension Monde. ";
                tempStr += "\n- Réincarnateur Classe 2 – Nombre total de Réincarnations de Classe 2 effectuées à travers tous les héros pendant cette Ascension Monde.";
                tempStr += "\n\n";
                tempStr += "Avec ces Paliers, chaque niveau gagné vous donnera des Points d'Ascension Monde, à ne pas confrondre avec les Niveaux de Paliers. Déplacez votre souris sur chaque Palier pour voir le nombre de points d'Ascension Monde qu'ils vous octroient ainsi que ce qui reste à faire afin d'atteindre le prochain niveau de ce palier. ";
                tempStr += "\n\n\n";
                tempStr += "Les Accomplissements sont comme des tâches qui peuvent être complétées pour récupérer des points d'Ascension Monde supplémentaires. Ceux-ci ont une limite de temps qui commence aussi tôt que l'Ascension Monde commence. Vous pouvez voir votre temps de jeu total dans l'onglet Ascension, que vous pouvez utiliser en tant que chronomètre pour les accomplissements.";
                tempStr += "\n\n";
                tempStr += "Pour chaque Accomplissement complété, vous gagnerez 1 complétion totale, ainsi que des points d'Ascension Monde supplémentaires. Il existe des récompenses si vous arrivez à compléter un bon nombre d'Accomplissements. Par exemple, si vous arrivez à compléter 5 Accomplissements, vous pourrez garder tous les objets uniques peu importe leurs Emplacements d'Enchantement après une Ascension Monde. ";
                tempStr += "\n\n";
                tempStr += "Les Point d'Ascension Monde gagnés à travers la complétion d'accomplissements sont donnés directement, et peuvent être utilisés instantanément. ";
                tempStr += "\n\n\n";
                tempStr += "Améliorations d'Ascension Monde ";
                tempStr += "\n- Boosteur d'EXP de Guilde – Multiplie le % de Gains d'EXP de Guilde pour tous les héros.";
                tempStr += "\n- Boosteur de Zone – Augmente le nombre de Complétions de Zone et la Récompense de Complétion pour chaque amélioration.";
                tempStr += "\n- Héro Actif + – Permet d'avoir 1 héros actif en plus en arrière-plan.";
                tempStr += "\n- Boost de Maîtrise de Capacité – Multiplie les gains de maîtrise de capacité pour tous les héros.";
                tempStr += "\n- Points de Pré-Réinc. Classe 1 – Cette amélioration donne des Points de Réincarnation de Classe 1 à dépenser au début d'une AM.";
                tempStr += "\n- Points de Pré-Réinc. Classe 2 – Cette amélioration donne des Points de Réincarnation de Classe 2 à dépenser lorsque la Réincarnation de Classe 2 esr débloquée à trvaers le Bâtiment Temple.";
                tempStr += "\n- Bonus de Réinc. Classe 1 + – Augmente le niveau maximal du Bonus de Points d'Abilité de Classe 1.";
                tempStr += "\n- Bonus de Réinc. Classe 2 + – Augmente le niveau maximal du Bonus de Points d'Abilité de Classe 2. ";
                tempStr += "\n- Gain de Points d'AM par Palier – Augmente le nombre de Points gagnés à chaque fois qu'un Palier est atteint.";
                tempStr += "\n- Amélioration de Nitro – Augmente la vitesse du jeu lorsque la Nitro est utilisée.";
                break;
            case HelpKind.EpicStore:
                tempStr += "Le Magasin Épique est là où vous achetez des améliorations/fonctionnalités supplémentaires tel que plus d'Emplacements d'Équipement, des améliorations liées à l'Auto-Réincarnation ou encore les Super Files pour les Améliorations et l'Alchimie. Les <color=orange>Pièces Épiques (PE)</color> sont utilisées pour acheter ces améliorations.";
                tempStr += "\nIl y a plusieurs façons de gagner des Pièces Épiques. Les <color=orange>Quêtes Journalières de Pièces Épiques</color>, les <color=orange>Complétions de Missions de Zones</color>, les <color=orange>Succès</color>, ainsi qu'en les achetant avec de l'argent réel.";
                tempStr += "\n\n";
                tempStr += "Vous pouvez avoir jusqu'à 4 Quêtes Journalières de PE chaque jour. Elles sont réinitialisées lorsqu'il est Minuit dans l'horloge locale de l'ordinateur. Vous commencez avec 1 Quête Journalière de PE, 1 à travers la complétion du palier de niveau 25 du bâtiment de ville Statue de Héros, et les 2 dernières à travers le Magasin Épique.";
                tempStr += "\n\n";
                tempStr += "Compléter les Missions de chaque Zone octroie aussi des Pièces Épiques. Vous ne gagnez des Pièces Épiques qu'une seule fous par mission, par sauvegarde. Chaque Difficulté de Zone augmente la réompense en PE. Chaque Zone a 10 difficultés différentes, ayant un maximum de 5 missions chacunes. Au total, 50 missions donnent une récompense de première complétion par Zone. Il existe 10 Régions dans le jeu, comprenant chacune 8 Zones.";
                tempStr += "\n\n";
                tempStr += "Il exite aussi des succès en jeu qui donnent des Pièces Épiques. Veuillez en voir la liste en allant dans Aide > Succès.";
                tempStr += "\n\n";
                tempStr += "Enfin, vous pouvez directement acheter des Pièces Épiques depuis de Magasin Épique en utilisant de l'argent réel.";
                tempStr += "\n\n";
                tempStr += "À ce jour, au total, il est possible de gagner <color=orange>plus de 250 000 Pièces Épiques</color> juste en compétant les Missions et les Succès en jeu.";
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
            case HelpKind.S_AreaMission:
                tempStr += StatisticAreaMissionString();
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
        tempStr += "<size=20><u>Temps de Jeu</u><size=18>";
        for (int i = 0; i < Enum.GetNames(typeof(HeroKind)).Length; i++)
        {
            int count = i;
            if (main.S.playtimes[count] > 0)
            {
                tempStr += "\n" + Hero((HeroKind)count);
                tempStr += "\n- Temps de Jeu en Jeu : " + DoubleTimeToDate(main.S.playtimes[count]);
                if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                    tempStr += "  ( Cette Ascension Monde : " + DoubleTimeToDate(main.SR.playtimes[count]) + " )";
                tempStr += "\n- Temps de Jeu Actif Réel : " + DoubleTimeToDate(main.S.playtimesRealTime[count]);
                if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                    tempStr += "  ( Cette Ascension Monde : " + DoubleTimeToDate(main.SR.playtimesRealTime[count]) + " )";
            }
        }
        tempStr += "\nTotal";
        tempStr += "\n- Temps de Jeu en Jeu : " + DoubleTimeToDate(main.allTime);
        tempStr += "\n- Temps de Jeu Actif Réel : " + DoubleTimeToDate(main.allTimeRealtime);
        tempStr += "\n\n";
        tempStr += "<size=20><u>Total de Ressources Gagnées</u><size=18>";
        tempStr += "\n- Or : " + tDigit(main.S.totalGold);
        tempStr += "\n- Pierre : " + tDigit(main.S.totalStone);
        tempStr += "\n- Cristal : " + tDigit(main.S.totalCrystal);
        tempStr += "\n- Feuille : " + tDigit(main.S.totalLeaf);
        tempStr += "\n- Pièce Slime : " + tDigit(main.S.totalSlimeCoin);
        tempStr += "\n\n";
        tempStr += "<size=20><u>Total de Ressources de Super Donjon Gagnées</u><size=18>";
        tempStr += "\n- Pièces de Donjon gagnées dans un SD : " + tDigit(main.S.totalDungeonCoinGained);
        tempStr += "\n- Pièces de Donjon sauvées d'un SD : " + tDigit(main.S.totalPermanentDungeonCoinGained);
        tempStr += "\n- Rubis : " + tDigit(main.S.totalRubyGained);
        tempStr += "\n- Morceaux de Rubis : " + tDigit(main.S.totalPieceOfRubyGained);
        tempStr += "\n- Tickets de Rafraîchissement de Coût d'Entrée : " + tDigit(main.S.totalEntryCostRefreshTicketGained);
        tempStr += "\n\n";
        tempStr += "<size=20><u>Niveau de Héros Max Atteint</u><size=18>";
        for (int i = 0; i < Enum.GetNames(typeof(HeroKind)).Length; i++)
        {
            int count = i;
            tempStr += "\n- " + localized.Hero((HeroKind)count) + " : Nv " + tDigit(main.S.maxHeroLevelReached[count]);
        }
        tempStr += "\n\n";
        tempStr += "<size=20><u>Distance Parcourue Totale</u><size=18>";
        for (int i = 0; i < Enum.GetNames(typeof(HeroKind)).Length; i++)
        {
            int count = i;
            tempStr += "\n- " + localized.Hero((HeroKind)count) + " : " + meter(main.S.movedDistance[count]) + " | Cette Ascension " + meter(main.S.totalMovedDistance[count]) + " | Cette Réincarnation " + meter(main.SR.movedDistance[count]);
        }
        tempStr += "\n- Familier : " + meter(main.S.movedDistancePet) + " | Cette Ascension " + meter(main.S.totalMovedDistancePet);// + " | Cette Réincarnation " + meter(main.SR.movedDistancePet);
        tempStr += "\nTotal : " + meter(game.statsCtrl.TotalMovedDistance(false)) + " | Cette Ascension " + meter(game.statsCtrl.TotalMovedDistance(true));
        tempStr += "\n\n";
        tempStr += "<size=20><u>Invasion</u><size=18>";
        tempStr += "\n- Total d'Invasions Vaincues : " + tDigit(main.S.swarmClearedNum);
        tempStr += "\n- Meilleur Score d'Invasion (Normale) : " + tDigit(main.S.swarmBestScores[0]);
        tempStr += "\n- Meilleur Score d'Invasion (Grosse) : " + tDigit(main.S.swarmBestScores[1]);
        tempStr += "\n- Meilleur Score d'Invasion (Épique) : " + tDigit(main.S.swarmBestScores[2]);
        tempStr += "\n\n";
        tempStr += "<size=20><u>Autres</u><size=18>";
        tempStr += "\n- Total de Coffres au Trésor ouverts : " + tDigit(main.S.openedChestNum);
        tempStr += "\n- Total d'Équipement Gagné : " + tDigit(main.S.totalEquipmentGained);
        tempValue = 0;
        for (int i = 0; i < main.S.disassembledEquipmentNums.Length; i++)
        {
            tempValue += main.S.disassembledEquipmentNums[i];
        }
        tempStr += "\n- Total d'Équipement Désassemblé : " + tDigit(tempValue);
        tempStr += "\n- Total de Points d'Alchimie Gagnés : " + tDigit(main.S.totalAlchemyPointGained);
        tempStr += "\n- Total de Monstres Capturés : " + tDigit(game.monsterCtrl.CapturedNum());
        tempStr += "\n\n";
        return tempStr;
    }
    public override string GuildLevelString()
    {
        string tempStr = optStr;
        tempStr += "Niveau de Guilde Max Atteint : Nv " + tDigit(main.S.maxGuildLevel);
        tempStr += "\n\n";
        tempStr += "<size=20><u>Record de Temps de Niveau de Guilde</u><size=18>";
        for (int i = 0; i < game.guildCtrl.accomplishGuildLevels.Length; i++)
        {
            if (game.guildCtrl.accomplishGuildLevels[i].accomplishedBestTime > 0)
            {
                tempStr += "\n- Nv " + tDigit(i) + " : ";
                if (game.guildCtrl.accomplishGuildLevels[i].accomplishedTime > 0)
                    tempStr += DoubleTimeToDate(game.guildCtrl.accomplishGuildLevels[i].accomplishedTime);
                if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                {
                    tempStr += " | Meilleur : " + DoubleTimeToDate(game.guildCtrl.accomplishGuildLevels[i].accomplishedBestTime);
                    tempStr += " | Premier : " + DoubleTimeToDate(game.guildCtrl.accomplishGuildLevels[i].accomplishedFirstTime);
                }
            }
        }
        return tempStr;
    }
    public override string TownString()
    {
        string tempStr = optStr;
        tempStr += "<size=20><u>Détails des Gains de Matériaux de Ville</u><size=18>";
        tempStr += optStr + "\n" + game.townCtrl.townMaterialGainMultiplier[(int)game.currentHero].BreakdownString(true);
        tempStr += "\n\n";
        tempStr += "<size=20><u>Détails des Gains de Matériaux de Ville à travers le Désassemblage d'Équipement</u><size=18>";
        tempStr += optStr + "\n" + game.equipmentCtrl.disassembleMultiplier.BreakdownString(true);
        tempStr += "\n\n";
        tempStr += optStr + "<size=20><u>Record de Temps de Rang de Bâtiment</u><size=18>";
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
                        tempStr += "\n- Rang " + tDigit(j + 1) + " : ";
                        if (building.accomplish[countJ].accomplishedTime > 0)
                            tempStr += DoubleTimeToDate(building.accomplish[countJ].accomplishedTime);
                        if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                        {
                            tempStr += " | Meilleur : " + DoubleTimeToDate(building.accomplish[countJ].accomplishedBestTime);
                            tempStr += " | Premier : " + DoubleTimeToDate(building.accomplish[countJ].accomplishedFirstTime);
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
        tempStr = optStr + "<size=20><u>Record de Temps de Défi</u><size=18>";
        for (int i = 0; i < game.challengeCtrl.challengeList.Count; i++)
        {
            CHALLENGE challenge = game.challengeCtrl.challengeList[i];
            if (challenge.accomplish.accomplishedBestTime > 0)
            {
                tempStr += "\n- " + challenge.TitleUIString() + " : ";
                tempStr += DoubleTimeToDate(challenge.accomplish.accomplishedTime);
                if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                {
                    tempStr += " | Meilleur : " + DoubleTimeToDate(challenge.accomplish.accomplishedBestTime);
                    tempStr += " | Premier : " + DoubleTimeToDate(challenge.accomplish.accomplishedFirstTime);
                }
            }
        }
        return tempStr;
    }
    public override string RebirthString()
    {
        string tempStr;
        tempStr = optStr + "<size=20><u># Total de Réincarnations</u><size=18>";
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
                        tempStr += "\n- Classe " + tDigit(countJ + 1) + " : " + tDigit(rebirth.rebirthNum);
                        if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                        {
                            tempStr += " | Total : " + tDigit(rebirth.totalRebirthNum);
                        }
                    }
                }
            }
        }
        tempStr += "\n\n";
        tempStr += optStr + "<size=20><u>Meilleur Temps de Réincarnation</u><size=18>";
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
                        tempStr += "\n- Classe " + tDigit(countJ + 1) + " : " + DoubleTimeToDate(rebirth.bestRebirthPlayTime);
                }
            }
        }
        tempStr += "\n\n";
        tempStr += "<size=20><u>Record de Temps de Réincarnation</u><size=18>";
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
                        tempStr += "\n- Classe " + tDigit(countJ + 1) + " : ";
                        if (rebirth.accomplish.accomplishedTime > 0)
                            tempStr += DoubleTimeToDate(rebirth.accomplish.accomplishedTime);
                        if (game.ascensionCtrl.worldAscensions[0].performedNum > 0)
                        {
                            tempStr += " | Meilleur : " + DoubleTimeToDate(rebirth.accomplish.accomplishedBestTime);
                            tempStr += " | Premier : " + DoubleTimeToDate(rebirth.accomplish.accomplishedFirstTime);
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
        tempStr = optStr + "<size=20><u>Record de Temps d'Ascension Monde</u><size=18>";
        tempStr += "\n- Tier 1 : " + DoubleTimeToDate(game.ascensionCtrl.worldAscensions[0].accomplish.accomplishedTime);
        return tempStr;
    }
    public override string StatisticAreaMissionString()
    {
        string tempStr;
        tempStr = optStr + "<size=20><b>Compte de Missions Complétées</b></size>\n\n";
        tempStr += "<u>Total</u>\n# Total de Complétions [ cette ascension / global ] : [ <color=green>" + tDigit(game.areaCtrl.TotalClearedMissionNum(true)) + "</color> / <color=green>" + tDigit(game.areaCtrl.TotalClearedMissionNum(false)) + "</color> ] \n\n";
        for (int i = 0; i < Enums.areaKindLength; i++)
        {
            AreaKind areaKind = (AreaKind)i;
            tempStr += "<u>" + AreaName(areaKind) + "</u>\n";
            for (int j = 0; j < game.areaCtrl.areas[i].Length; j++)
            {
                AREA area = game.areaCtrl.areas[i][j];
                tempStr += ColoredString(localized.Basic(BasicWord.Area) + " " + (j + 1).ToString(), area.TotalClearedMissionNum(), true) + " : ";
                for (int k = 0; k < 1 + AreaParameter.maxPrestigeLevel; k++)
                {
                    tempStr += BattleControllerUIString(6) + (k + 1).ToString() + " [";
                    long num = area.ClearedMissionNum(k, true);
                    tempStr += ColoredString(num.ToString(), num) + "/";
                    num = area.ClearedMissionNum(k, false);
                    tempStr += ColoredString(num.ToString(), num) + "]  ";
                }
                tempStr += "\n";
            }
            tempStr += "\n\n";
        }
        return tempStr;
    }
    public override string AchievementString(HelpKind helpKind)
    {
        StringBuilder tempStringBuilder = new StringBuilder(4096);
        tempStringBuilder.Clear();
        tempStringBuilder.Append(optStr + "<size=20>TOTAL COMPLÉTÉ # <color=green>" + tDigit(game.achievementCtrl.TotalClearNum()) + "</color> / " + tDigit(game.achievementCtrl.achievementList.Count));
        tempStringBuilder.Append(optStr + "\nBonus Total Complété : Gain d'Or <color=green>+ " + percent(game.achievementCtrl.GoldGainBonus(), 0) + "</color> ( + 1% / complétion )");
        tempStringBuilder.Append("\n\n<u>Succès</u><size=18>");
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
            case 0: return "Cliquer pour aller à ";
            case 1: return "Il faut " + text + " Orbe(s) Portail pour entrer dans cette Zone (Vous en avez " + text2 + ")";
            case 2: return "Voir tous les Titres acquis.";
            case 3: return "Retirer de la liste des Quêtes Favorites";
            case 4: return "Assigner en tant que Quête Favorite";
            case 5: return " [Quête Favorite] dans le Magasin Épique";
            case 6:
                return "Les Quêtes de Titre et les Quêtes Générales sont limitées au Nombre de Quêtes Acceptées." +
"\nVous pouvez augmenter la limite avec une amélioration de Réincarnation.";
            case 7: return "Marcher";
            case 8: return "Attaque Physique #";
            case 9: return "Attaque de Feu #";
            case 10: return "Attaque de Glace #";
            case 11: return "Attaque de Tonnerre #";
            case 12: return "Attaque de Lumière #";
            case 13: return "Attaque des Ténèbres #";
            case 14: return "Quêtes Générales Complétées #";
            case 15: return "Vaincre un(e) " + text + " ";
            case 16: return "Vaincre " + text + " ";
            case 17: return "Capturer un(e) " + text + " ";
            case 18: return "Capturer " + text + " ";
            case 19: return "Complétion #";
            case 20: return "EXP de Guilde";
            case 21: return "(Assurez-vous d'avoir suffisament d'emplacements disponibles avant de réclamer)";
            case 22: return "Temps depuis le Dernier Rafraîchissement";
            case 23: return "Temps avant le Prochain Rafraîchissement";
            case 24: return "Cette quête ne se rafraîchira pas tant qu'elle est active";
            case 25: return "Maîtrise des Quêtes";
            case 26: return "Rang Courant";
            case 27: return "Total Complété #";
            case 28: return "Max Atteint #";
            default: return base.QuestMenuString(id, text);
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
                name = "Manufacture de Briques";
                effect = "Gain de Briques : <color=green>" + percent(Math.Pow(1.1d, expedition.level.value)) + "</color>  ( x1.1 par Niveau )";
                passive = optStr + "Effet des Niveaux de Bâtiments de Ville en Brique <color=green>+ " + percent(expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Nv )";
                break;
            case ExpeditionKind.Log:
                name = "Coûpe d'Arbres";
                effect = "Gains en Billots : <color=green>" + percent(Math.Pow(1.1d, expedition.level.value)) + "</color>  ( x1.1 par Niveau )";
                passive = optStr + "Effet des Niveaux de Bâtiments de Ville en Billots <color=green>+ " + percent(expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Nv )";
                break;
            case ExpeditionKind.Shard:
                name = "Ramassage d'Éclats";
                effect = "Gains en Éclats : <color=green>" + percent(Math.Pow(1.1d, expedition.level.value)) + "</color>  ( x1.1 par Niveau )";
                passive = optStr + "Effet des Niveaux de Bâtiments de Ville en Éclats <color=green>+ " + percent(expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Nv )";
                break;
            case ExpeditionKind.PetRank:
                name = "Capture de Monstres";
                effect = "Point de Domptage : <color=green>" + percent(Math.Pow(1.1d, expedition.level.value)) + "</color>  ( x1.1 par Niveau )";
                passive = optStr + "Multiplie le Gain de Points de Domptage par <color=green>" + percent(1 + expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Nv )";
                reward = "Points de Domptage " + text;
                break;
            case ExpeditionKind.Equipment:
                name = "Entraînement d'Équipement";
                effect = "Temps de Parchemin de Maîtrise : <color=green>" + percent(1 + 0.10d * expedition.level.value) + "</color>  ( + " + percent(0.10d) + " par Niveau )";
                passive = optStr + "Multiplie le Gain en Maîtrise d'Équipement par <color=green>" + percent(1 + expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Nv )";
                break;
            case ExpeditionKind.PetExp:
                name = "Entraînement sur le Terrain";
                effect = "Gain en EXP de Familier : <color=green>" + percent(Math.Pow(1.2d, expedition.level.value)) + "</color>  ( x1.2 par Niveau )";
                passive = optStr + "Multiplie les Gains d'EXP de Familier en expédition par <color=green>" + percent(1 + expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Nv )";
                reward = "EXP de Familier " + text;
                break;
            case ExpeditionKind.WalkDistance:
                name = "Marathon";
                effect = "Distance Marchée: <color=green>" + percent(Math.Pow(1.2d, expedition.level.value)) + "</color>  ( x1.2 par Niveau )";
                passive = optStr + "Gain de Distance Marchée en expédition <color=green>+ " + percent(expedition.EffectValue()) + "</color>  ( + " + percent(expedition.passiveEffectValueIncrementPerLevel) + " / Nv )";
                reward = text + " Distance Marchée";
                break;
        }

        return (name, effect, passive, reward);
    }

    public override string ExpeditionString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Effet d'Expédition";
            case 1: return "Récompense de Complétion";
            case 2: return "Gain d'EXP de Familier";
            case 3: return "Information";
            case 4: return "Total Complété #";
            case 5: return "Temps Total";
            case 6: return "Vitesse de cette Expédition";
            default: return base.ExpeditionString(id, text);
        }
    }
    public override string InAppPurchaseString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Obtenez " + text + "Pièces Épiques Maintenant!";
            case 1: return "Seul le premier achat double les Pièces Épiques!";
            default: return base.InAppPurchaseString(id, text);
        }
    }
    public override string MonsterNameString(ChallengeMonsterKind kind)
    {
        switch (kind)
        {
            case ChallengeMonsterKind.Florzporb:
                return "Florzporbe, Le Roi Slime";
            case ChallengeMonsterKind.Arachnetta:
                return "Aranetta, La Veuve Noire";
            case ChallengeMonsterKind.GuardianKor:
                return "Gardien Kor, Le Géant de Pierre";
            case ChallengeMonsterKind.Nostro:
                return "Nostro, la Chauve-Souris Vampire";
            case ChallengeMonsterKind.LadyEmelda:
                return "Dame Emelda, la Fée Sorcière";
            case ChallengeMonsterKind.NariSune:
                return "Nari Sune, le Renard aux Neuf Queues";
            case ChallengeMonsterKind.Octobaddie:
                return "Octopabo, Terreur des Profondeurs";
            case ChallengeMonsterKind.Bananoon:
                return "Bananoutan, le Bananattaqueur";
            case ChallengeMonsterKind.Glorbliorbus:
                return "Glorbliorbe, le Slime Archimage";
            case ChallengeMonsterKind.DistortionSlime:
                return "Gankyū, le Slime Distordu";
        }
        return base.MonsterNameString(kind);
    }
    public override string MonsterShortNameString(ChallengeMonsterKind kind)
    {
        switch (kind)
        {
            case ChallengeMonsterKind.Florzporb:
                return "Florzporbe";
            case ChallengeMonsterKind.Arachnetta:
                return "Aranetta";
            case ChallengeMonsterKind.GuardianKor:
                return "Gardien Kor";
            case ChallengeMonsterKind.Nostro:
                return "Nostro";
            case ChallengeMonsterKind.LadyEmelda:
                return "Dame Emelda";
            case ChallengeMonsterKind.NariSune:
                return "Nari Sune";
            case ChallengeMonsterKind.Octobaddie:
                return "Octopabo";
            case ChallengeMonsterKind.Bananoon:
                return "Bananoutan";
            case ChallengeMonsterKind.Glorbliorbus:
                return "GlorGlorbliorbebliorbus";
            case ChallengeMonsterKind.DistortionSlime:
                return "Gankyū";
        }
        return base.MonsterShortNameString(kind);
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
                return "Chance de Trouver une Orbe Portail dans un Coffre : <color=green>" + percent(pet.effectValue, 4) + "</color> ( + " + percent(pet.effectIncrementValue, 4) + " / Rang )";
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
                return "Multiplie la Chance de Succès Critique du Catalyst par <color=green>" + percent(1 + pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.MysteriousWaterCap:
                return "Maximum d'Eau Mystérieuse <color=green>+ " + tDigit(pet.effectValue) + "</color> ( + " + tDigit(pet.effectIncrementValue, 2) + " / Rang )";
            case PetPassiveEffectKind.BlessingEffect:
                return "Effet des Bénédictions <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.LoyaltyPointGain:
                return "Gain de Points de Loyauté <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.PetExpGain:
                return "Gain d'EXP des Familiers <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.ExpeditionExpGain:
                return "Gain d'EXP d'Expédition <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.EssenceConversionRate:
                return "Taux de Conversion d'Essence <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.SlimeCoinEfficiency:
                return "Multiplie l'Efficacité des Pièces Slime par <color=green>" + percent(1 + pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.SlimeCoinCap:
                return "Multiplie la Limite des Pièces Slime par <color=green>" + percent(1 + pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.EquipmentEffect:
                return "Multiplie l'Effet des Équipements par <color=green>" + percent(1 + pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
            case PetPassiveEffectKind.AlchemyPointGain:
                return "Gain de Points d'Alchimie <color=green>+ " + percent(pet.effectValue) + "</color> ( + " + percent(pet.effectIncrementValue) + " / Rang )";
        }
        return base.MonsterPetPassiveEffectStreing(pet);
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
        return base.TownMaterialNameString(kind);
    }

    public override (string name, string description, string passive) WorldAscensionMilestoneString(WorldAscensionMilestone milestone, double currentValue = 0, double nextValue = 0)
    {
        string name = "";
        string description = "";
        string passive = "";

        switch (milestone.kind)
        {
            case WorldAscensionMiletoneKind.TownBuldingLevel:
                name = "Constructeur de Ville";
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
                passive = "Gain de Ressources + " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
            case WorldAscensionMiletoneKind.MoveDistance:
                name = "Explorateur de Monde";
                description = "Distance Marchée Totale (mètres)";
                passive = "Vitesse de Déplacement + " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
            case WorldAscensionMiletoneKind.DictionaryPoint:
                name = "Expert en Équipement";
                description = "Total des Points de Dictionnaire";
                passive = "Amélioration des effets du Dictionnaire + " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
            case WorldAscensionMiletoneKind.DisassembleEquipment:
                name = "Désassembleur Professionnel";
                description = "Total des Matériaux de Ville Acquis en désassemblant";
                passive = "Gain en Maîtrise d'Équipement + " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
            case WorldAscensionMiletoneKind.RebirthPointGainTier1:
                name = "Réincarnateur Classe 1";
                description = "Total des Points de Réincarnation Classe 1 gagnés";
                passive = "Gain de Points de Réincarnation Classe 1 + " + percent(currentValue) + " -> <color=green>+ " + percent(nextValue) + "</color>";
                break;
            case WorldAscensionMiletoneKind.RebirthPointGainTier2:
                name = "Réincarnateur Classe 2";
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
            default: return base.WorldAscensionString(id, text);
        }
    }
    public override (string name, string effect) WorldAscensionUpgradeString(WorldAscensionUpgrade upgrade, double value = 0)
    {
        string name = "";
        string effect = "";
        switch (upgrade.kind)
        {
            case AscensionUpgradeKind.GuildExpGain:
                name = "Boosteur d'EXP de Guilde";
                effect = "Multiplies le gain d'EXP de Guilde par " + percent(1 + value);
                break;
            case AscensionUpgradeKind.AreaClearCount:
                name = "Boosteur de Zone";
                effect = "Augmente le nombre de Complétions de Zone et la Récompense de Complétion par " + tDigit(value);
                break;
            case AscensionUpgradeKind.ActiveHero:
                name = "Héro Actif +";
                effect = "Augmente le nombre d'Emplacements de Héros activables par " + tDigit(value);
                break;
            case AscensionUpgradeKind.SkillProfGain:
                name = "Boost de Maîtrise de Capacité";
                effect = "Augmente la Maîtrise de Capacité par " + percent(value);
                break;
            case AscensionUpgradeKind.PreRebirthTier1:
                name = "Points de Pré-Réinc. Classe 1";
                effect = "Ajoute des Points de Réincarnation Classe 1 gratuits + " + tDigit(value) + " au début d'une nouvelle AM";
                break;
            case AscensionUpgradeKind.PreRebirthTier2:
                name = "Points de Pré-Réinc. Classe 2";
                effect = "Ajoute des Points de Réincarnation Classe 2 gratuits + " + tDigit(value) + " au début d'une nouvelle AM";
                break;
            case AscensionUpgradeKind.RebirthTier1BonusCap:
                name = "Bonus de Réinc. Classe 1 +";
                effect = "Augmente le niveau maximal du Bonus de Points d'Abilité de Classe 1 par Niv " + tDigit(value);
                break;
            case AscensionUpgradeKind.RebirthTier2BonusCap:
                name = "Bonus de Réinc. Classe 2 +";
                effect = "Augmente le niveau maximal du Bonus de Points d'Abilité de Classe 2 par Niv " + tDigit(value);
                break;
            case AscensionUpgradeKind.PointGainBonus:
                name = "Gain de Points d'AM par Palier";
                effect = "Augmente le nombre de points gagnés par niveau de palier d'AM par " + tDigit(value);
                break;
            case AscensionUpgradeKind.NitroSpeed:
                name = "Amélioration de Nitro";
                effect = "Vitesse de Nitro + " + tDigit(value, 1) + "x";
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
            default: return base.IEH1PlayerBonusString(id, text);
        }
    }

    public override string TreasureChestString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Le coffre était un Mimic !!!";
            case 1: return "Bénédiction !";
            case 2: return "Temps Limite + 30 sec !";
            case 3: return "1 Orbe Portail !";
            case 4: return "Talisman !";
            default: return base.TreasureChestString(id, text);
        }
    }
    public override string OtherString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return text + " heure(s)";
            case 1: return "<size=24>CODE BONUS</size>\nVeuillez entrer un code bonus ici.";
            case 2: return "Impossible d'équiper le même Talisman.";
            case 3: return "Impossible d'équiper le même Piège.";
            case 4: return "Impossible d'équiper le même type d'objet.";
            case 5: return "Classe " + text;
            case 6: return "Non-" + text;
            case 7: return "Temps de Jeu Réel Total";
            case 8: return "Temps de Jeu Total";
            case 9: return "Quitter le Mode Arrière-Plan";
            case 10: return "Commencer " + text; //SuperDungeon
            case 11: return "Rupture de Stock";
            case 12: return "Chance d'Apparition de " + text;
            default: return base.OtherString(id, text);
        }
    }

    public override string NumberFormatString(NumberFormatKind kind)
    {
        switch (kind)
        {
            case NumberFormatKind.Default: return "Défaut";
            case NumberFormatKind.Standard: return "Standard";
            case NumberFormatKind.Scientific: return "Scientifique";
            case NumberFormatKind.Engineering: return "Ingénierie";
        }
        return base.NumberFormatString(kind);
    }

    public override string PetRankMilestoneString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Gain de Point de Domptage + " + text;
            case 1: return "Gain de Point de Loyauté + " + text;
            case 2: return "Gain d'EXP de Familier + " + text;
            case 3: return "Stats de Familier + " + text;
            case 4: return "Effet PAssif de Familier + " + text;
            case 5: return "Chance de Double Capture + " + text;
            case 6: return "Chance de Triple Capture + " + text;
            case 7: return "Améliore l'Effet Actif de Familier de " + text;
            case 8: return "Chance d'Apparition de Matériel Commun x" + text;
            case 9: return "Chance d'apparition de Matériel Rare x" + text;
            case 10: return "Emplacement de Familier Actif + " + text;
        }
        return "";
    }

    public override string SuperDungeonString(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Vous recevrez des Pièces de Donjon après avoir vaincu des monstres.";
            case 1: return "Vous recevrez des Topazes lorsque vous complétez un étage pour la première fois, pour chaque héros.";
            case 2: return "Vous recevrez des Rubis lorsque vous complétez chaque dixième étage pour la première fois, pour chaque héros.";
            case 3: return "Vous recevrez des Morceaux de Rubis lorsque vous complétez chaque dixième étage après la première fois, pour chaque héros.";
            case 4: return "Acheté dans l'Essai Courant #";
            case 5: return "Coût Courant en Orbes Portail pour Entrer";
            case 6: return "Ticket qui réinitialise le Coût en Orbe Portail des Super Donjons à 1 Orbe Portail par entrée.";
            case 7: return "Complétion " + text;
            case 8: return "De nombreuses stats sont réduites dans un Super Donjon";
            case 9: return "Les bénédictions ne sont pas disponibles";
            case 10: return "Etage Max Atteint";
            case 11: return "Modificateurs";
            case 12: return "Réinitialisation";
            case 13: return "Aller à la Super Capacité";
            case 14: return "Palier de Classe";
            case 15: return "Stats de Héros";
            case 16: return "Emplacements de Capacité de Classe Disponibles";
            case 17: return "Emplacements d'Armes Disponibles";
            case 18: return "Emplacements d'Armures Disponibles";
            case 19: return "Emplacements de Bijoux Disponibles";
            case 20: return "Emplacements d'Utilitaires Disponibles";
            case 21: return "Temps Limite Initial";
            case 22: return "Temps d'Esquive Initial Disponible";
            case 23: return "Multiplicateur de Dégâts dans un SD";
            case 24: return "Multiplicateur de Réduction de Dégâts dans un SD";
            case 25: return "Dégâts Physiques dans un SD";
            case 26: return "Dégâts Magiques dans un SD";
            case 27: return "Chance Critique Physique dans un SD";
            case 28: return "Chance Critique Magique dans un SD";
            case 29: return "Dégâts Critiques dans un SD";
            case 30: return "Vitesse de Lancer de Capacité dans un SD";
            case 31: return "Nombre de Coups d'une Capacité dans un SD";
            case 32: return "Dégâts Absolus Supplémentaires dans un SD";
            case 33: return "Vitesse de Déplacement dans un SD";
            case 34: return "Chance d'apparition d'Équipement dans un SD";
            case 35: return "Bonus de Pièce de Donjon par Monster Vaincu";
            case 36: return "Gain de Renommée";
            case 37: return "Pouvoirs";
            case 38: return "Automatisations";
            case 39: return "Améliorer " + text;
            case 40: return "Amélioration de SD";
            case 41: return "Automatisation de SD";
            case 42: return "Etage Visé";
            case 43: return "Valide jusqu'à ce que le Coût d'Entrée excède cette valeur";
            case 44: return "Pouvoir de SD";
            case 45: return "Les Stats de Héros sont réduites dans un Super Donjon - Voir l'onglet Détails de Héros";
            case 46: return "Le Super Donjon a été complété avec succès !";
            case 47: return "Vous avez quitté le Super Donjon en sécurité.";
            case 48: return "Vous avez perdu, vous fered mieux la prochaine fois !";
            case 49: return "Ressources Gagnées";
            case 50: return "Pouvoirs Achetés";
            case 51: return "Total de Pièces de Donjon Gagnées";
            case 52: return "Total de Renommée Gagnée";
            case 53: return "Super Donjon";
            case 54: return "Utilise 1 " + Basic(BasicWord.EntryCostRefreshTicket) + " pour réinitialiser le Coût d'Entrée à 1 Orbe Portail.";
            case 55: return "Actif lorsque le Coût d'Entrée excède cette valeur";
            case 56: return "Emplacements d'Enchantement Disponible";
            case 57: return "Gain Total dans un SD";
            case 58: return "Total sauvé depuis un SD";
            case 59: return "Total gagné";
            case 60: return "Vous pouvez revenir avec ces objets si vous partez maintenant.";
            case 61: return "Côut de Débloquage";
            case 62: return "Quitter";
            case 63: return "Quitter & Réessayer";
            case 64: return "Esquive";
            case 65: return "Détails du Héros";
            case 66: return "Améliorations";
            case 67: return "Magasin de Rubis";
            case 68: return "Options";
            case 69: return "Parchemins";
            case 70: return "Enclumes";
            case 71: return "Talismans";
            case 72: return "Spécial";
            case 73: return "Stats";
            case 74: return "Options de Super Donjon";
            case 75: return "Options d'Automatisation";
        }
        return text;
    }

    public override (string name, string effect, string permanentEffect) SDPowerupString(SuperDungeonPowerupKind kind, string text = "")
    {
        string name = "";
        string effect = "";
        string permanentEffect = "";
        switch (kind)
        {
            case SuperDungeonPowerupKind.Heal:
                name = "Soin";
                effect = "Restaure {0} des PV Max à chaque étage ( + {1} / Rang )";
                permanentEffect = "PV Absolus + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.TimeLimit:
                name = "Expansion de Temps";
                effect = "Limite de Temps de SD + {0} ( + {1} / Rang )";
                permanentEffect = "Limite de Temps de SD Initiale + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.DamageMultiplier:
                name = "Multiplicateur de Dégâts de SD";
                effect = "Multiplicateur de Dégâts de SD + {0} ( + {1} / Rang )";
                permanentEffect = "Multiplicateur de Dégâts de SD + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.DamageCutMultiplier:
                name = "Multiplicateur de Réduction de Dégâts de SD";
                effect = "Multiplicateur de Réduction de Dégâts de SD + {0} ( + {1} / Rang )";
                permanentEffect = "Multiplicateur de Réduction de Dégâts de SD + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.RestoreDodgeTimesec:
                name = "Temps d'Esquive";
                effect = "Restaure {0} sec de Temps d'Esquive à chaque étage ( + {1} / Rang )";
                permanentEffect = "Temps d'Esquive Disponible Initial + {0} sec ( + {1} sec / achat )";
                break;
            case SuperDungeonPowerupKind.DodgeHeal:
                name = "Soin d'Esquive";
                effect = "Restaure {0} des PV Max chaque fois qu'une attaque est esquivée avec succès ( + {1} / Rang )";
                permanentEffect = "PM Absolus + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.DungeonCoinGain:
                name = "Gain de Pièce de Donjon";
                effect = "Pièce de Donjon Supplémentaires par Monstre Vaincu + {0} ( + {1} / Rang )";
                permanentEffect = "Gain de Pièce de Donjon + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.FameGain:
                name = "Gain de Renommée";
                effect = "Gain de Renommée + {0} ( + {1} / Rang )";
                permanentEffect = "Gain de Renommée + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.SkillCastSpeed:
                name = "Vitesse de Lancer de Capacité";
                effect = "Vitesse de Lancer de Capacité + {0} ( + {1} / Rang )";
                permanentEffect = "VIT Absolue + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.PhysicalCriticalChance:
                name = "Physical Critical Chance";
                effect = "Physical Critical Chance After + {0} ( + {1} / Rang )";
                permanentEffect = "Physical Critical Chance After + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.MagicalCriticalChance:
                name = "Magical Critical Chance";
                effect = "Magical Critical Chance After + {0} ( + {1} / Rang )";
                permanentEffect = "Magical Critical Chance After + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.CriticalDamage:
                name = "Critical Damage";
                effect = "Critical Damage After + {0} ( + {1} / Rang )";
                permanentEffect = "Critical Damage After + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.MoveSpeed:
                name = "Vitesse de Déplacement";
                effect = "Vitesse de Déplacement Absolue + {0} / sec ( + {1} / Rang )";
                permanentEffect = "Vitesse de Déplacement Absolue + {0} / sec ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.PhysicalDamage:
                name = "Dégâts Physiques";
                effect = "Dégâts Physiques Absolus + {0} ( + {1} / Rang )";
                permanentEffect = "ATQ Absolue + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.MagicalDamage:
                name = "Dégâts Magiques";
                effect = "Dégâts Magiques Absolus + {0} ( + {1} / Rang )";
                permanentEffect = "MATQ Absolue + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.PhysicalAbsorption:
                name = "Absorption Physique";
                effect = "Absorption Physique Absolue + {0} ( + {1} / Rang )";
                permanentEffect = "DEF Absolue + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.MagicalAbsorption:
                name = "Absorption Magique";
                effect = "Absorption Magique Absolue + {0} ( + {1} / Rang )";
                permanentEffect = "MDEF Absolue + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.SkillHitCount:
                name = "Nombre de Coups de Capacité";
                effect = "Nombre de Coups de Capacité + {0} ( + {1} / Rang )";
                permanentEffect = "Niveau de Capacité Absolu + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.ExtraAfterDamage:
                name = "Dégâts Absolus Supplémentaires";
                effect = "Dégâts Absolus Supplémentaires + {0} ( + {1} / Rang )";
                permanentEffect = "Dégâts Absolus Supplémentaires + {0} ( + {1} / achat )";
                break;
            case SuperDungeonPowerupKind.EquipmentDropChance:
                name = "Chance d'Apparition d'Équipement";
                effect = "Chance d'Apparition d'Équipement Absolue + {0} ( + {1} / Rang )";
                permanentEffect = "Gain de Maîtrise d'Antiquité + {0} ( + {1} / achat )";
                break;
        }
        return (name, effect, permanentEffect);
    }

    public override string SDShopString(int id, string text1 = "", string text2 = "", string text3 = "")
    {
        switch (id)
        {
            case 0: return "Convertisseur de Rubis";
            case 1: return "Convertit " + text1 + " <sprite=\"PieceOfRuby\" index=0> " + Basic(BasicWord.PieceOfRuby) + " en 1 <sprite=\"Ruby\" index=0> " + Basic(BasicWord.Ruby);
            case 2: return "Convertisseur de Morceau de Rubis";
            case 3: return "Convertit 1 <sprite=\"Ruby\" index=0> " + Basic(BasicWord.Ruby) + " en " + text1 + " <sprite=\"PieceOfRuby\" index=0> " + Basic(BasicWord.PieceOfRuby);
            case 4: return "Effet d'Antiquité";
            case 5: return text1 + " des stats \"Effet d'Équipement\" s'applique aux Antiquités ( + " + text2 + " / Nv )" + "\n- Effet d'Équipement Courant des Antiquités : " + text3;
            default: return text1;
        }
    }

    public override (string name, string effect, string effectWithLevel) SDUpgradeString(SuperDungeonUpgradeKind kind, string text = "")
    {
        string name = "";
        string effect = "";
        string effectWithLevel = "";
        switch (kind)
        {
            case SuperDungeonUpgradeKind.MorePowerups:
                name = "Plus de Pouvoirs";
                effect = "Augmente le nombre de pouvoirs à chaque étage";
                effectWithLevel = text + " pouvoirs apparaissent dans la Zone Sûre à chaque étage";
                break;
            case SuperDungeonUpgradeKind.FlexibleDodge:
                name = "Esquive Flexible";
                effect = "Permet de lancer des capacités et de se déplacer pendant l'Esquive";
                effectWithLevel = "";
                break;
            case SuperDungeonUpgradeKind.LeaveAndRetry:
                name = "Quitter & Réessayer";
                effect = "Débloque le bouton \"Quitter & Réessayer\" qui permet de recommencer le Super Donjon courant juste après l'avoir quitté";
                effectWithLevel = "";
                break;
            case SuperDungeonUpgradeKind.AutoDodge:
                name = "Auto Esquive";
                effect = "Débloque le bouton \"Auto Esquive\" dans l'onglet d'Options de SD qui appuie sur le bouton d'Esquive jusqu'à ce que le Temps d'Esquive soit écoulé";
                effectWithLevel = "";
                break;
            case SuperDungeonUpgradeKind.AutoLeaveAndRetry:
                name = "Auto Quitter & Réessayer";
                effect = "Débloque le bouton dans l'onglet Options de SD qui clique automatiquement sur le bouton Quitter & Réessayer lorsqu'un certain étage est atteint si le coût est en dessous d'un certain montant";
                effectWithLevel = "";
                break;
            case SuperDungeonUpgradeKind.SDDamageMultiplier:
                name = "Multiplicateur de Dégâts de SD";
                effect = "Multiplie les Dégâts dans un SD";
                effectWithLevel = "par " + text;
                break;
            case SuperDungeonUpgradeKind.SDDamageCutMultiplier:
                name = "SD Damage Cut Multiplier";
                effect = "Multiplie la Réduction de Dégâts dans un SD";
                effectWithLevel = "par " + text;
                break;
            case SuperDungeonUpgradeKind.FameGain:
                name = "Gain de Renommée";
                effect = "Multiplie le Gain de Renommée";
                effectWithLevel = "par " + text;
                break;
            case SuperDungeonUpgradeKind.SDMPGainEveryFloor:
                name = "Avance de PM";
                effect = "";
                effectWithLevel = "Gagne " + text + " des MP Max à chaque étage";
                break;
            case SuperDungeonUpgradeKind.SDDungeonCoinBoostStart:
                name = "Avance de Pièce de Donjon";
                effect = "";
                effectWithLevel = "Commence un essai de Super Donjon avec " + text + " Pièces de Donjon";
                break;
            case SuperDungeonUpgradeKind.SDPowerupBoostStart:
                name = "Avance de Pouvoirs";
                effect = "Commence un essai de Super Donjon avec des pouvoirs aléatoires à la Zone Sûre de l'étage -1";
                effectWithLevel = "";
                break;
            case SuperDungeonUpgradeKind.AutoProgress:
                name = "Auto Progression";
                effect = "Débloque le bouton \"Auto Progression\" dans l'onglet Options de SD qui progresse vers le prochain étage jusqu'à un étage donné";
                effectWithLevel = "";
                break;
            case SuperDungeonUpgradeKind.AutoBuyPowerups:
                name = "Auto Achat de Pouvoirs";
                effect = "Débloque le bouton \"Auto Achat de Pouvoirs\" dans l'onglet Options de SD qui achète des pouvoirs de façon aléatoire automatiquement";
                effectWithLevel = "Achète des pouvoirs aléatoires " + text + " fois à chaque étage";
                break;
            case SuperDungeonUpgradeKind.AutoUseRefreshTicket:
                name = "Auto Utilisation des Tickets de Rafraîchissement";
                effect = "Débloque le bouton \"Auto Utilisation des Tickets de Rafraîchissement\" dans l'onglet Options de SD qui utilise un Ticket de Rafraîchissement de Coût d'Entrée lorsque le coût d'entrée excède une certaine valeur";
                effectWithLevel = "";
                break;
        }
        return (name, effect, effectWithLevel);
    }

    public override string SDName(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "La Cachette des Slimes";
            case 1: return "L'Appartement Souterrain des Araignées";
            default: return text;
        }
    }

    public override string GradeMilestone(int id, string text = "")
    {
        switch (id)
        {
            case 0: return "Emplacement de Capacité de Classe Disponible + " + text;
            case 1: return "Emplacement d'Arme Disponible + " + text;
            case 2: return "Emplacement d'Armure Disponible + " + text;
            case 3: return "Emplacement de Bijou Disponible + " + text;
            case 4: return "Emplacement d'Utilitaire Disponible + " + text;
            default: return text;
        }
    }
}
