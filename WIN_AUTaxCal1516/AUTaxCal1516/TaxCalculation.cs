using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTaxCal1516
{
    class TaxCalculation
    {
        private double _AnnualTax;
        private double _GrossAmount;
        private double _AnnualSuper;
        private double _AnnualtakeHome;
        private double _TaxPercentage;
        public double GrossAmount
        {
            set { _GrossAmount = value; }
            get { return _GrossAmount; }
        }
        public double AnnualTax
        {
            get { return _AnnualTax; }
            //set { _AnnualTax = value; }
        }
        public double AnnualSuper
        {
            get { return _AnnualSuper; }
            //set { _AnnualSuper = value; }
        }
        public double AnnualtakeHome
        {
            get { return _AnnualtakeHome; }
            //set { _AnnualtakeHome = value; }
        }
        public double TaxPercentagePaid
        {
            get { return _TaxPercentage; }
            //set { _TaxPercentage = value; }
        }
        public TaxCalculation()
        {
            _GrossAmount = 0;
            _AnnualTax = 0;
            _AnnualSuper = 0;
            _AnnualtakeHome = 0;
            _TaxPercentage = 0;
        }

        public bool Calculate()
        {
            bool vReturn = false;
            double dTaxableAmout = 0;
            double localGrossAmount = _GrossAmount;
            try
            {
                _AnnualSuper = localGrossAmount * 0.095; //9.5%

                while (localGrossAmount > 0)
                {
                    if (localGrossAmount <= 18200)
                    {
                        dTaxableAmout = localGrossAmount - 0;
                        _AnnualTax = _AnnualTax + dTaxableAmout * 0.0;
                        localGrossAmount = localGrossAmount - dTaxableAmout;
                    }
                    else if (localGrossAmount > 18200 && localGrossAmount <= 37000)
                    {
                        dTaxableAmout = localGrossAmount - 18200;
                        _AnnualTax = _AnnualTax + dTaxableAmout * 0.19;
                        localGrossAmount = localGrossAmount - dTaxableAmout;
                    }
                    else if (localGrossAmount > 37001 && localGrossAmount <= 80000)
                    {
                        dTaxableAmout = localGrossAmount - 37000;
                        _AnnualTax = _AnnualTax + dTaxableAmout * 0.325;
                        localGrossAmount = localGrossAmount - dTaxableAmout;
                    }
                    else if (localGrossAmount > 80001 && localGrossAmount <= 180000)
                    {
                        dTaxableAmout = localGrossAmount - 80000;
                        _AnnualTax = _AnnualTax + dTaxableAmout * 0.37;
                        localGrossAmount = localGrossAmount - dTaxableAmout;
                    }
                    else if (localGrossAmount > 180001)
                    {
                        dTaxableAmout = localGrossAmount - 180000;
                        _AnnualTax = _AnnualTax + dTaxableAmout * 0.45;
                        localGrossAmount = localGrossAmount - dTaxableAmout;
                    }
                }
                _AnnualtakeHome = _GrossAmount - _AnnualSuper - _AnnualTax;
                _TaxPercentage = _AnnualTax / _GrossAmount;

                vReturn = true;
            }
            catch (Exception ex) { throw ex; }
            return vReturn;
        }
    }
}


/*
 * https://www.ato.gov.au/rates/individual-income-tax-rates/
 Taxable income
Tax on this income
0 – $18,200
Nil
$18,201 – $37,000
19c for each $1 over $18,200
$37,001 – $80,000
$3,572 plus 32.5c for each $1 over $37,000
$80,001 – $180,000
$17,547 plus 37c for each $1 over $80,000
$180,001 and over
$54,547 plus 45c for each $1 over $180,000

 */