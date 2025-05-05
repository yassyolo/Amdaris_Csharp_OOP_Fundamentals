/Domain
  /Users
    └── ApplicationUser.cs
    └── Notification.cs
    └── Seller/
        └── Seller.cs
        └── Education.cs
        └── Certification.cs
        └── Skill.cs
        └── Portfolio.cs
    └── Buyer/
        └── Buyer.cs   
        └── BillingDetails.cs 
        └── BrowsingHistory.cs
        └── FavouriteGig.cs
        └── FavouriteGigsList.cs
    └── Language.cs
    └── UserLanguage.cs   
    └── Address.cs
    └── Enums/
        └── ProficiencyLevel.cs
        └── EducationDegree.cs
        └── SkillLevel.cs
  /Gigs
    └── Gig.cs
    └── GigMetadata.cs
    └── GigRequirement.cs
    └── PaymentPlanInclude.cs
    └── PaymentPlan.cs
    └── Tag.cs
    └── Enums/
  /Orders
    └── Order.cs
    └── OrderDeliveryDate.cs
    └── Review.cs
    └── Invoice.cs
    └── Revision.cs
    └── Delivery.cs
    └── GigRequirementAnswer.cs
    └── Enums/
        └── OrderStatus.cs
        └── RevisionStatus.cs
   /Categories
    └── MainCategory.cs
    └── SubCategory.cs
    └── SubSubCategory.cs
    └── FilterOption.cs
    └── GigFilter.cs
    └── FAQ.cs
    └── Enums/
        └── GigFilterType.cs
  /Messaging
    └── Conversation.cs
    └── Message.cs
  /CustomOffer
    └── CustomOffer.cs
    └── Enums/
        └── CustomOfferStatus.cs
  /Moderation
    └── DeactivationRecord.cs
    └── ReportedItem.cs
    └── Enums/
        └── ModerationStatus.cs
  /CustomRequests
    └── CustomRequest.cs
    └── Enums/
        └── CustomRequestStatus.cs
  /ProjectBrief
    └── ProjectBrief.cs
    └── Enums/
        └── ProjectBriefStatus.cs
  /Shared
    └── Contracts/
        └── IBaseEntity.cs
        └── ISoftDeletable.cs
    └── BaseEntity.cs
    └── Events
        └── Gig/
            └── GigCreatedEvent.cs
            └── GigUpdatedEvent.cs
            └── GigDeletedEvent.cs
        └── User/
            └── UserCreatedEvent.cs  
            └── UserUpdatedEvent.cs  
        └── Orders/
           └── OrderPlacedEvent.cs
           └── OrderStatusChangedEvent.cs
    └── Exceptions/
        └── NotFoundException.cs
        └── Gig/
            └── GigNotFoundException.cs
            └── GigAlreadyExistsException.cs
        └── User/
            └── UserNotFoundException.cs
            └── UserAlreadyExistsException.cs
            └── UserIsNotSellerException.cs
            └── UserIsNotBuyerException.cs      
        └── Order/
            └── OrderNotFoundException.cs
            └── OrderAlreadyExistsException.cs
            └── InvalidOrderStatusTransitionException.cs
        └── Category/
            └── CategoryNotFoundException.cs
            └── CategoryAlreadyExistsException.cs
            └── FilterAlreadyExistsException.cs
        └── Messaging/
            └── ConversationNotFoundException.cs
            └── MessageNotFoundException.cs
            └── ConversationAlreadyExistsException.cs
        └── CustomOffer/
            └── CustomOfferNotFoundException.cs
            └── CustomOfferAlreadyExistsException.cs
            └── CustomOfferHasExpiredException.cs
            └── CustomOfferAlreadyAcceptedException.cs
            └── CustomOfferAlreadyRejectedException.cs
        └── CustomRequest/
            └── CustomRequestNotFoundException.cs
            └── CustomRequestAlreadyExistsException.cs
            └── RequestWithdrawnException.cs
        └── ProjectBrief/
            └── ProjectBriefNotFoundException.cs
            └── ProjectBriefAlreadyExistsException.cs
            └── ProjectBriefWithdrawnException.cs
        └── Moderation/
            └── ReportNotFoundException.cs
            └── DeactivationRecordNotFoundException.cs
            └── DeactivationRecordAlreadyExistsException.cs

    └──Constants/
       └── EntityPropertyLength.cs
       └── UserRoles.cs
  








/Application
│
├── Common/
│   ├── Behaviors/
│   │   └── ValidationBehavior.cs
│   │   └── LoggingBehavior.cs
│   │   └── PerformanceBehavior.cs
│   │
│   ├── Interfaces/
│   │   ├── Abstractions/
│   │   │  ├── ICommand.cs
│   │   │  ├── IQuery.cs
│   │   │  ├── ICommandHandler.cs
│   │   │  └── IQueryHandler.cs
│   │   └── Services/
│   │      ├── ICacheService.cs
│   │      ├── INotificationService.cs
│   │      ├── ICloudStorageService.cs
│   │      ├── IEmailService.cs
│   │      └── IChatService.cs
│   │
│   └── Mapping/
│   |    └── MappingConfig.cs 
|   └── Extensions/
|        └── ServiceCollectionExtensions.cs 
│
├── Gigs/
│   ├── DTOs/
│   │   ├── GigDto.cs
│   │   ├── CreateGigDto.cs
│   │   └── UpdateGigDto.cs
│   ├── Queries/
|   |   ├── Create/
│   │   |   ├── CreateGigCommand.cs
│   │   |   ├── CreateGigCommandHandler.cs
│   │   |  └── CreateGigCommandValidator.cs
|   |   ├──GetById/
│   │      ├── GetGigByIdQuery.cs
│   │      ├── GetGigByIdQueryHandler.cs
│   │      └── GetGigByIdResponse.cs
|   |──Commands/
│   |   ├──Update/
│   │   |   ├── UpdateGigCommand.cs
│   │   |   ├── UpdateGigCommandHandler.cs
│   │   |   └── UpdateGigCommandValidator.cs
│   ├── Events/
│   │   ├── GigUpdatedEventHandler.cs
│   │   └── GigCreatedEventHandler.cs
│   └── Interfaces/
│       └── IGigRepository.cs
│
└── Users/
    ├── DTOs/
    │   ├── UserDto.cs
    │   └── UpdateUserDto.cs
    ├── Update/
    │   ├── UpdateUserCommand.cs
    │   ├── UpdateUserCommandHandler.cs
    │   └── UpdateUserCommandValidator.cs
    ├── Events/
    │   └── UserUpdatedEventHandler.cs
    └── Interfaces/
        └── IUserRepository.cs






/Infrastructure
│
├── Extensions/
│   └── ServiceCollectionExtensions.cs      
│
├── Persistence/
│   ├── AppDbContext.cs
│   ├── ApplicationUser.cs                   
│   ├── Seed/
│   │   └── DbSeeder.cs                      
│   ├── Configurations/
│   │   ├── GigConfiguration.cs
│   │   ├── UserConfiguration.cs
│   └── Repositories/
│       ├── GigRepository.cs                 
│       ├── UserRepository.cs
│
├── Caching/
│   └── MemoryCacheService.cs                
│
├── Communication/
│   └── EmailSenderService.cs                
│
├── CloudStorage/
│   └── CloudinaryService.cs
│
└── Realtime/
    └── Services/
        └── NotificationService.cs
        └── ChatService.cs
    └── Hubs/
        └── NotificationHub.cs
        └── ChatHub.cs





/Presentation
│
├── Modules/
│   ├── GigsModule.cs
│   ├── UsersModule.cs
│   └── ChatModule.cs
│
├── Hubs/
│   └── ChatHub.cs
│
├── Extensions/
│   └── ServiceCollectionExtensions.cs
│
└── Filters/
    └── GlobalExceptionHandler.cs 
