package Observer.observers;

import Observer.contracts.IScreen;

public class ScreenErr implements IScreen {

	@Override
	public void update(Integer data) {

		System.err.print(data);
	}

}
