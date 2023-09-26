using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

// criando a classe TarefaController e herdando seus metodos de Controller
public class TarefaController : Controller
{
    //criando um objeto _tarefa que armazenará uma lista de tarefas
    private static List<Tarefa> _tarefas = new List<Tarefa>();

    public IActionResult Index()
    {
        return View(_tarefas);
    }
    
    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]

    public IActionResult Adicionar(Tarefa novaTarefa)
    {
        //verificando o total de tarefas da lista e somando mais 1 para criar o ID
        novaTarefa.Id = _tarefas.Count + 1;
        //Adicionando minha nova tarefa á minha lista
        _tarefas.Add(novaTarefa);
        //redirecionando para pagina principal com uma lista de tarefa
        return RedirectToAction("Index");
    }
    public IActionResult Editar(int Id)
    {
        //estou buscando na minha lista a tarefa que desejo alterar
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);
        //verificando se ela existe
        if (novaTarefa == null)
        return NotFound();

        //Enviando para a View a tarefa que queremos alterar    
        return View(novaTarefa);
    }

    [HttpPost]
    public IActionResult Editar(Tarefa tarefaEditando)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == tarefaEditando.Id);
        if (tarefaEncontrada == null)
        return NotFound();

        tarefaEncontrada.Descricao = tarefaEditando.Descricao;
        tarefaEncontrada.Concluida = tarefaEditando.Concluida;
        return RedirectToAction("Index");
    }
    
    public IActionResult Deletar(int Id)
    {
        //estou buscando na minha lista a tarefa que desejo alterar
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);
        //verificando se ela existe
        if (novaTarefa == null)
        return NotFound();

        //Enviando para a View a tarefa que queremos alterar    
        return View(novaTarefa);
    }

    [HttpPost]
    public IActionResult DeletarConfirmado(int Id)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == Id);
        if (tarefaEncontrada == null)
        return NotFound();

        _tarefas.Remove(tarefaEncontrada);
        return RedirectToAction("Index");
    }
    
}