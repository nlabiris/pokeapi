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
    }
}