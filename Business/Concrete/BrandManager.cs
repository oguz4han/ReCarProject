using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {

        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.Name.Length < 2)
            {
                Console.WriteLine("Marka adı en az 2 karakter olmalıdır.");
            }
            else
            {
                _brandDal.Add(brand);
                Console.WriteLine("Başarıyla eklendi.");
            }
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
    }
}
