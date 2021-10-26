using System.Collections.Generic;
using GloboTicket.TicketManagement.Application.Features.Events.Query.GetEventExport;

namespace GloboTicket.TicketManagement.Infrastructure.Excel
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}