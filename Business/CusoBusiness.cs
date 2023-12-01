using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class CusoBusiness
    {

        private CusrsoDao categoriaDAO = new CusrsoDao();

        public List<Curosenty> listarCategorias()
        {
            return categoriaDAO.ListarCategoria();
        }
        public void Car(Curosenty app)
        {
          
            using (var trx = new TransactionScope())
            {
              
                trx.Complete();
            }
        }
    }
}
