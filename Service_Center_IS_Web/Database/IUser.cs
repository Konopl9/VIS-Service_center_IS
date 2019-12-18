using System.Collections.ObjectModel;
using System.Data;
using Service_Center_IS.Database;

namespace Service_Center_IS
{
    public interface IUser<T>
    {
        Collection<T> Select();

        DataTable SelectForTable();

        Collection<T> SelectOrderById(int id);

        int Create(T user);

        int Edit(T user);

        int Delete(int id);
    }
}