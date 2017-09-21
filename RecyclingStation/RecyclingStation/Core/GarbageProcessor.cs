﻿namespace RecyclingStation.Core
{
    using System;
    using System.Linq;
    using Contracts;
    using Entities.Attributes;

    public class GarbageProcessor : IGarbageProcessor
    {
        public GarbageProcessor(IStrategyHolder strategyHolder)
        {
            this.StrategyHolder = strategyHolder;
        }

        public GarbageProcessor()
            : this(new StrategyHolder())
        {
        }

        public IStrategyHolder StrategyHolder { get; private set; }

        public IProcessingData ProcessWaste(IWaste garbage)
        {
            Type type = garbage.GetType();
            DisposableAttribute disposalAttribute = (DisposableAttribute)type.GetCustomAttributes(true).FirstOrDefault(x => x.GetType() == typeof(DisposableAttribute));

            IGarbageDisposalStrategy currentStrategy;

            if (disposalAttribute == null || !this.StrategyHolder.GetDisposalStrategies.TryGetValue(disposalAttribute.GetType(), out currentStrategy))
            {
                throw new ArgumentException(
                    "The passed in garbage does not implement a supported Disposable Strategy Attribute.");
            }

            return currentStrategy.ProcessGarbage(garbage);
        }
    }
}
