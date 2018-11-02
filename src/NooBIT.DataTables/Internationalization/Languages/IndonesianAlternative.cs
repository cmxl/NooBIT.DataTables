namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class IndonesianAlternative : NamedLanguageSettings
    {
        internal IndonesianAlternative() : base("id")
        {
            EmptyTable = null;
            Info = $"Tampilan {START} sampai {END} dari {TOTAL} entri";
            InfoEmpty = "Tampilan 0 hingga 0 dari 0 entri";
            InfoFiltered = $"(disaring dari {MAX} entri keseluruhan)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Tampilan {MENU} entri";
            LoadingRecords = null;
            Processing = "Sedang proses...";
            Search = "Cari:";
            ZeroRecords = "Tidak ditemukan data yang sesuai";
            Paginate = new Paginate
            {
                First = "Awal",
                Previous = "Balik",
                Next = "Lanjut",
                Last = "Akhir",
            };
        }
    }
}

