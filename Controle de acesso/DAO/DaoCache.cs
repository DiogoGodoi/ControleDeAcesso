using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
	public class DaoCache
	{
		private  MemoryCache cache = MemoryCache.Default;
		private  CacheItemPolicy politica;
		
		public  void AddCache(mdlEntrada dados, string chave)
		{
			politica = new CacheItemPolicy {
				AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(30)
			};

			cache.Set(chave, dados, politica);
		}
		public  List<mdlEntrada> GetCache(string chave)
		{
			return cache.Get(chave) as List<mdlEntrada>;
		}
		public void RemoveCache(string chave)
		{
			cache.Remove(chave);
		}
	}
}
