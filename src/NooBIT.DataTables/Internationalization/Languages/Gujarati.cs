namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Gujarati : NamedLanguageSettings
    {
        internal Gujarati() : base("gu")
        {
            EmptyTable = "કોષ્ટકમાં કોઈ ડેટા ઉપલબ્ધ નથી";
            Info = $"કુલ_પ્રવેશો_અંત_પ્રારંભ_દર્શાવે_છે";
            InfoEmpty = "0 પ્રવેશો 0 0 બતાવી રહ્યું છે";
            InfoFiltered = $"({MAX} કુલ પ્રવેશો માંથી ફિલ્ટર)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"બતાવો {MENU} પ્રવેશો";
            LoadingRecords = "લોડ કરી રહ્યું છે ...";
            Processing = "પ્રક્રિયા ...";
            Search = "શોધો:";
            ZeroRecords = "કોઈ મેળ ખાતા રેકોર્ડ મળી";
            Paginate = new Paginate
            {
                First = "પ્રથમ",
                Previous = "ગત",
                Next = "આગામી",
                Last = "અંતિમ",
            };
            Aria = new Aria
            {
                SortAscending = ": સ્તંભ ચડતા ક્રમમાં ગોઠવવા માટે સક્રિય",
                SortDescending = ": કૉલમ ઉતરતા ક્રમમાં ગોઠવવા માટે સક્રિય",
            };
        }
    }
}

