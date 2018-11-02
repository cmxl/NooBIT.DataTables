namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Mongolian : NamedLanguageSettings
    {
        internal Mongolian() : base("mn-Cyrl")
        {
            EmptyTable = "Хүснэгт хоосон байна";
            Info = $"Нийт {TOTAL} бичлэгээс {START} - {END} харуулж байна";
            InfoEmpty = "Тохирох үр дүн алга";
            InfoFiltered = $"(нийт {MAX} бичлэгээс шүүв)";
            InfoPostFix = "";
            InfoThousands = ",";
            LengthMenu = $"Дэлгэцэд {MENU} бичлэг харуулна";
            LoadingRecords = "Ачааллаж байна...";
            Processing = "Боловсруулж байна...";
            Search = "Хайлт:";
            ZeroRecords = "Тохирох бичлэг олдсонгүй";
            Paginate = new Paginate
            {
                First = "Эхнийх",
                Previous = "Дараах",
                Next = "Өмнөх",
                Last = "Сүүлийнх",
            };
            Aria = new Aria
            {
                SortAscending = ": цагаан толгойн дарааллаар эрэмбэлэх",
                SortDescending = ": цагаан толгойн эсрэг дарааллаар эрэмбэлэх",
            };
        }
    }
}

