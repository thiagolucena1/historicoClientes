using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pessoas.Models
{
    public class Pessoa
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _country;
        private string _phone;
        private string _address;
        private string _city;


        public Pessoa()
        {
            

        }

        public Pessoa(string nome, string sobrenome)
        {

            FirstName = nome;
            LastName = sobrenome; 
        }



        public string FirstName
        {
            get
            {
                return _firstName.ToUpper();
            }
            set
            {

                if (value.Length < 2 || value.Length > 30)
                {
                    throw new Exception("Por gentileza, escolha um nome válido");
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName.ToUpper();
            }
            set
            {
                if (value.Length < 2 || value.Length > 30 )
                {
                    throw new Exception("Por gentileza, escolha um sobrenome válido");
                }
                _lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return _email.ToLower();
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Por gentileza, escolha um email válido");
                }

                _email = value;

            }
        }

        public string Country
        {
            set
            {
                if (value.Length > 5)
                {
                    throw new Exception("Por gentileza, escoilha apenas a inicial do país");
                }
            }
        }

        public string Phone
        {
            set
            {
                if (value.Length < 10 || value.Length > 11)
                {
                    throw new Exception("Por gentileza, escolha um telefone válido");
                }
            }
        }

        public string Address
        {
            set
            {
                if (value.Length < 5 || value.Length > 50)
                {
                    throw new Exception("Por gentileza, escolha um endereço válido");
                }
            }
        }

        public string City
        {
            set
            {
                if (value.Length < 2 || value.Length > 30)
                {
                    throw new Exception("Por gentileza, escolha uma cidade válida");
                }
            }
        }
        
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}