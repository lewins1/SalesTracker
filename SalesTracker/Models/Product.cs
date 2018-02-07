using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesTracker
{
    public enum ProductType
    {
        None,
        Furry,
        Spotted,
        Dancing
    }

    public class Product
    {

        #region Fields

        private int _numberOfUnits;

        private bool _onBackorder;

        private ProductType _type;

        #endregion

        #region Properties

        public int NumberOfUnits
        {
            get { return _numberOfUnits; }

        }

        public bool OnBackorder
        {
            get { return _onBackorder; }
            set { _onBackorder = value; }
        }

        public ProductType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        #endregion

        #region Constructors

        public Product()
        {
            _type = ProductType.None;
            _numberOfUnits = 0;
        }

        public Product(ProductType type, int numberOfUnits, bool onBackorder)
        {
            _type = type;
            _numberOfUnits = numberOfUnits;
            _onBackorder = OnBackorder;
        }

        #endregion

        #region Methods

        public void AddProducts(int unitsToAdd)
        {
            _numberOfUnits = _numberOfUnits + unitsToAdd;
        }

        public void SubtractProducts(int unitsToSubtract)
        {
            if (_numberOfUnits < unitsToSubtract)
            {
                _onBackorder = true;
            }
            _numberOfUnits -= unitsToSubtract;
        }
        #endregion

    }
}
