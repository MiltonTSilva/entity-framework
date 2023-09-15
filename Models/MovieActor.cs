 namespace entity_framework;

/// <summary>
/// 
/// </summary>
  public class MovieActor
    {
        /// <summary>
        /// 
        /// </summary>
        public int MovieId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public Movie Movie { get; set; } = null!;
        
        /// <summary>
        /// 
        /// </summary>
        public int ActorId { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public Actor Actor { get; set; } = null!;
        
        /// <summary>
        /// 
        /// </summary>
        public string Persona { get; set; } = null!;
        
        /// <summary>
        /// 
        /// </summary>
        public int Order { get; set; }
    }