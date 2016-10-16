﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


using CdkAssign01.Models.DTO;
using CdkAssign01.DAL;
using CdkAssign01.Utility;

namespace CdkAssign01.BAL
{
    public class CustomersRepository
    {


        public static CustomerDTO GetCustomerById(int customerId)
        {
            DataSet ds = CustomersEngine.GetCustomerById(customerId);

            CustomerDTO customerDTO = new CustomerDTO();

            DataTable table = ds.Tables[0];

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];

                customerDTO.CustomerId = SqlHelper.GetSafeInt(row["CustomerId"]);
                customerDTO.FirstName = SqlHelper.GetSafeString(row["FirstName"]);
                customerDTO.LastName = SqlHelper.GetSafeString(row["LastName"]);
                customerDTO.Address = SqlHelper.GetSafeString(row["Address"]);
                customerDTO.City = SqlHelper.GetSafeString(row["City"]);
                customerDTO.StateCode = SqlHelper.GetSafeString(row["StateCode"]);
                customerDTO.PostalCode = SqlHelper.GetSafeString(row["PostalCode"]);
            }

            return customerDTO;
        }

    }

}