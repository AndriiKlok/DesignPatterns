using System.Collections.Generic;

namespace Patterns.FactoryMethod
{
	abstract class Document
	{
		private List<Page> _pages = new List<Page>();

		public Document()
		{
			this.CreatePages();
		}

		public List<Page> Pages
		{
			get { return this._pages; }
		}

		public abstract void CreatePages();
	}

	class Resume : Document
	{
		public override void CreatePages()
		{
			Pages.Add(new SkillsPage());
			Pages.Add(new EducationPage());
			Pages.Add(new ExperiencePage());
		}
	}

	class Report : Document
	{
		public override void CreatePages()
		{
			Pages.Add(new IntroductionPage());
			Pages.Add(new ResultsPage());
			Pages.Add(new ConclusionPage());
			Pages.Add(new SummaryPage());
			Pages.Add(new BibliographyPage());
		}
	}
}
