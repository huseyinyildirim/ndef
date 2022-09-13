namespace buluton.ndef
{
    interface IRecordConverter
    {
        void Generate(NdefRecord record, byte[] type, byte[] id, byte[] payload);
    }
}
