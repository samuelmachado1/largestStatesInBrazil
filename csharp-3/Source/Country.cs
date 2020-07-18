using System;
using System.Collections.Generic;
//Linq - .Net library that allows you to make queries
using System.Linq;

namespace Codenation.Challenge
{
    public class Country
    {
        public State[] Top10StatesByArea()
        {
            //OrderByDescending - sorts the elements of the list in descending order.
            //Take(10) - is what determines the number of states to be listed
            //ToArray - Copies the elements of List<State> into a new array.
            return BrazilianStates.OrderByDescending(state => state.StateArea).Take(10).ToArray();
        }

        private List<State> BrazilianStates = new List<State>()
        {
            new State("Acre", "AC", 164123.040),
            new State("Alagoas", "AL", 27778.506),
            new State("Amap�", "AP", 142828.521),
            new State("Amazonas", "AM", 1559159.148),
            new State("Bahia", "BA", 564733.177),
            new State("Cear�", "CE", 148920.472),
            new State("Distrito Federal", "DF", 5779.999),
            new State("Esp�rito Santo", "ES", 46095.583),
            new State("Goi�s", "GO", 340111.783),
            new State("Maranh�o", "MA", 331937.450),
            new State("Mato Grosso", "MT", 903366.192),
            new State("Mato Grosso do Sul", "MS", 357145.532),
            new State("Minas Gerais", "MG", 586522.122),
            new State("Par�", "PA", 1247954.666),
            new State("Para�ba", "PB", 56585.000),
            new State("Paran�", "PR", 199307.922),
            new State("Pernambuco", "PE", 98311.616),
            new State("Piau�", "PI", 251577.738),
            new State("Rio de Janeiro", "RJ", 43780.172),
            new State("Rio Grande do Norte", "RN", 52811.047),
            new State("Rio Grande do Sul", "RS", 281730.223),
            new State("Rond�nia", "RO", 237590.547),
            new State("Roraima", "RR", 224300.506),
            new State("Santa Catarina", "SC", 95736.165),
            new State("S�o Paulo", "SP", 248222.362),
            new State("Sergipe", "SE", 21915.116),
            new State("Tocantins", "TO", 277720.520)
        };
    }
}
