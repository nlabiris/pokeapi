using System;
using System.Collections.Generic;
using System.Data;

namespace PokeAPI.DataAccess {
    internal static class Query {
        public static string GetAllPokemon {
            get {
                return @"
SELECT `id`,
`identifier`, 
`species_id`, 
`height`, 
`weight`, 
`base_experience`, 
`order`, 
`is_default`
FROM `pokemon`";
            }
        }

        public static string GetSpecificPokemon {
            get {
                return @"
SELECT `id`,
`identifier`,
`species_id`,
`height`,
`weight`,
`base_experience`,
`order`,
`is_default`
FROM `pokemon`
WHERE `id` = @pokemon_id";
            }
        }

        public static string GetSpecificSpecies {
            get {
                return @"
        SELECT `id`, 
        `identifier`, 
        `generation_id`, 
        `evolves_from_species_id`, 
        `evolution_chain_id`, 
        `color_id`, 
        `shape_id`, 
        `habitat_id`, 
        `gender_rate`, 
        `capture_rate`, 
        `base_happiness`, 
        `is_baby`, 
        `hatch_counter`, 
        `has_gender_differences`, 
        `growth_rate_id`, 
        `forms_switchable`, 
        `order`, 
        `conquest_order`
        FROM `pokemon_species`
        WHERE `id` = @species_id";
            }
        }

        public static string GetSpecificGeneration {
            get {
                return @"
    SELECT `id`,
    `main_region_id`,
    `identifier`
    FROM `generations`
    WHERE `id` = @generations_id";
            }
        }

        public static string GetSpecificRegion {
            get {
                return @"
        SELECT `id`,
        `identifier`
        FROM `regions`
        WHERE `id` = @regions_id";
            }
        }

        public static string GetSpecificColor {
            get {
                return @"
    SELECT `id`,
    `identifier`
    FROM `pokemon_colors`
    WHERE `id` = @color_id";
            }
        }

        public static string GetSpecificShape {
            get {
                return @"
    SELECT `id`,
    `identifier`
    FROM `pokemon_shapes`
    WHERE `id` = @shape_id";
            }
        }

        public static string GetSpecificHabitat {
            get {
                return @"
    SELECT `id`,
    `identifier`
    FROM `pokemon_habitats`
    WHERE `id` = @habitat_id";
            }
        }

        public static string GetSpecificGrowthRate {
            get {
                return @"
    SELECT `id`,
    `identifier`,
    `formula`
    FROM `growth_rates`
    WHERE `id` = @growth_rate_id";
            }
        }

        public static string GetSpecificEvolutionChain {
            get {
                return @"
        SELECT `id`,
        `baby_trigger_item_id`
        FROM `evolution_chains`
        WHERE `id` = @evolution_chains_id";
            }
        }

        public static string GetSpecificBabyTriggerItem {
            get { 
                return @"SELECT `id`, 
        `identifier`, 
        `category_id`, 
        `cost`, 
        `fling_power`, 
        `fling_effect_id`
        FROM `items`
        WHERE `id` = @baby_trigger_item_id";
            }
        }

        public static string GetSpecificCategory {
            get {
                return @"
            SELECT `id`,
            `pocket_id`,
            `identifier`
            FROM `item_categories`
            WHERE `id` = @category_id";
            }
        }

        public static string GetSpecificPocket {
            get {
                return @"
                SELECT `id`,
                `identifier`
                FROM `item_pockets`
                WHERE `id` = @pocket_id";
            }
        }

        public static string GetSpecificFlingEffect {
            get {
                return @"
            SELECT `id`
            FROM `item_fling_effects`
            WHERE `id` = @fling_effect_id";
            }
        }

        public static string GetAllAbilities {
            get {
                return @"
                SELECT `id`,
                `identifier`,
                `generation_id`,
                `is_main_series`
FROM `abilities`";
            }
        }

        public static string GetSpecificAbility {
            get {
                return @"
                SELECT `id`,
                `identifier`,
                `generation_id`,
                `is_main_series`
FROM `abilities`
WHERE `id` = @ability_id";
            }
        }

        public static string GetSpecificAbilityChangelog {
            get {
                return @"
                SELECT `id`,
                `ability_id`,
                `changed_in_version_group_id`
FROM `ability_changelog`
WHERE `ability_id` = @ability_id";
            }
        }

        public static string GetSpecificVersionGroup {
            get {
                return @"
SELECT `id`, 
`identifier`, 
`generation_id`, 
`order` 
FROM `version_groups` 
WHERE `id` = @version_group_id";
            }
        }

        public static string GetSpecificAbilityChangelogProse {
            get {
                return @"
                SELECT `ability_changelog_id`,
                `local_language_id`,
                `effect`
                FROM `ability_changelog_prose`
                WHERE `ability_changelog_id` = @ability_changelog_id";
            }
        }

        public static string GetSpecificLanguage {
            get {
                return @"
                SELECT `id`, 
                `iso639`, 
                `iso3166`, 
                `identifier`, 
                `official`, 
                `order`
                FROM `languages`
                WHERE `id` = @language_id";
            }
        }

        public static string GetSpecificAbilityName {
            get {
                return @"
                SELECT `ability_id`,
                `local_language_id`,
                `name`
                FROM `ability_names`
                WHERE `ability_id` = @ability_id";
            }
        }

        public static string GetSpecificAbilityProse {
            get {
                return @"
                SELECT `local_language_id`,
                `short_effect`,
                `effect`
                FROM `ability_prose`
                WHERE `ability_id` = @ability_id";
            }
        }

        public static string GetAllBerries {
            get {
                return @"
                SELECT `id`, 
                `item_id`, 
                `firmness_id`, 
                `natural_gift_power`, 
                `natural_gift_type_id`, 
                `size`, 
                `max_harvest`, 
                `growth_time`, 
                `soil_dryness`, 
                `smoothness` 
                FROM `berries`";
            }
        }

        public static string GetSpecificBerry {
            get {
                return @"
                SELECT `id`, 
                `item_id`, 
                `firmness_id`, 
                `natural_gift_power`, 
                `natural_gift_type_id`, 
                `size`, 
                `max_harvest`, 
                `growth_time`, 
                `soil_dryness`, 
                `smoothness` 
                FROM `berries`
                WHERE `id` = @berry_id";
            }
        }

        public static string GetSpecificItem {
            get {
                return @"
                SELECT `id`, 
                `identifier`, 
                `category_id`, 
                `cost`, 
                `fling_power`, 
                `fling_effect_id`
                FROM `items`
                WHERE `id` = @item_id";
            }
        }

        public static string GetSpecificBerryFirmness {
            get {
                return @"
                SELECT `id`,
                `identifier`
                FROM `berry_firmness`
                WHERE `id` = @firmness_id";
            }
        }

        public static string GetAllTypes {
            get {
                return @"
                SELECT `id`,
                `identifier`,
                `generation_id`,
                `damage_class_id`
                FROM `types`";
            }
        }

        public static string GetSpecificType {
            get {
                return @"
                SELECT `id`,
                `identifier`,
                `generation_id`,
                `damage_class_id`
                FROM `types`
                WHERE `id` = @type_id";
            }
        }
    }
}