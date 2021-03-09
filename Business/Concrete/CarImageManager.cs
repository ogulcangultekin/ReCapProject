using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
       
        public IResult Add(CarImage carImage)
        {
            IResult result=BusinessRules.Run(CheckIfCarImageLimitExceded(carImage.CarId));
            if (result!= null)
            {
                return result;
            }
           

            _carImageDal.Add(carImage);
            return new SuccessResult("Araba resmi eklendi");
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult("Araba resmi");
        }
        public IResult Update(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult("Araba resmi güncellendi.");
        }

        public IDataResult<CarImage> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfCarImageLimitExceded(int carId)
        {
            var result = _carImageDal.GetAll(p=>p.CarId==carId).Count;
            if (result>=5)
            {
                return new ErrorResult("En fazla 5 resme sahip olabilir");
            }
            return new SuccessResult();
        }
    }
}
