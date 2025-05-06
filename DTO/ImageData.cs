using Emgu.CV;
namespace APO_Tsarehradskiy.DTO
{
    public record ImageData
    {
        private Mat img;
        public string fileName = string.Empty;

        public event Action<ImageData> DataUpdated;
        public event Action<ImageData, string> UpdateHistoryEvent;
        public Enums Type { get; private set; }
        public Mat Image
        {
            get
            {
                return img;
            }
            private set
            {
                img = value;
            }
        }
        public ImageData(Mat img, Enums type, string fileName)
        {
            Image = img;
            Type = type;
            this.fileName = fileName;
            //this.parent = parent;
        }
        public void Restore(ImageData restoredData)
        {
            Image?.Dispose();
            Image = restoredData.Image;
            Type = restoredData.Type;
            DataUpdated?.Invoke(this);
        }

        public void changeType(Enums newType)
        {
            Type = newType;
        }
        public void updateImage(Mat img)
        {
            if (!Image.Equals(img))
            {
                Image?.Dispose();
                Image = img;
            }
            DataUpdated?.Invoke(this);
        }

        public void UpdateHistory(string lastOperation)
        {
            UpdateHistoryEvent?.Invoke(this, lastOperation);
        }

        public bool ValidateValuesAreNull()
        {
            return img == null || string.IsNullOrWhiteSpace(fileName) || Type == default;
        }
        public ImageData DeepClone()
        {

            return new ImageData(Image.Clone(), Type, fileName);
        }
        public void CopyTo(ImageData data)
        {
            Image?.Dispose();
            Image = data.Image.Clone();
            Type = data.Type;
            fileName = data.fileName;
        }


    }
}
