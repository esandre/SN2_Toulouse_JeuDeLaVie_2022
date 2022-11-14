namespace JeuDeLaVie.Test.Utilities
{
    internal class CelluleGenerator
    {
        private bool _etatInitialCellules = false;
        private readonly List<Func<int, bool>> _exceptions = new List<Func<int, bool>>();

        public IEnumerable<Cellule> Generate(int howMany)
        {
            for (var i = 0; i < howMany; i++)
            {
                var estUneException = _exceptions.Any(exception => exception(i));
                yield return new Cellule(estUneException ? !_etatInitialCellules : _etatInitialCellules);
            }
        }

        public CelluleGenerator ToutesMortes()
        {
            _etatInitialCellules = false;
            return this;
        }

        public CelluleGenerator ToutesVivantes()
        {
            _etatInitialCellules = true;
            return this;
        }

        public CelluleGenerator Sauf(int exception)
        {
            _exceptions.Add(indice => indice == exception);
            return this;
        }

        public CelluleGenerator Sauf(Func<int, bool> exception)
        {
            _exceptions.Add(exception);
            return this;
        }
    }
}
