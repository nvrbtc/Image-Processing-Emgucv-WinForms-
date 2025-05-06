namespace APO_Tsarehradskiy.DTO
{
    public record LogImageStorage
    {
        public byte[] JpegData { get; init; }
        public string Operation { get; init; }
        public bool IsGray { get; init; }
        public LogImageStorage(byte[] JpegData, string operation, bool IsGray = false)
        {
            this.JpegData = JpegData;
            this.Operation = operation;
            this.IsGray = IsGray;
        }
    }
}
