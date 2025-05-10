using Emgu.CV;

namespace Apo.DTO
{
    /// <summary>
    /// Represents required information to operate on image (<c>Mat</c>).
    /// </summary>
    public record ImageData
    {
        public string fileName;

        /// <summary>
        /// This event is optionally triggered when <c>Image</c> updated.
        /// </summary>
        public event Action<ImageData>? DataUpdated;

        public event Action<ImageData, string>? UpdateHistoryEvent;
        public ImageType Type { get; private set; }
        public Mat Image { get; private set; }

        public ImageData(Mat img, ImageType type, string fileName)
        {
            Image = img;
            Type = type;
            this.fileName = fileName;
        }

        /// <summary>
        /// When strategy throws an exception, <c>StrategyExecutor</c> restores original information.
        /// </summary>
        /// <param name="image">Original image</param>
        /// <param name="type">Original type</param>
        public void Restore(Mat image, ImageType type)
        {
            Image?.Dispose();
            Image = image;
            Type = type;
            DataUpdated?.Invoke(this);
        }

        public void ChangeType(ImageType newType)
        {
            Type = newType;
        }

        public void UpdateImage(Mat mat, bool notifySubscribers = true)
        {
            Image?.Dispose();
            Image = mat;
            if (notifySubscribers)
                DataUpdated?.Invoke(this);
        }

        public void UpdateHistory(string lastOperation)
        {
            UpdateHistoryEvent?.Invoke(this, lastOperation);
        }

        public bool ValidateValuesAreNull()
        {
            return Image.IsEmpty || string.IsNullOrWhiteSpace(fileName) || Type == default;
        }

        public ImageData DeepClone()
        {
            return new ImageData(Image.Clone(), Type, fileName);
        }

        public void CopyFrom(ImageData data)
        {
            Image?.Dispose();
            Image = data.Image.Clone();
            Type = data.Type;
            fileName = data.fileName;
        }
    }

}