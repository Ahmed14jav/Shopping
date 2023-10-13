using System.Text.RegularExpressions;

namespace Shopping
{
    public class Article
    {
        #region private attributes
        private int _id;
        private string _description = "";
        private float _price = 0f;
        #endregion private attributes

        #region public methods
        public Article(int id, string description, float price)
        {
            _id = id;
            _price = price;
            _description = description;
        }


        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                Regex regex =new Regex ("!?+-*/.,;-_");
                string[] mots = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (regex.IsMatch(value))
                {
                    throw new SpecialCharInDescriptionException();
                }
                else if (valuw.Length >=51)
                {
                    throw new TooLongDescriptionException();
                }
                else if (mots.Length < 2)
                {
                    throw new TooShortDescriptionException();
                }
                 _description = value;
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }
        }

      
        #endregion public methods
        public class ArticleException : Exception { }
        public class TooShortDescriptionException : ArticleException { }
        public class SpecialCharInDescriptionException : ArticleException { }
        public class TooLongDescriptionException : ArticleException { }
    }
}
