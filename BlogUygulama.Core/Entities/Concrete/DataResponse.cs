using BlogUygulama.Core.Entities.Abstract;

namespace BlogUygulama.Core.Entities.Concrete
{
    public class DataResponse : IViewReponse
    {
        public string Mesaj { get; set; }

        public object Data { get; set; }

        public bool Tamamlandi { get; set; }
    }
}