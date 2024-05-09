using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormProject.OOPCODE
{
    public class CompanyAddtionalImageDAO
    {
        DBConnection conn = new DBConnection();
        public CompanyAddtionalImageDAO() { }
        public List<Image> FetchAllPictures(string companyid)
        {
            string strFetch = string.Format("Select * From ImgCompany where companyid = '{0}'", companyid);
            return conn.FetchAllImg(strFetch);
        }
        public void InsertImage(string companyid, List<Image> images)
        {
            DeleteImage(companyid);
            List<byte[]> ImageBytes = ImageHandler.ConvertListImgToListByte(images);
            while (ImageBytes.Count < 5)
            {
                ImageBytes.Add(new byte[0]);
            }
            string SQL = "INSERT INTO imgcompany (companyid, imgid1, imgid2, imgid3, imgid4, imgid5) " +
              "VALUES (@companyId, @img1, @img2, @img3, @img4, @img5)";
            conn.InsertImageIntoImgCompany(SQL,companyid,ImageBytes);
        }
        public void DeleteImage(string companyid)
        {
            string SQL = string.Format("DELETE FROM ImgCompany WHERE companyid = {0}", companyid);
            conn.CRUD(SQL);
        }
    }
}
