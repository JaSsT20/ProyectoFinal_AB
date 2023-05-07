using System.Linq.Expressions;
public class ClientBLL
{
    private Context _context;
    public ClientBLL(Context context)
    {	
        _context = context;
    }
    
    public bool Exist(int ClientId)
    {
        return _context.Clients.Any(item => item.ClientId == ClientId);
    }
    public bool Insert(Client client)
    {
        bool changes = false;
        _context.Clients.Add(client);
        changes = _context.SaveChanges() > 0;
        _context.Clients.Entry(client).State = EntityState.Detached;
        return changes;
    }
    public bool Modify(Client client)
    {
        bool changes = false;
        _context.Entry(client).State = EntityState.Modified;
        changes =  _context.SaveChanges() > 0;
        _context.Clients.Entry(client).State = EntityState.Detached;
        return changes;
    }
    public bool Save(Client client)
    {
        try{
            if(!Exist(client.ClientId))
                return Insert(client);
            else
                return Modify(client);
        }
        catch(Exception)
        {
            return false;
        }   
    }
    public bool Delete(Client client)
    {
        bool changes = false;
        try{
            _context.Entry(client).State = EntityState.Deleted;
            changes = _context.SaveChanges() > 0;
            _context.Clients.Entry(client).State = EntityState.Detached;
            return changes;
        }
        catch(Exception){
            return false;
        }
    }
    public Client? Search(int ClientId)
    {
        return _context.Clients.Where(cli => cli.ClientId == ClientId).AsNoTracking().SingleOrDefault();
    }
    public List<Client> GetList(Expression<Func<Client,bool>> criterion)
    {
        return _context.Clients.AsNoTracking().Where(criterion).ToList();
    }
}