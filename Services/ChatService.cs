using Microsoft.EntityFrameworkCore;
using Entidades;

namespace Services;

[ExtendObjectType("Mutacion")]
public class ChatService
{
    private readonly IDbContextFactory<SSDBContext> ctxFactory;

    public ChatService(IDbContextFactory<SSDBContext> ctxFactory)
    {
        this.ctxFactory = ctxFactory;
    }

    public async Task<IEnumerable<Chat>> TodosLosChats()
    {
        using (var ctx = ctxFactory.CreateDbContext())
        {
            return await ctx.Chats.ToListAsync<Chat>();
        }
    }

    public async Task<Chat?> ChatPorId(Guid id)
    {
        using (var ctx = ctxFactory.CreateDbContext())
        {
            return await ctx.Chats.FindAsync(id);
        }
    }

    public async Task<Chat> CrearChat(Chat nuevo)
    {
        using (var ctx = ctxFactory.CreateDbContext())
        {
            ctx.Chats.Add(nuevo);
            await ctx.SaveChangesAsync();
        }

        return nuevo;
    }

    public async Task<bool> ModificarChat(Chat modif)
    {
        var buscado = await ChatPorId(modif.Id);

        if (buscado != null)
        {
            //     buscado.Titulo = modif.Titulo;
            //     buscado.Fecha = modif.Fecha;
            //     buscado.IdPublicacion = modif.IdPublicacion;
            //     buscado.IdModificador = modif.IdModificador;
            //     buscado.FechaModificacion = DateTime.UtcNow;

            using (var ctx = ctxFactory.CreateDbContext())
            {
                ctx.Update(modif);
                await ctx.SaveChangesAsync();
                return true;
            }
        }

        return false;
    }

    public async Task<bool> EliminarChat(Guid id)
    {
        using (var ctx = ctxFactory.CreateDbContext())
        {
            var buscado = await ChatPorId(id);

            if (buscado != null)
            {
                buscado.Activo = false;
                return await ModificarChat(buscado);
            }

            return false;
        }
    }
}