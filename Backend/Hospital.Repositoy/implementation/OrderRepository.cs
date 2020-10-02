using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;

namespace Hospital.Repositoy.implementation
{
    public class OrderRepository : IOrderRepository
    {

         private ApplicationDbContext context;

        public OrderRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public bool Delete(int Idd)
        {
              try
            {
                var orderOrigina = context.Orders.Single(
                     x => x.Id == Idd);
                context.Remove(orderOrigina);
                context.SaveChanges();
            }
            catch(System.Exception)
            {
                return false;
            }
            return true;
        }

        public Order Get(int id)
        {
           var result = new Order();
            try {
                result = context.Orders.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Order> GetAll()
        {
             var result = new List<Order>();
            try
            {
                result = context.Orders.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Order entity)
        {
            try
            {
             
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {


                return false;
            }
            return true;
        }


        public bool Update(Order entity)
        {
           try
            {
                 var orderOrigina = context.Orders.Single(
                     x => x.Id == entity.Id
                 );

            
                 orderOrigina.Id=entity.Id;
                 orderOrigina.Priority = entity.Priority;
                 orderOrigina.Datee= entity.Datee;
                 orderOrigina.Description=entity.Description;
                 orderOrigina.Idmedicalequipment =entity.Idmedicalequipment;
                 orderOrigina.Nombremedicalequipment = entity.Nombremedicalequipment;
                 context.Update(orderOrigina);
                 context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }

            public IEnumerable<Order> Select(int id)
        {
            var result = context.Orders.ToList();
            return result.Select(c => new Order
            {
                Id = c.Id,
                Description= c.Description,
            });
           
        }

        public IEnumerable<Order> Listarid(int id)
        {
       

         throw new System.NotImplementedException();

        }


           
    }
    
}