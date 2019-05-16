using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.Repository
{
    public class RepositoryAlbum: Repository<Models.album>
    {
        public IList<Models.album> allAlbum(string name){

            return dbset.Where(c => c.name == name).ToList();
        }


    }
}