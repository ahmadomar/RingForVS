using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ring.VisualStudio.TextEditor
{
    class RingLanguage
    {
        #region Member Variables

        private List<string> _comments = new List<string>();
        private List<string> _quoted = new List<string>();
        private List<string> _numeric = new List<string>();
        private List<string> _keyWords = new List<string>();
        private List<string> _identiferTypes = new List<string>();
        private List<string> _custom = new List<string>();

        #endregion

        #region Properties

        public List<string> Comments
        {
            get { return _comments; }
        }
        public List<string> Quoted
        {
            get { return _quoted; }
        }
        public List<string> Numeric
        {
            get { return _numeric; }
        }
        public List<string> KeyWords
        {
            get { return _keyWords; }
        }
        public List<string> IdentifierTypes
        {
            get { return _identiferTypes; }
        }

        #endregion

        #region ctor

        public RingLanguage()
        {
            Initialize();
        }

        #endregion

        #region Methods

        private void Initialize()
        {
            _comments.Add(@"\b#\b");

            _comments.Add(@"\b\\\b");

            _quoted.Add(@"([""'])(?:\\\1|.)*?\1");

            _numeric.Add(@"\b\d+\b");
            _numeric.Add(@"\>");
            _numeric.Add(@"\<");
            _numeric.Add(@"\<\>");
            _numeric.Add(@"\=");
            _numeric.Add(@"\=\=");

            _keyWords.Add("IF");
            _keyWords.Add("TO");
            _keyWords.Add("OR");
            _keyWords.Add("AND");
            _keyWords.Add("NOT");
            _keyWords.Add("FOR");
            _keyWords.Add("NEW");
            _keyWords.Add("FUNC");
            _keyWords.Add("FROM");
            _keyWords.Add("NEXT");
            _keyWords.Add("LOAD");
            _keyWords.Add("ELSE");
            _keyWords.Add("SEE");
            _keyWords.Add("WHILE");
            _keyWords.Add("OK");
            _keyWords.Add("CLASS");
            _keyWords.Add("BREAK");
            _keyWords.Add("RETURN");
            _keyWords.Add("BUT");
            _keyWords.Add("END");
            _keyWords.Add("GIVE");
            _keyWords.Add("BYE");
            _keyWords.Add("EXIT");
            _keyWords.Add("TRY");
            _keyWords.Add("CATCH");
            _keyWords.Add("DONE");
            _keyWords.Add("SWITCH");
            _keyWords.Add("ON");
            _keyWords.Add("OTHER");
            _keyWords.Add("OFF");
            _keyWords.Add("IN");
            _keyWords.Add("LOOP");
            _keyWords.Add("PACKAGE");
            _keyWords.Add("IMPORT");
            _keyWords.Add("PRIVATE");
            _keyWords.Add("STEP");
            _keyWords.Add("DO");
            _keyWords.Add("AGAIN");
            _keyWords.Add("CALL");
            // Types
            //_identiferTypes.Add(@"\bvoid\b");
            //_identiferTypes.Add(@"\bboolean\b");
            //_identiferTypes.Add(@"\binteger\b");
            //_identiferTypes.Add(@"\bfloat\b");
            //_identiferTypes.Add(@"\bdouble\b");
            //_identiferTypes.Add(@"\bstring\b");
            //_identiferTypes.Add(@"\bobject\b");
            //_identiferTypes.Add(@"\binterface\b");
            //_identiferTypes.Add(@"\binvalid\b");
        }

        #endregion
    };
}
