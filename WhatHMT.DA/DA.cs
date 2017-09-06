using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatHMT.DA
{
	public class DA
	{
		public List<StoreToys> getStoreToysByStoreGuid(Guid StoreGuid)
		{
			List<StoreToys> _result = new List<StoreToys>();
			try
			{
				using (var _context = new Context())
				{
					var st = _context.dsStoreToys;

					if (StoreGuid != Guid.Empty)
					{
						st.Where(t => t.StoreGUID == StoreGuid);
					}

					_result = st.ToList();
				}

				return _result;
			}
			catch (Exception e)
			{
				throw new Exception("Fatal: getStoreToysByStoreGuid " + e.Message, e.InnerException);
			}
		}

		public StoreToys addNewStoreToy(StoreToys newStoreToy)
		{
			try
			{
				using (var _context = new Context())
				{
					_context.dsStoreToys.Add(newStoreToy);
					_context.SaveChanges();
				}

				return newStoreToy;
			}
			catch (Exception e)
			{
				throw new Exception("Fatal: addNewStoreToys " + e.Message, e.InnerException);
			}

		}

		public void updateStoreToys(StoreToys updateStoreToy)
		{
			try
			{
				using (var _context = new Context())
				{
					var _storeToy = _context.dsStoreToys.First(s => s.Id == updateStoreToy.Id);

				}

			}
			catch (Exception e)
			{
				throw new Exception("Fatal: addNewStoreToys " + e.Message, e.InnerException);
			}
		}
	}
}
