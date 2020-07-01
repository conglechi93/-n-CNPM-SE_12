using CNPM_SE_12.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_SE_12.BLL
{
    class QL_FeedBack
    {
        private static QL_FeedBack _Instance;
        public static QL_FeedBack Instance

        {
            get
            {
                if (_Instance == null)
                    _Instance = new QL_FeedBack();
                return _Instance;
            }
            private set => _Instance = value;
        }
        private QL_FeedBack()
        {

        }

        public List<Link> getFB()
        {
            SE_12Entities db = new SE_12Entities();
            List<Link> link = db.Links.Select(p => p).ToList();
            return link;
        }
    }
}
