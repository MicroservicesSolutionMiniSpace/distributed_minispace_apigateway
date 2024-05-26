
using Convey.CQRS.Queries;
using MiniSpace.Services.Reactions.Application.Dto;
using MiniSpace.Services.Reactions.Core.Entities;
using MiniSpace.Services.Reactions.Core.Exceptions;

namespace MiniSpace.Services.Reactions.Application.Queries
{
    public class GetReactionsSummary : IQuery<ReactionsSummaryDto>
    {
        public Guid ContentId { get; set; }
        public ReactionContentType ContentType { get; set; }
    }
}