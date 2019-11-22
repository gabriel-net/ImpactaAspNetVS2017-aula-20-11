﻿create procedure TarefaSelecionar
	@id int = null
as

SELECT [Id]
      ,[Nome]
      ,[Prioridade]
      ,[Concluida]
      ,[Observacao]
  FROM [dbo].[Tarefa]
Where Id = ISNULL(@id, Id)
order by Concluida, Prioridade