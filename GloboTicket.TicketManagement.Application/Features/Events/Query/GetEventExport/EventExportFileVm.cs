namespace GloboTicket.TicketManagement.Application.Features.Events.Query.GetEventExport
{
    public class EventExportFileVm
    {
        public string EventExportFileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }
}