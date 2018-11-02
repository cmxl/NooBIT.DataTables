namespace NooBIT.DataTables.Internationalization.Languages
{
    internal class Indonesian : NamedLanguageSettings
    {
        internal Indonesian() : base("id-ID")
        {
            EmptyTable = "Tidak ada data yang tersedia pada tabel ini";
            Info = $"Menampilkan {START} sampai {END} dari {TOTAL} entri";
            InfoEmpty = "Menampilkan 0 sampai 0 dari 0 entri";
            InfoFiltered = $"(disaring dari {MAX} entri keseluruhan)";
            InfoPostFix = "";
            InfoThousands = null;
            LengthMenu = $"Tampilkan {MENU} entri";
            LoadingRecords = null;
            Processing = "Sedang memproses...";
            Search = "Cari:";
            ZeroRecords = "Tidak ditemukan data yang sesuai";
            Paginate = new Paginate
            {
                First = "Pertama",
                Previous = "Sebelumnya",
                Next = "Selanjutnya",
                Last = "Terakhir",
            };
        }
    }
}

