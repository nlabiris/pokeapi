using System;
using System.Configuration;
using System.Data;

namespace PokeAPI.DataAccess {
    internal static class DatabaseExtensions {
        public static void AddWithValue<T>(this IDbCommand command, string name, T value) {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            command.Parameters.Add(parameter);
        }
    }   
}