using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            
            if(rental.ReturnDate==null)
            {
                return new ErrorResult("Bu araba zaten kiralık");
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult("Araba kiralandi.");
            }
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult("Araba silindi.");
        }

        public IDataResult<Rental> Get(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.Id == id), "Araba listelendi");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), "Arabalar Listelendi");
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetail(), "Kiralananlar listelendi");
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult("Araba güncellendi.");
        }
    }
}
