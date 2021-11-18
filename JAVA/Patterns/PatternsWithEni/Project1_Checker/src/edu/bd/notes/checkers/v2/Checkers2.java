package edu.bd.notes.checkers.v2;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

import javax.swing.JComponent;
import javax.swing.JFrame;
import javax.swing.JLabel;

import edu.bd.notes.checkers.board.Board;

public class Checkers2 extends JFrame implements MouseListener {

	private Board board = new Board();
	private int selectedPiece[];
	private JLabel statusBar;
	private final Dimension minimumSize = new Dimension(80 * 8, 80 * 8);
	private final Dimension preferedSize = new Dimension(80 * 8, 80 * 8);
	private final Dimension maximumSize = new Dimension(80 * 8, 80 * 8);

	/**
	 * Entry point
	 * 
	 * @param args
	 */
	public static void main(String[] args) {
		Checkers2 checkers = new Checkers2();
		checkers.setLocationRelativeTo(null);
		checkers.setVisible(true);
	}

	class BoardComponent extends JComponent {
		public BoardComponent() {
			// Set sizes
			setMinimumSize(minimumSize);
			setPreferredSize(preferedSize);
			setMaximumSize(maximumSize);
		}

		@Override
		public void paint(Graphics graphics) {
			// Draw component
			// For each row
			for (int row = 0; row < 8; row++) {
				// For each case
				for (int column = 0; column < 8; column++) {

					paintCase(graphics, row, column);
				}
			}
		}

		private void paintCase(Graphics graphics, int row, int column) {
			if (isEven(row, column))
				graphics.setColor(Color.WHITE);
			else
				graphics.setColor(Color.BLACK);

			graphics.fillRect(column * 80, row * 80, 80, 80);

			int piece = board.getPiece(column, row);
			if (piece >= 0) {
				if ((piece % 2) == 0)
					graphics.setColor(Color.BLACK);
				else
					graphics.setColor(Color.WHITE);

				graphics.fillOval(column * 80 + 5, row * 80 + 5, 70, 70);
				graphics.setColor(Color.WHITE);
				graphics.drawOval(column * 80 + 5, row * 80 + 5, 70, 70);
			}
		}

		private boolean isEven(int row, int column) {
			return ((column + row) % 2) == 1;
		}
	}

	public Checkers2() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setResizable(false);
		setTitle("Jeu de dames");
		setLayout(new BorderLayout());
		getContentPane().add(new BoardComponent(), BorderLayout.CENTER);
		statusBar = new JLabel("Current player");
		getContentPane().add(statusBar, BorderLayout.SOUTH);
		pack();
		redraw();

		addMouseListener(this);

	}

	public void redraw() {
		String msg = (board.getCurrentPlayer() == 0) ? "Noir" : "Blanc";
		statusBar.setText("Joueur actuel: " + msg);
		repaint();
	}

	@Override
	public void mouseClicked(MouseEvent e) {
	}

	@Override
	public void mousePressed(MouseEvent e) {
		int i = e.getX() / 80;
		int j = e.getY() / 80;
		if (board.getPiece(i, j) == board.getCurrentPlayer()) {
			selectedPiece = new int[2];
			selectedPiece[0] = i;
			selectedPiece[1] = j;
		} else {
			selectedPiece = null;
		}
	}

	@Override
	public void mouseReleased(MouseEvent e) {
		if (selectedPiece == null) {
			return;
		}
		int i = e.getX() / 80;
		int j = e.getY() / 80;
		if (board.movePiece(selectedPiece[0], selectedPiece[1], i, j)) {
			redraw();
		}
		selectedPiece = null;

	}

	@Override
	public void mouseEntered(MouseEvent e) {
	}

	@Override
	public void mouseExited(MouseEvent e) {
	}

}
