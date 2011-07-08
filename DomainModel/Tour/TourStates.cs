using Entities;


namespace DomainModel
{

    public class TourStates
    {
        private static Repository.Sql.Types repo;
        private static GeneralTypeCollection cache;


        public static void Init(string sqlConnectionString, Entities.Culture culture)
        {
            repo = new Repository.Sql.Types(sqlConnectionString);

            LoadAll(culture);
        }


        private static void LoadAll(Culture culture)
        {
            cache = repo.GetByName("GroupStateTypes", culture.Id);
        }


        public static GeneralTypeCollection GetAll()
        {
            return cache;
        }


        internal static GeneralType GetById(int id)
        {
            return cache.GetById(id);
        }


        public static GeneralType GetByIndex(int index)
        {
            if (cache.Count <= index)
            {
                return null;
            }

            return cache[index];
        }


        public static GeneralType GetNextState(GeneralType currentState)
        {
            if (currentState == null)
            {
                return GetByIndex(0);
            }

            bool found = false;
            foreach (GeneralType type in cache)
            {
                if (found)
                {
                    return type;
                }
                else if (type.Id == currentState.Id)
                {
                    found = true;
                }
            }

            return currentState;
        }

        public static bool Exists(GeneralType typeToFind)
        {
            foreach (GeneralType type in cache)
            {
                if (typeToFind == type)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
